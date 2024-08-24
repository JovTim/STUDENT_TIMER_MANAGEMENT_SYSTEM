namespace timerManagement
{
    partial class listForm
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
            allStudentList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            label1 = new Label();
            buttonRemove = new Button();
            SuspendLayout();
            // 
            // allStudentList
            // 
            allStudentList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            allStudentList.FullRowSelect = true;
            allStudentList.GridLines = true;
            allStudentList.Location = new Point(12, 122);
            allStudentList.Name = "allStudentList";
            allStudentList.Size = new Size(675, 477);
            allStudentList.TabIndex = 0;
            allStudentList.UseCompatibleStateImageBehavior = false;
            allStudentList.View = View.Details;
            allStudentList.SelectedIndexChanged += allStudentList_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Student No.";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Student";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Time Start";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Time Expected";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Time End";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Status";
            columnHeader6.Width = 100;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(241, 9);
            label1.Name = "label1";
            label1.Size = new Size(172, 42);
            label1.TabIndex = 1;
            label1.Text = "EVENT TITLE";
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(279, 605);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(94, 29);
            buttonRemove.TabIndex = 2;
            buttonRemove.Text = "On Time";
            buttonRemove.UseVisualStyleBackColor = true;
            // 
            // listForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 646);
            Controls.Add(buttonRemove);
            Controls.Add(label1);
            Controls.Add(allStudentList);
            MaximizeBox = false;
            Name = "listForm";
            Text = "STUDENT LIST";
            Load += listForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView allStudentList;
        private Label label1;
        private Button buttonRemove;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}