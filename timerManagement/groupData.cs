using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace timerManagement
{
    public partial class groupData : UserControl
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
        public groupData()
        {
            InitializeComponent();
            this.Load += new EventHandler(groupData_Load);
        }

        private void groupData_Load(object? sender, EventArgs e)
        {
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            int minutes = 15;
            int seconds = 00;
            totalSeconds = (minutes * 60) + seconds;

            groupTimer.Start();

        }

        public void groupNameTitle(string group)
        {
            groupName.Text = group;
        }
        private void groupDelete_Click(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                this.Parent.Controls.Remove(this);
                this.Dispose();
            }
        }

        private void groupTimer_Tick(object sender, EventArgs e)
        {
            if (totalSeconds > 0)
            {
                totalSeconds--;
                int minutes = totalSeconds / 60;
                int seconds = totalSeconds - (minutes * 60);

                groupControlTime.Text = $"{minutes:D2}:{seconds:D2}";
            }
            else
            {
                groupTimer.Stop();
                if (this.Parent != null)
                {
                    this.Parent.Controls.Remove(this);
                    this.Dispose();
                }
            }
        }

        private void groupControlTime_Click(object sender, EventArgs e)
        {

        }

        private void groupName_Click(object sender, EventArgs e)
        {

        }
    }
}
