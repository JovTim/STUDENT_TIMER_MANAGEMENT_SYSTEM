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
    public partial class groupForm : Form
    {
        private Form1 _form1;
        public groupForm(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
        }

        private void groupConfirm_Click(object sender, EventArgs e)
        {
            groupData groupData = new groupData();
            _form1.AddGroupData(groupData);

            groupData.groupNameTitle(groupNameTextBox.Text);

            this.Close();
        }

        private void groupNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupForm_Load(object sender, EventArgs e)
        {

        }
    }
}
