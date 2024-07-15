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
            listView1 = new ListView();
            studentNumber = new ColumnHeader();
            lastName = new ColumnHeader();
            label1 = new Label();
            buttonRemove = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { studentNumber, lastName });
            listView1.Location = new Point(12, 122);
            listView1.Name = "listView1";
            listView1.Size = new Size(460, 367);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // studentNumber
            // 
            studentNumber.Text = "Student No.";
            // 
            // lastName
            // 
            lastName.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(157, 9);
            label1.Name = "label1";
            label1.Size = new Size(172, 42);
            label1.TabIndex = 1;
            label1.Text = "EVENT TITLE";
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(193, 503);
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
            ClientSize = new Size(484, 544);
            Controls.Add(buttonRemove);
            Controls.Add(label1);
            Controls.Add(listView1);
            MaximizeBox = false;
            Name = "listForm";
            Text = "LATE STUDENTS";
            Load += listForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Label label1;
        private ColumnHeader studentNumber;
        private ColumnHeader lastName;
        private Button buttonRemove;
    }
}