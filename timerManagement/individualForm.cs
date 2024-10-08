﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timerManagement
{
    public partial class individualForm : Form
    {
        private Form1 _form1;
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public static string SetValueForText3 = "";
        public static string SetValueForText4 = "";

        private sqliteDataAccess dataAccess;
        public individualForm(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
            dataAccess = new sqliteDataAccess();
        }

        private void indiConfirm_Click(object sender, EventArgs e)
        {
            individualData indiData = new individualData();
            _form1.AddUserControl(indiData);

            SetValueForText1 = indiStudentId.Text;
            SetValueForText2 = indiStuLast.Text;
            SetValueForText3 = indiStuFirst.Text;
            SetValueForText4 = textBox1.Text;

            indiData.SetIndividualData(SetValueForText1, SetValueForText2, SetValueForText3, SetValueForText4);

            string timeStart = DateTime.Now.ToString("HH:mm:ss");
            string timeExpected = DateTime.Now.AddMinutes(15).ToString("HH:mm:ss");

            if (!dataAccess.studentRecordChecker(SetValueForText1))
            {
                dataAccess.InsertIndividualStudent(SetValueForText1, SetValueForText2, SetValueForText3, SetValueForText4);
                dataAccess.InsertTimeTracked(SetValueForText1, timeStart, timeExpected, "---", 3);
            }
            else
            {
                //dataAccess.InsertIndividualStudent(SetValueForText1, SetValueForText2, SetValueForText3, SetValueForText4);
                dataAccess.InsertTimeTracked(SetValueForText1, timeStart, timeExpected, "---", 3);
            }



            indiStudentId.Clear();
            indiStuLast.Clear();
            indiStuFirst.Clear();
            textBox1.Clear();
            this.Close();
        }

        private void indiStudentId_TextChanged(object sender, EventArgs e)
        {

        }

        private void indiStuFirst_TextChanged(object sender, EventArgs e)
        {

        }

        private void indiStuLast_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void individualForm_Load(object sender, EventArgs e)
        {

        }
    }
}
