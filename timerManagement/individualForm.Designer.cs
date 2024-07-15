namespace timerManagement
{
    partial class individualForm
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
            indiConfirm = new Button();
            SuspendLayout();
            // 
            // indiConfirm
            // 
            indiConfirm.Location = new Point(156, 207);
            indiConfirm.Name = "indiConfirm";
            indiConfirm.Size = new Size(114, 39);
            indiConfirm.TabIndex = 0;
            indiConfirm.TabStop = false;
            indiConfirm.Text = "Confirm";
            indiConfirm.UseVisualStyleBackColor = true;
            indiConfirm.Click += indiConfirm_Click;
            // 
            // individualForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 258);
            Controls.Add(indiConfirm);
            Name = "individualForm";
            Text = "ADD USER INFORMATION";
            ResumeLayout(false);
        }

        #endregion

        private Button indiConfirm;
    }
}