namespace timerManagement
{
    partial class individualData
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
            fullNameLabel = new Label();
            controlTime = new Label();
            buttonDelete = new Button();
            userIdLbael = new Label();
            indiTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fullNameLabel.ForeColor = SystemColors.ButtonHighlight;
            fullNameLabel.Location = new Point(3, 48);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(195, 35);
            fullNameLabel.TabIndex = 0;
            fullNameLabel.Text = "Last, First Initial";
            fullNameLabel.Click += fullNameLabel_Click;
            // 
            // controlTime
            // 
            controlTime.AutoSize = true;
            controlTime.Font = new Font("Impact", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            controlTime.ForeColor = SystemColors.ButtonHighlight;
            controlTime.Location = new Point(86, 92);
            controlTime.Name = "controlTime";
            controlTime.Size = new Size(217, 98);
            controlTime.TabIndex = 1;
            controlTime.Text = "15:00";
            controlTime.Click += controlTime_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(325, 3);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(68, 29);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // userIdLbael
            // 
            userIdLbael.AutoSize = true;
            userIdLbael.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userIdLbael.ForeColor = SystemColors.ButtonHighlight;
            userIdLbael.Location = new Point(3, 3);
            userIdLbael.Name = "userIdLbael";
            userIdLbael.Size = new Size(174, 42);
            userIdLbael.TabIndex = 3;
            userIdLbael.Text = "Student No.";
            // 
            // indiTimer
            // 
            indiTimer.Interval = 1000;
            indiTimer.Tick += indiTimer_Tick;
            // 
            // individualData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(userIdLbael);
            Controls.Add(buttonDelete);
            Controls.Add(controlTime);
            Controls.Add(fullNameLabel);
            Name = "individualData";
            Size = new Size(396, 239);
            Load += individualData_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label fullNameLabel;
        private Label controlTime;
        private Button buttonDelete;
        private Label userIdLbael;
        private System.Windows.Forms.Timer indiTimer;
    }
}
