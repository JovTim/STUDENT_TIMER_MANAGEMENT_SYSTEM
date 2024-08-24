using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timerManagement
{
    public partial class listForm : Form
    {
        private sqliteDataAccess dataAccess;

        public listForm()
        {
            InitializeComponent();
            dataAccess = new sqliteDataAccess();
            loadStudentList();
        }

        private void listForm_Load(object sender, EventArgs e)
        {
            
            
        }

        private string splitter(string s)
        {
            string[] samp = s.Split('.');
            return $"{samp[0]} {samp[1]}";
        }

        private void loadStudentList()
        {
            List<string[]> people = dataAccess.loadStudent();
            allStudentList.Items.Clear();
            foreach (string[] person in people)
            {
                var listViewItem = new ListViewItem(person);
                allStudentList.Items.Add(listViewItem);
            }
        }
        private void allStudentList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
