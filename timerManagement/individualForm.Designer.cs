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
            indiStudentId = new TextBox();
            indiStuFirst = new TextBox();
            indiStuLast = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
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
            // indiStudentId
            // 
            indiStudentId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            indiStudentId.Location = new Point(53, 68);
            indiStudentId.Name = "indiStudentId";
            indiStudentId.Size = new Size(328, 34);
            indiStudentId.TabIndex = 1;
            indiStudentId.TextChanged += indiStudentId_TextChanged;
            // 
            // indiStuFirst
            // 
            indiStuFirst.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            indiStuFirst.Location = new Point(53, 139);
            indiStuFirst.Name = "indiStuFirst";
            indiStuFirst.Size = new Size(124, 34);
            indiStuFirst.TabIndex = 2;
            indiStuFirst.TextChanged += indiStuFirst_TextChanged;
            // 
            // indiStuLast
            // 
            indiStuLast.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            indiStuLast.Location = new Point(183, 139);
            indiStuLast.Name = "indiStuLast";
            indiStuLast.Size = new Size(134, 34);
            indiStuLast.TabIndex = 3;
            indiStuLast.TextChanged += indiStuLast_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 45);
            label1.Name = "label1";
            label1.Size = new Size(156, 20);
            label1.TabIndex = 4;
            label1.Text = "STUDENT ID NUMBER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 116);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 5;
            label2.Text = "LAST NAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(183, 116);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 6;
            label3.Text = "FIRST NAME";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(323, 139);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(38, 34);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(323, 116);
            label4.Name = "label4";
            label4.Size = new Size(32, 20);
            label4.TabIndex = 8;
            label4.Text = "M.I.";
            // 
            // individualForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 258);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(indiStuLast);
            Controls.Add(indiStuFirst);
            Controls.Add(indiStudentId);
            Controls.Add(indiConfirm);
            Name = "individualForm";
            Text = "ADD USER INFORMATION";
            Load += individualForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button indiConfirm;
        private TextBox indiStudentId;
        private TextBox indiStuFirst;
        private TextBox indiStuLast;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
    }
}