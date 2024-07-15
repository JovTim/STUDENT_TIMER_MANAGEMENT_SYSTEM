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
            fullNameLabel = new Label();
            controlTime = new Label();
            buttonDelete = new Button();
            SuspendLayout();
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fullNameLabel.ForeColor = SystemColors.ButtonHighlight;
            fullNameLabel.Location = new Point(0, 0);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(249, 42);
            fullNameLabel.TabIndex = 0;
            fullNameLabel.Text = "Dela Cruz, Juan P.";
            // 
            // controlTime
            // 
            controlTime.AutoSize = true;
            controlTime.Font = new Font("Impact", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            controlTime.ForeColor = SystemColors.ButtonHighlight;
            controlTime.Location = new Point(-14, 42);
            controlTime.Name = "controlTime";
            controlTime.Size = new Size(312, 98);
            controlTime.TabIndex = 1;
            controlTime.Text = "15:43:20";
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(292, 3);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(68, 29);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // individualData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(buttonDelete);
            Controls.Add(controlTime);
            Controls.Add(fullNameLabel);
            Name = "individualData";
            Size = new Size(363, 212);
            Load += individualData_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label fullNameLabel;
        private Label controlTime;
        private Button buttonDelete;
    }
}
