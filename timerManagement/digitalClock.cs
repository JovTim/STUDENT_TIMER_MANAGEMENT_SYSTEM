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
    public partial class digitalClock : UserControl
    {
        public digitalClock()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void digitalClock_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void clock_Click(object sender, EventArgs e)
        {

        }
    }
}
