using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace timerManagement
{
    public class sqliteDataAccess
    {
        
        public List<string> loadStudent()
        {
            List<string> output = new List<string>();
            using (IDbConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                cnn.Open();
                using (IDbCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = studentData();
                    using (IDataReader reader =  cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string fullInfo = $"{reader["student_id_no"]} {reader["student"]} {reader["time_start"]} {reader["time_expected"]} {reader["time_end"]} {reader["status_type"]}";

                            output.Add(fullInfo);
                        }
                    }
                }
            }
            return output;
        }

        private string loadConnectionString(string id = "Default")
        {
            return "Data Source=.\\studentTimeTrackerDB.db;Version=3";
        }

        private string studentData()
        {
            return @"
            SELECT STUDENT.student_id_no, STUDENT.first_name || '.' || STUDENT.last_name AS 'student',
            TIME_TRACKED.time_start, TIME_TRACKED.time_expected, TIME_TRACKED.time_end, STATUS.status_type
            FROM STUDENT
            INNER JOIN TIME_TRACKED 
                ON TIME_TRACKED.id_individual = STUDENT.id_student
            INNER JOIN STATUS
                ON TIME_TRACKED.id_status = STATUS.id_status

            UNION ALL

            SELECT STUDENT.student_id_no, STUDENT.first_name || '.' || STUDENT.last_name AS 'student',
            TIME_TRACKED.time_start, TIME_TRACKED.time_expected, TIME_TRACKED.time_end, STATUS.status_type
            FROM STUDENT
            INNER JOIN GROUP_STUDENT
                ON GROUP_STUDENT.id_student = STUDENT.id_student
            INNER JOIN 'GROUP'
                ON GROUP_STUDENT.id_group = 'GROUP'.id_group
            INNER JOIN TIME_TRACKED
                ON GROUP_STUDENT.id = TIME_TRACKED.id_indi_group
            INNER JOIN STATUS
                ON TIME_TRACKED.id_status = STATUS.id_status";
        }
        
    }
}
