using System;
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
        public individualForm(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
        }

        private void indiConfirm_Click(object sender, EventArgs e)
        {
            individualData indiData = new individualData();
            _form1.AddUserControl(indiData);

            this.Close();
        }
    }
}
