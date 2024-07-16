namespace timerManagement
{
    partial class groupData
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupName = new Label();
            label1 = new Label();
            buttonShow = new Button();
            groupDelete = new Button();
            SuspendLayout();
            // 
            // groupName
            // 
            groupName.AutoSize = true;
            groupName.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupName.Location = new Point(0, 0);
            groupName.Name = "groupName";
            groupName.Size = new Size(128, 42);
            groupName.TabIndex = 0;
            groupName.Text = "AMBATU";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(-13, 42);
            label1.Name = "label1";
            label1.Size = new Size(303, 98);
            label1.TabIndex = 1;
            label1.Text = "15:50:21";
            // 
            // buttonShow
            // 
            buttonShow.Location = new Point(3, 207);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(94, 29);
            buttonShow.TabIndex = 0;
            buttonShow.TabStop = false;
            buttonShow.Text = "Show List";
            buttonShow.UseVisualStyleBackColor = true;
            // 
            // groupDelete
            // 
            groupDelete.Location = new Point(325, 3);
            groupDelete.Name = "groupDelete";
            groupDelete.Size = new Size(68, 29);
            groupDelete.TabIndex = 3;
            groupDelete.Text = "Delete";
            groupDelete.UseVisualStyleBackColor = true;
            groupDelete.Click += groupDelete_Click;
            // 
            // groupData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            Controls.Add(groupDelete);
            Controls.Add(buttonShow);
            Controls.Add(label1);
            Controls.Add(groupName);
            Name = "groupData";
            Size = new Size(396, 239);
            Load += groupData_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label groupName;
        private Label label1;
        private Button buttonShow;
        private Button groupDelete;
    }
}
