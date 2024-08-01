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
            components = new System.ComponentModel.Container();
            groupName = new Label();
            groupControlTime = new Label();
            buttonShow = new Button();
            groupDelete = new Button();
            groupTimer = new System.Windows.Forms.Timer(components);
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
            groupName.Click += groupName_Click;
            // 
            // groupControlTime
            // 
            groupControlTime.AutoSize = true;
            groupControlTime.Font = new Font("Impact", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupControlTime.Location = new Point(86, 92);
            groupControlTime.Name = "groupControlTime";
            groupControlTime.Size = new Size(217, 98);
            groupControlTime.TabIndex = 1;
            groupControlTime.Text = "15:00";
            groupControlTime.Click += groupControlTime_Click;
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
            // groupTimer
            // 
            groupTimer.Interval = 1000;
            groupTimer.Tick += groupTimer_Tick;
            // 
            // groupData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            Controls.Add(groupDelete);
            Controls.Add(buttonShow);
            Controls.Add(groupControlTime);
            Controls.Add(groupName);
            Name = "groupData";
            Size = new Size(396, 239);
            Load += groupData_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label groupName;
        private Label groupControlTime;
        private Button buttonShow;
        private Button groupDelete;
        private System.Windows.Forms.Timer groupTimer;
    }
}
