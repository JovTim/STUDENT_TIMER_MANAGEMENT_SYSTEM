using static timerManagement.individualData;

namespace timerManagement
{
    public partial class Form1 : Form
    {
        private sqliteDataAccess dataAccess;
        public Form1()
        {
            InitializeComponent();
            dataAccess = new sqliteDataAccess();
            loadStudentLate();
            loadStudentOnTime();
        }

        private void loadStudentLate()
        {
            if (listViewOnTime.Enabled)
            {
                List<string[]> people = dataAccess.loadStudentLate();
                listViewLate.Items.Clear();
                foreach (string[] person in people)
                {
                    var listViewItem = new ListViewItem(person);
                    listViewLate.Items.Add(listViewItem);
                }
            }
        }

        public void loadStudentOnTime()
        {
            if (listViewOnTime.Enabled)
            {
                List<string[]> people = dataAccess.loadStudentOnTime();
                listViewOnTime.Items.Clear();
                foreach (string[] person in people)
                {
                    var listViewItem = new ListViewItem(person);
                    listViewOnTime.Items.Add(listViewItem);
                }
            }
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
            loadStudentLate();
            loadStudentOnTime();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {

            addButton.Enabled = true;
            addGroup.Enabled = true;
            listViewLate.Enabled = true;
            listViewOnTime.Enabled = true;
            eventTextBox.Enabled = false;
            dateTimePicker1.Enabled = false;
            buttonStart.Enabled = false;
            buttonFormList.Enabled = true;
            MessageBox.Show($"{eventTextBox.Text} csv file has been created!", "Success!");

            loadStudentLate();
            loadStudentOnTime();

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
            evenTitle.Text = eventTextBox.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void buttonFormList_Click(object sender, EventArgs e)
        {
            loadStudentLate();
            loadStudentOnTime();
            listForm liform = new listForm();
            liform.ShowDialog();

        }

        private void evenTitle_Click(object sender, EventArgs e)
        {

        }

        private void onTimeList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewLate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Doy you want to close the Application?", 
                "Exit", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
