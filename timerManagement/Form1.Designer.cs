namespace timerManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            addGroup = new Button();
            evenTitle = new Label();
            addButton = new Button();
            label2 = new Label();
            timeForm = new Label();
            eventTextBox = new TextBox();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            panel2 = new Panel();
            buttonStart = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            digitalClock1 = new digitalClock();
            buttonFormList = new Button();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = SystemColors.ActiveBorder;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Location = new Point(332, 5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(791, 610);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(addGroup);
            panel1.Controls.Add(evenTitle);
            panel1.Controls.Add(addButton);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(788, 40);
            panel1.TabIndex = 0;
            // 
            // addGroup
            // 
            addGroup.Dock = DockStyle.Left;
            addGroup.Enabled = false;
            addGroup.Location = new Point(102, 0);
            addGroup.Name = "addGroup";
            addGroup.Size = new Size(110, 40);
            addGroup.TabIndex = 0;
            addGroup.TabStop = false;
            addGroup.Text = "GROUP";
            addGroup.UseVisualStyleBackColor = true;
            addGroup.Click += addGroup_Click;
            // 
            // evenTitle
            // 
            evenTitle.AutoSize = true;
            evenTitle.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            evenTitle.Location = new Point(370, 1);
            evenTitle.Name = "evenTitle";
            evenTitle.Size = new Size(151, 37);
            evenTitle.TabIndex = 3;
            evenTitle.Text = "EVENT TITLE";
            // 
            // addButton
            // 
            addButton.Dock = DockStyle.Left;
            addButton.Enabled = false;
            addButton.Location = new Point(0, 0);
            addButton.Name = "addButton";
            addButton.Size = new Size(102, 40);
            addButton.TabIndex = 0;
            addButton.TabStop = false;
            addButton.Text = "INDIVIDUAL";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 10);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 6;
            label2.Text = "label2";
            // 
            // timeForm
            // 
            timeForm.AutoSize = true;
            timeForm.Font = new Font("Impact", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeForm.Location = new Point(-3, 9);
            timeForm.Name = "timeForm";
            timeForm.Size = new Size(332, 98);
            timeForm.TabIndex = 1;
            timeForm.Text = "00:00:00";
            // 
            // eventTextBox
            // 
            eventTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eventTextBox.Location = new Point(3, 30);
            eventTextBox.Name = "eventTextBox";
            eventTextBox.Size = new Size(274, 34);
            eventTextBox.TabIndex = 2;
            eventTextBox.TextChanged += eventTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 3;
            label1.Text = "EVENT NAME";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(3, 70);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(274, 27);
            dateTimePicker1.TabIndex = 4;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(buttonStart);
            panel2.Controls.Add(eventTextBox);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 114);
            panel2.Name = "panel2";
            panel2.Size = new Size(309, 138);
            panel2.TabIndex = 5;
            // 
            // buttonStart
            // 
            buttonStart.Enabled = false;
            buttonStart.Location = new Point(96, 103);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(94, 29);
            buttonStart.TabIndex = 0;
            buttonStart.TabStop = false;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // digitalClock1
            // 
            digitalClock1.Location = new Point(15, 11);
            digitalClock1.Name = "digitalClock1";
            digitalClock1.Size = new Size(300, 97);
            digitalClock1.TabIndex = 6;
            // 
            // buttonFormList
            // 
            buttonFormList.Enabled = false;
            buttonFormList.Location = new Point(12, 258);
            buttonFormList.Name = "buttonFormList";
            buttonFormList.Size = new Size(309, 75);
            buttonFormList.TabIndex = 7;
            buttonFormList.Text = "LATE LIST";
            buttonFormList.UseVisualStyleBackColor = true;
            buttonFormList.Click += buttonFormList_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 618);
            Controls.Add(buttonFormList);
            Controls.Add(digitalClock1);
            Controls.Add(panel2);
            Controls.Add(timeForm);
            Controls.Add(flowLayoutPanel1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "STUDENT TIMER MANAGEMENT SYSTEM";
            Load += Form1_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label timeForm;
        private Panel panel1;
        private Button addButton;
        private Label evenTitle;
        private Button addGroup;
        private TextBox eventTextBox;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private Button buttonStart;
        private Label label2;
        private digitalClock digitalClock1;
        private Button buttonFormList;
    }
}
