namespace timerManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            addGroup = new Button();
            evenTitle = new Label();
            addButton = new Button();
            label2 = new Label();
            timeForm = new Label();
            eventTextBox = new TextBox();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            panel2 = new Panel();
            buttonStart = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            digitalClock1 = new digitalClock();
            buttonFormList = new Button();
            panel3 = new Panel();
            label4 = new Label();
            label3 = new Label();
            onTimeList = new ListView();
            oStudentIDCol = new ColumnHeader();
            oLastNameCol = new ColumnHeader();
            oFirstName = new ColumnHeader();
            omiddleInitialCol = new ColumnHeader();
            listView1 = new ListView();
            studentIDCol = new ColumnHeader();
            lastNameCol = new ColumnHeader();
            firstNameCol = new ColumnHeader();
            middleInitialCol = new ColumnHeader();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = SystemColors.ActiveBorder;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Location = new Point(332, 5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(834, 690);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(addGroup);
            panel1.Controls.Add(evenTitle);
            panel1.Controls.Add(addButton);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(831, 40);
            panel1.TabIndex = 0;
            // 
            // addGroup
            // 
            addGroup.Dock = DockStyle.Left;
            addGroup.Enabled = false;
            addGroup.Location = new Point(102, 0);
            addGroup.Name = "addGroup";
            addGroup.Size = new Size(110, 40);
            addGroup.TabIndex = 0;
            addGroup.TabStop = false;
            addGroup.Text = "GROUP";
            addGroup.UseVisualStyleBackColor = true;
            addGroup.Click += addGroup_Click;
            // 
            // evenTitle
            // 
            evenTitle.AutoSize = true;
            evenTitle.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            evenTitle.ForeColor = SystemColors.ControlText;
            evenTitle.Location = new Point(313, 0);
            evenTitle.Name = "evenTitle";
            evenTitle.Size = new Size(151, 37);
            evenTitle.TabIndex = 3;
            evenTitle.Text = "EVENT TITLE";
            evenTitle.Click += evenTitle_Click;
            // 
            // addButton
            // 
            addButton.Dock = DockStyle.Left;
            addButton.Enabled = false;
            addButton.Location = new Point(0, 0);
            addButton.Name = "addButton";
            addButton.Size = new Size(102, 40);
            addButton.TabIndex = 0;
            addButton.TabStop = false;
            addButton.Text = "INDIVIDUAL";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 10);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 6;
            label2.Text = "label2";
            // 
            // timeForm
            // 
            timeForm.AutoSize = true;
            timeForm.Font = new Font("Impact", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeForm.Location = new Point(-3, 9);
            timeForm.Name = "timeForm";
            timeForm.Size = new Size(332, 98);
            timeForm.TabIndex = 1;
            timeForm.Text = "00:00:00";
            // 
            // eventTextBox
            // 
            eventTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eventTextBox.Location = new Point(3, 30);
            eventTextBox.Name = "eventTextBox";
            eventTextBox.Size = new Size(274, 34);
            eventTextBox.TabIndex = 2;
            eventTextBox.TextChanged += eventTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 3;
            label1.Text = "EVENT NAME";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(3, 70);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(274, 27);
            dateTimePicker1.TabIndex = 4;
            dateTimePicker1.Value = new DateTime(2024, 8, 1, 7, 30, 33, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(buttonStart);
            panel2.Controls.Add(eventTextBox);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 114);
            panel2.Name = "panel2";
            panel2.Size = new Size(309, 138);
            panel2.TabIndex = 5;
            // 
            // buttonStart
            // 
            buttonStart.Enabled = false;
            buttonStart.Location = new Point(96, 103);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(94, 29);
            buttonStart.TabIndex = 0;
            buttonStart.TabStop = false;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // digitalClock1
            // 
            digitalClock1.Location = new Point(12, 12);
            digitalClock1.Name = "digitalClock1";
            digitalClock1.Size = new Size(309, 97);
            digitalClock1.TabIndex = 6;
            // 
            // buttonFormList
            // 
            buttonFormList.Enabled = false;
            buttonFormList.Location = new Point(12, 258);
            buttonFormList.Name = "buttonFormList";
            buttonFormList.Size = new Size(309, 75);
            buttonFormList.TabIndex = 7;
            buttonFormList.Text = "CHECK ALL STUDENTS";
            buttonFormList.UseVisualStyleBackColor = true;
            buttonFormList.Click += buttonFormList_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(onTimeList);
            panel3.Controls.Add(listView1);
            panel3.Location = new Point(1172, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(446, 671);
            panel3.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 351);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 3;
            label4.Text = "ON TIME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 10);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 2;
            label3.Text = "LATE";
            // 
            // onTimeList
            // 
            onTimeList.Columns.AddRange(new ColumnHeader[] { oStudentIDCol, oLastNameCol, oFirstName, omiddleInitialCol });
            onTimeList.FullRowSelect = true;
            onTimeList.GridLines = true;
            onTimeList.Location = new Point(3, 374);
            onTimeList.Name = "onTimeList";
            onTimeList.Size = new Size(435, 294);
            onTimeList.TabIndex = 1;
            onTimeList.UseCompatibleStateImageBehavior = false;
            onTimeList.View = View.Details;
            onTimeList.SelectedIndexChanged += onTimeList_SelectedIndexChanged;
            // 
            // oStudentIDCol
            // 
            oStudentIDCol.Text = "Student ID";
            oStudentIDCol.Width = 110;
            // 
            // oLastNameCol
            // 
            oLastNameCol.Text = "Last Name";
            oLastNameCol.Width = 110;
            // 
            // oFirstName
            // 
            oFirstName.Text = "First Name";
            oFirstName.Width = 110;
            // 
            // omiddleInitialCol
            // 
            omiddleInitialCol.Text = "Middle Initial";
            omiddleInitialCol.Width = 110;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { studentIDCol, lastNameCol, firstNameCol, middleInitialCol });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(3, 33);
            listView1.Name = "listView1";
            listView1.Size = new Size(435, 305);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // studentIDCol
            // 
            studentIDCol.Text = "Student ID";
            studentIDCol.Width = 110;
            // 
            // lastNameCol
            // 
            lastNameCol.Text = "Last Name";
            lastNameCol.Width = 110;
            // 
            // firstNameCol
            // 
            firstNameCol.Text = "First Name";
            firstNameCol.Width = 110;
            // 
            // middleInitialCol
            // 
            middleInitialCol.Text = "Middle Inital";
            middleInitialCol.Width = 100;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1621, 707);
            Controls.Add(panel3);
            Controls.Add(buttonFormList);
            Controls.Add(digitalClock1);
            Controls.Add(panel2);
            Controls.Add(timeForm);
            Controls.Add(flowLayoutPanel1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "STUDENT TIMER TRACKER MANAGEMENT SYSTEM";
            Load += Form1_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label timeForm;
        private Panel panel1;
        private Button addButton;
        private Label evenTitle;
        private Button addGroup;
        private TextBox eventTextBox;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private Button buttonStart;
        private Label label2;
        private digitalClock digitalClock1;
        private Button buttonFormList;
        private Panel panel3;
        private Label label4;
        private Label label3;
        private ListView onTimeList;
        private ListView listView1;
        private ColumnHeader oStudentIDCol;
        private ColumnHeader oLastNameCol;
        private ColumnHeader oFirstName;
        private ColumnHeader omiddleInitialCol;
        private ColumnHeader studentIDCol;
        private ColumnHeader lastNameCol;
        private ColumnHeader firstNameCol;
        private ColumnHeader middleInitialCol;
    }
}
