namespace timerManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            individualForm indiForm = new individualForm(this);
            indiForm.ShowDialog();
            label2.Focus();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void AddUserControl(UserControl userControl)
        {
            flowLayoutPanel1.Controls.Add(userControl);
        }

        public void AddGroupData(groupData groupData)
        {
            flowLayoutPanel1.Controls.Add(groupData);
        }

        private void addGroup_Click(object sender, EventArgs e)
        {
            groupForm groupForm = new groupForm(this);
            groupForm.ShowDialog();
            label2.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //timeForm.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //timer1.Start();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {

            addButton.Enabled = true;
            addGroup.Enabled = true;
            eventTextBox.Enabled = false;
            dateTimePicker1.Enabled = false;
            buttonStart.Enabled = false;

        }

        private void eventTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(eventTextBox.Text))
            {
                buttonStart.Enabled = true;
            }
            else
            {
                buttonStart.Enabled = false;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
