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
            SuspendLayout();
            // 
            // groupConfirm
            // 
            groupConfirm.Location = new Point(142, 443);
            groupConfirm.Name = "groupConfirm";
            groupConfirm.Size = new Size(114, 39);
            groupConfirm.TabIndex = 0;
            groupConfirm.TabStop = false;
            groupConfirm.Text = "Confirm";
            groupConfirm.UseVisualStyleBackColor = true;
            groupConfirm.Click += groupConfirm_Click;
            // 
            // groupForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 494);
            Controls.Add(groupConfirm);
            Name = "groupForm";
            Text = "groupForm";
            ResumeLayout(false);
        }

        #endregion

        private Button groupConfirm;
    }
}