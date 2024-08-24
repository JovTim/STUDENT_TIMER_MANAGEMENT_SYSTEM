using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Security.Cryptography;

namespace timerManagement
{
    public class sqliteDataAccess
    {
        
        public List<string[]> loadStudent()
        {
            List<string[]> output = new List<string[]>();
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

                            var student_id = reader.GetString(0);
                            var student_name = reader.GetString(1);
                            var timeStart = reader.GetString(2);
                            var timeExpected = reader.GetString(3);
                            var timeEnd = reader.GetString(4);
                            var timeStatus = reader.GetString(5);

                            string[] studentInformation = { student_id, student_name, timeStart,timeExpected, timeEnd, timeStatus};

                            output.Add(studentInformation);
                        }
                    }
                }
            }
            return output;
        }

        public List<string[]> loadStudentOnTime()
        {
            List<string[]> output = new List<string[]>();
            using(IDbConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                cnn.Open();
                using(IDbCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = studentDataOnTime();
                    using (IDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var student_id = reader.GetString(0);
                            var student_last = reader.GetString(1);
                            var student_first = reader.GetString(2);
                            var student_MI = reader.GetString(3);

                            string[] studentInformation = { student_id, student_last, student_first, student_MI };

                            output.Add(studentInformation);
                        }
                    }
                }
            }
            return output;
        }

        public List<string[]> loadStudentLate()
        {
            List<string[]> output = new List<string[]>();
            using(IDbConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                cnn.Open();
                using(IDbCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = studentDataLate();
                    using (IDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var student_id = reader.GetString(0);
                            var student_last = reader.GetString(1);
                            var student_first = reader.GetString(2);
                            var student_MI = reader.GetString(3);

                            string[] studentInformation = { student_id, student_last, student_first, student_MI };
                            output.Add(studentInformation);
                        }
                    }
                }
            }
            return output;
        }


        public void InsertIndividualStudent(string studentId, string first_name, string last_name, string middle_initial) // inserting individual student
        {
            using (IDbConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                cnn.Open();
                using (IDbCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = studentIndividualInsert();

                    var paramID = cmd.CreateParameter();
                    paramID.ParameterName = "@studentId";
                    paramID.Value = studentId;
                    cmd.Parameters.Add(paramID);

                    var paramFirstName = cmd.CreateParameter();
                    paramFirstName.ParameterName = "@studentFirstName";
                    paramFirstName.Value = first_name;
                    cmd.Parameters.Add(paramFirstName);

                    var paramLastName = cmd.CreateParameter();
                    paramLastName.ParameterName = "@studentLastName";
                    paramLastName.Value = last_name;
                    cmd.Parameters.Add(paramLastName);

                    var paramMiddleInitial = cmd.CreateParameter();
                    paramMiddleInitial.ParameterName = "@studentMI";
                    paramMiddleInitial.Value = middle_initial;
                    cmd.Parameters.Add(paramMiddleInitial);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void InsertTimeTracked(string studentId, string time_start, string time_expected, string time_end, int id_status)
        {
            using (IDbConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                cnn.Open();
                using (IDbCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = studentIndividualInsertTimeTrack();

                    var paramStart = cmd.CreateParameter();
                    paramStart.ParameterName = "@time_start";
                    paramStart.Value = time_start;
                    cmd.Parameters.Add(paramStart);

                    var paramExpected = cmd.CreateParameter();
                    paramExpected.ParameterName = "@time_expected";
                    paramExpected.Value = time_expected;
                    cmd.Parameters.Add(paramExpected);

                    var paramEnd = cmd.CreateParameter();
                    paramEnd.ParameterName = "@time_end";
                    paramEnd.Value = time_end;
                    cmd.Parameters.Add(paramEnd);

                    var paramStatus = cmd.CreateParameter();
                    paramStatus.ParameterName = "@id_status";
                    paramStatus.Value = id_status;
                    cmd.Parameters.Add(paramStatus);

                    var paramID = cmd.CreateParameter();
                    paramID.ParameterName = "@student_id_no";
                    paramID.Value = studentId;
                    cmd.Parameters.Add(paramID);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateTime(string time_end, int id_status, string student_id_no)
        {
            using (IDbConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                cnn.Open();
                using (IDbCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = updateStudentTime();

                    var paramEnd = cmd.CreateParameter();
                    paramEnd.ParameterName = "@time_end";
                    paramEnd.Value = time_end;
                    cmd.Parameters.Add(paramEnd);

                    var paramStatus = cmd.CreateParameter();
                    paramStatus.ParameterName = "@id_status";
                    paramStatus.Value = id_status;
                    cmd.Parameters.Add(paramStatus);

                    var paramStuID = cmd.CreateParameter();
                    paramStuID.ParameterName = "@student_id_no";
                    paramStuID.Value = student_id_no;
                    cmd.Parameters.Add(paramStuID);

                    cmd.ExecuteNonQuery();

                }
            }

        }

        public bool studentRecordChecker(string id)
        {
            using (IDbConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                cnn.Open();
                using (IDbCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = "SELECT COUNT(*) FROM STUDENT WHERE student_id_no = @id";

                    var paramID = cmd.CreateParameter();
                    paramID.ParameterName = "@id";
                    paramID.Value = id;
                    cmd.Parameters.Add(paramID);

                    var result = Convert.ToInt32(cmd.ExecuteScalar());

                    return result > 0;
                }
            }
        }

        public void deleteTimeTracked(string id)
        {
            using (IDbConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                cnn.Open();
                using (IDbCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = @"DELETE FROM TIME_TRACKED
                                        WHERE TIME_TRACKED.id_individual = 
                                        (SELECT STUDENT.id_student
                                         FROM STUDENT
                                         WHERE STUDENT.student_id_no = @student_id_no)";

                    var paramID = cmd.CreateParameter();
                    paramID.ParameterName = "@student_id_no";
                    paramID.Value = id;
                    cmd.Parameters.Add (paramID);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private string studentData()
        {
            return @"
            SELECT STUDENT.student_id_no, STUDENT.first_name || ' ' || STUDENT.last_name AS 'student',
            TIME_TRACKED.time_start, TIME_TRACKED.time_expected, TIME_TRACKED.time_end, STATUS.status_type
            FROM STUDENT
            INNER JOIN TIME_TRACKED 
                ON TIME_TRACKED.id_individual = STUDENT.id_student
            INNER JOIN STATUS
                ON TIME_TRACKED.id_status = STATUS.id_status

            UNION ALL

            SELECT STUDENT.student_id_no, STUDENT.first_name || ' ' || STUDENT.last_name AS 'student',
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

        private string studentDataOnTime()
        {
            return @" 
            SELECT STUDENT.student_id_no, STUDENT.last_name, STUDENT.first_name, STUDENT.middle_initial
             FROM STUDENT
             INNER JOIN TIME_TRACKED 
                 ON TIME_TRACKED.id_individual = STUDENT.id_student
             INNER JOIN STATUS
                 ON TIME_TRACKED.id_status = STATUS.id_status
            WHERE STATUS.status_type = 'on time'
             UNION ALL

             SELECT STUDENT.student_id_no, STUDENT.last_name, STUDENT.first_name, STUDENT.middle_initial
             FROM STUDENT
             INNER JOIN GROUP_STUDENT
                 ON GROUP_STUDENT.id_student = STUDENT.id_student
             INNER JOIN 'GROUP'
                 ON GROUP_STUDENT.id_group = 'GROUP'.id_group
             INNER JOIN TIME_TRACKED
                 ON GROUP_STUDENT.id = TIME_TRACKED.id_indi_group
             INNER JOIN STATUS
                 ON TIME_TRACKED.id_status = STATUS.id_status
            WHERE STATUS.status_type = 'on time'";
        }

        private string studentDataLate()
        {
            return @" 
            SELECT STUDENT.student_id_no, STUDENT.last_name, STUDENT.first_name, STUDENT.middle_initial
             FROM STUDENT
             INNER JOIN TIME_TRACKED 
                 ON TIME_TRACKED.id_individual = STUDENT.id_student
             INNER JOIN STATUS
                 ON TIME_TRACKED.id_status = STATUS.id_status
            WHERE STATUS.status_type = 'late'
	 
             UNION ALL

             SELECT STUDENT.student_id_no, STUDENT.last_name, STUDENT.first_name, STUDENT.middle_initial
             FROM STUDENT
             INNER JOIN GROUP_STUDENT
                 ON GROUP_STUDENT.id_student = STUDENT.id_student
             INNER JOIN 'GROUP'
                 ON GROUP_STUDENT.id_group = 'GROUP'.id_group
             INNER JOIN TIME_TRACKED
                 ON GROUP_STUDENT.id = TIME_TRACKED.id_indi_group
             INNER JOIN STATUS
                 ON TIME_TRACKED.id_status = STATUS.id_status
            WHERE STATUS.status_type = 'late'";
        }

        private string studentIndividualInsert()
        {
            return @"INSERT INTO STUDENT(student_id_no, first_name, last_name, middle_initial) VALUES (@studentId, @studentFirstName, @studentLastName, @studentMI)";
        }

        private string studentIndividualInsertTimeTrack()
        {
            return @"INSERT INTO TIME_TRACKED(id_individual, time_start, time_expected, time_end, id_status) 
                    SELECT STUDENT.id_student, @time_start, @time_expected, @time_end, @id_status 
                    FROM STUDENT 
                    WHERE STUDENT.student_id_no = @student_id_no";
        }

        private string updateStudentTime()
        {
            return @"UPDATE TIME_TRACKED
                     SET time_end = @time_end, id_status = @id_status
                     WHERE TIME_TRACKED.id_individual = 
                    (SELECT STUDENT.id_student
                     FROM STUDENT
                     WHERE STUDENT.student_id_no = @student_id_no)";
        }

        private string loadConnectionString(string id = "Default")
        {
            return "Data Source=.\\studentTimeTrackerDB.db;Version=3";
        }

    }
}
