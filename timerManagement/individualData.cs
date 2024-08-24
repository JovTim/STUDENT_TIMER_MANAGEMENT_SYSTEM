using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;

namespace timerManagement
{
    public partial class individualData : UserControl
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        private int totalSeconds;

        private sqliteDataAccess dataAccess;

        public individualData()
        {
            InitializeComponent();
            this.Load += new EventHandler(individualData_Load);
            dataAccess = new sqliteDataAccess();
        }

        private void individualData_Load(object? sender, EventArgs e)
        {
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            int minutes = 15;
            int seconds = 00;
            totalSeconds = (minutes * 60) + seconds;

            indiTimer.Start();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                dataAccess.deleteTimeTracked(userIdLbael.Text);

                this.Parent.Controls.Remove(this);
                this.Dispose();
            }
        }

        public void SetIndividualData(string id, string firstName, string lastName, string middleInitial)
        {
            lastNameLabel.Text = lastName;
            firtNameLabel.Text = firstName;
            miLabel.Text = middleInitial;

            string fullName = $"{lastNameLabel.Text}, {firtNameLabel.Text} {miLabel.Text}.";
            fullNameLabel.Text = fullName;
            userIdLbael.Text = id;

        }

        private void fullNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void controlTime_Click(object sender, EventArgs e)
        {

        }

        private void indiTimer_Tick(object sender, EventArgs e)
        {
            if (totalSeconds > 0)
            {
                totalSeconds--;
                int minutes = totalSeconds / 60;
                int seconds = totalSeconds - (minutes * 60);
                controlTime.Text = $"{minutes:D2}:{seconds:D2}";
            }
            else
            {
                indiTimer.Stop();
                if (this.Parent != null)
                {
                    string timeEnd = DateTime.Now.ToString("HH:mm:ss");
                    dataAccess.UpdateTime(timeEnd, 2, userIdLbael.Text);
                    this.Parent.Controls.Remove(this);
                    this.Dispose();
                }

            }
        }

        private void firtNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void miLabel_Click(object sender, EventArgs e)
        {

        }

        private void lastNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void buttonOnTime_Click(object sender, EventArgs e)
        {
            
            if (this.Parent != null)
            {
                string timeEnd = DateTime.Now.ToString("HH:mm:ss");
                dataAccess.UpdateTime(timeEnd, 1, userIdLbael.Text);
                this.Parent.Controls.Remove(this);
                this.Dispose();
            }
            

            /*
            if (this.Parent != null)
            {
                Form1 mainForm = this.Parent as Form1;
                if (mainForm != null)
                {
                    string timeEnd = DateTime.Now.ToString("HH:mm:ss");
                    dataAccess.UpdateTime(timeEnd, 1, userIdLbael.Text);

                    mainForm.loadStudentOnTime();

                    this.Parent.Controls.Remove(this);
                    this.Dispose();
                }
            }
            */
            

            /*
            if (this.Parent is Form1 mainForm)
            {
                // Update the time in the database
                string timeEnd = DateTime.Now.ToString("HH:mm:ss");
                dataAccess.UpdateTime(timeEnd, 1, userIdLbael.Text);

                // Call the method to reload the ListView
                mainForm.loadStudentOnTime();

                // Remove and dispose of the UserControl
                this.Parent.Controls.Remove(this);
                this.Dispose();
            }
            else
            {
                // Handle the case where Parent is null, if necessary
                MessageBox.Show("Parent form is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
        }
    }
}
