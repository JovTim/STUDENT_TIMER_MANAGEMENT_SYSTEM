namespace timerManagement
{
    partial class groupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupConfirm = new Button();
            listView1 = new ListView();
            studentCol = new ColumnHeader();
            studentLast = new ColumnHeader();
            studentFirst = new ColumnHeader();
            studentMI = new ColumnHeader();
            groupNameTextBox = new TextBox();
            groupStudentID = new TextBox();
            groupStudentLast = new TextBox();
            groupStudentFirst = new TextBox();
            groupStudentMI = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // groupConfirm
            // 
            groupConfirm.Location = new Point(142, 528);
            groupConfirm.Name = "groupConfirm";
            groupConfirm.Size = new Size(114, 39);
            groupConfirm.TabIndex = 0;
            groupConfirm.TabStop = false;
            groupConfirm.Text = "Confirm";
            groupConfirm.UseVisualStyleBackColor = true;
            groupConfirm.Click += groupConfirm_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { studentCol, studentLast, studentFirst, studentMI });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(10, 303);
            listView1.Name = "listView1";
            listView1.Size = new Size(385, 219);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // studentCol
            // 
            studentCol.Text = "Student No.";
            studentCol.Width = 120;
            // 
            // studentLast
            // 
            studentLast.Text = "Last Name";
            studentLast.Width = 110;
            // 
            // studentFirst
            // 
            studentFirst.Text = "First Name";
            studentFirst.Width = 110;
            // 
            // studentMI
            // 
            studentMI.Text = "M.I.";
            studentMI.Width = 40;
            // 
            // groupNameTextBox
            // 
            groupNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupNameTextBox.Location = new Point(34, 41);
            groupNameTextBox.Name = "groupNameTextBox";
            groupNameTextBox.Size = new Size(281, 34);
            groupNameTextBox.TabIndex = 2;
            groupNameTextBox.TextChanged += groupNameTextBox_TextChanged;
            // 
            // groupStudentID
            // 
            groupStudentID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupStudentID.Location = new Point(34, 128);
            groupStudentID.Name = "groupStudentID";
            groupStudentID.Size = new Size(315, 34);
            groupStudentID.TabIndex = 3;
            // 
            // groupStudentLast
            // 
            groupStudentLast.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupStudentLast.Location = new Point(34, 197);
            groupStudentLast.Name = "groupStudentLast";
            groupStudentLast.Size = new Size(125, 34);
            groupStudentLast.TabIndex = 4;
            // 
            // groupStudentFirst
            // 
            groupStudentFirst.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupStudentFirst.Location = new Point(174, 197);
            groupStudentFirst.Name = "groupStudentFirst";
            groupStudentFirst.Size = new Size(125, 34);
            groupStudentFirst.TabIndex = 5;
            // 
            // groupStudentMI
            // 
            groupStudentMI.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupStudentMI.Location = new Point(305, 197);
            groupStudentMI.Name = "groupStudentMI";
            groupStudentMI.Size = new Size(44, 34);
            groupStudentMI.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 18);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 7;
            label1.Text = "GROUP NAME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 105);
            label2.Name = "label2";
            label2.Size = new Size(156, 20);
            label2.TabIndex = 8;
            label2.Text = "STUDENT ID NUMBER";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 174);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 9;
            label3.Text = "LAST NAME";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(174, 174);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 10;
            label4.Text = "FIRST NAME";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(305, 174);
            label5.Name = "label5";
            label5.Size = new Size(32, 20);
            label5.TabIndex = 11;
            label5.Text = "M.I.";
            // 
            // button1
            // 
            button1.Location = new Point(34, 257);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 12;
            button1.Text = "INSERT";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 579);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupStudentMI);
            Controls.Add(groupStudentFirst);
            Controls.Add(groupStudentLast);
            Controls.Add(groupStudentID);
            Controls.Add(groupNameTextBox);
            Controls.Add(listView1);
            Controls.Add(groupConfirm);
            Name = "groupForm";
            Text = "groupForm";
            Load += groupForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button groupConfirm;
        private ListView listView1;
        private ColumnHeader studentCol;
        private ColumnHeader studentLast;
        private ColumnHeader studentFirst;
        private ColumnHeader studentMI;
        private TextBox groupNameTextBox;
        private TextBox groupStudentID;
        private TextBox groupStudentLast;
        private TextBox groupStudentFirst;
        private TextBox groupStudentMI;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
    }
}