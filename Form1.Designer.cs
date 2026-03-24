namespace EchoMessenger
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
            button1 = new Button();
            EchoMessege = new Label();
            listBox1 = new ListBox();
            txtmsg = new TextBox();
            lblCount = new Label();
            btnDelete = new Button();
            btnClear = new Button();
            lblLength = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(609, 333);
            button1.Name = "button1";
            button1.Size = new Size(149, 67);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // EchoMessege
            // 
            EchoMessege.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            EchoMessege.ForeColor = Color.Blue;
            EchoMessege.Location = new Point(31, 23);
            EchoMessege.Name = "EchoMessege";
            EchoMessege.Size = new Size(191, 60);
            EchoMessege.TabIndex = 1;
            EchoMessege.Text = "EchoMessege";
            EchoMessege.Click += label1_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("맑은 고딕", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(31, 86);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(716, 204);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // txtmsg
            // 
            txtmsg.Location = new Point(31, 335);
            txtmsg.Name = "txtmsg";
            txtmsg.Multiline = true;
            txtmsg.Size = new Size(572, 63);
            txtmsg.TabIndex = 3;
            txtmsg.TextChanged += textBox1_TextChanged;
            txtmsg.KeyDown += txtmsg_KeyDown;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(31, 416);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(94, 15);
            lblCount.TabIndex = 4;
            lblCount.Text = "현재 대화: 0개";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(609, 410);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(149, 33);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "삭제";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(453, 410);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 33);
            btnClear.TabIndex = 6;
            btnClear.Text = "대화 기록 삭제";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblLength
            // 
            lblLength.AutoSize = true;
            lblLength.Location = new Point(31, 315);
            lblLength.Name = "lblLength";
            lblLength.Size = new Size(101, 15);
            lblLength.TabIndex = 7;
            lblLength.Text = "입력 길이: 0/50";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 480);
            Controls.Add(lblLength);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(lblCount);
            Controls.Add(txtmsg);
            Controls.Add(listBox1);
            Controls.Add(EchoMessege);
            Controls.Add(button1);
            Name = "Form1";
            Text = "에코 메신저";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label EchoMessege;
        private ListBox listBox1;
        private TextBox txtmsg;
        private Label lblCount;
        private Button btnDelete;
        private Button btnClear;
        private Label lblLength;
    }
}
