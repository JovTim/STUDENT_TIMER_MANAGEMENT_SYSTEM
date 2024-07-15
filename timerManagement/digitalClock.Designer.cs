namespace timerManagement
{
    partial class digitalClock
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
            clock = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // clock
            // 
            clock.AutoSize = true;
            clock.Font = new Font("Impact", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clock.Location = new Point(0, 0);
            clock.Name = "clock";
            clock.Size = new Size(332, 98);
            clock.TabIndex = 0;
            clock.Text = "00:00:00";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // digitalClock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(clock);
            Name = "digitalClock";
            Size = new Size(334, 99);
            Load += digitalClock_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label clock;
        private System.Windows.Forms.Timer timer1;
    }
}
