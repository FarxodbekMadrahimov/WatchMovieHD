namespace WatchMovie
{
    partial class register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox4 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(19, 22, 21);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.InactiveCaption;
            textBox1.Location = new Point(89, 107);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "UserName";
            textBox1.Size = new Size(385, 53);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(19, 22, 21);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = SystemColors.InactiveBorder;
            textBox2.Location = new Point(89, 204);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "email";
            textBox2.Size = new Size(385, 53);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(19, 22, 21);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = SystemColors.InactiveBorder;
            textBox3.Location = new Point(89, 301);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "password";
            textBox3.Size = new Size(385, 53);
            textBox3.TabIndex = 2;
            // 
            // label1
            // 
            label1.Font = new Font("Arial Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(202, 30);
            label1.Name = "label1";
            label1.Size = new Size(112, 52);
            label1.TabIndex = 3;
            label1.Text = "SIGN\r\n\r\n";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(31, 208, 185);
            label2.Location = new Point(309, 29);
            label2.Name = "label2";
            label2.Size = new Size(63, 45);
            label2.TabIndex = 4;
            label2.Text = "UP";
            label2.Click += label2_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(19, 22, 21);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.ForeColor = SystemColors.InactiveBorder;
            textBox4.Location = new Point(89, 390);
            textBox4.Margin = new Padding(0);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "password";
            textBox4.Size = new Size(385, 53);
            textBox4.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(31, 208, 185);
            button1.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(89, 502);
            button1.Name = "button1";
            button1.Size = new Size(390, 46);
            button1.TabIndex = 6;
            button1.Text = "register";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(177, 562);
            label3.Name = "label3";
            label3.Size = new Size(230, 32);
            label3.TabIndex = 7;
            label3.Text = "already have ?";
            label3.Click += label3_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSlateGray;
            button2.Location = new Point(318, 556);
            button2.Name = "button2";
            button2.Size = new Size(89, 38);
            button2.TabIndex = 8;
            button2.Text = "sign in";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(522, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(586, 618);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Cursor = Cursors.Cross;
            ForeColor = SystemColors.ControlDarkDark;
            FormBorderStyle = FormBorderStyle.None;
            Name = "register";
            StartPosition = FormStartPosition.Manual;
            TransparencyKey = Color.FromArgb(26, 30, 29);
            Load += register_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private TextBox textBox4;
        private Button button1;
        private Label label3;
        private Button button2;
        private PictureBox pictureBox1;
    }
}