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
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(19, 22, 21);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.InactiveCaption;
            textBox1.Location = new Point(92, 322);
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
            textBox2.Location = new Point(92, 420);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "email";
            textBox2.Size = new Size(385, 53);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(19, 22, 21);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = SystemColors.InactiveBorder;
            textBox3.Location = new Point(92, 520);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "password";
            textBox3.Size = new Size(385, 53);
            textBox3.TabIndex = 2;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Arial Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(203, 22);
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
            label2.Location = new Point(321, 21);
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
            textBox4.Location = new Point(92, 623);
            textBox4.Margin = new Padding(0);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "password";
            textBox4.Size = new Size(385, 53);
            textBox4.TabIndex = 5;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(31, 208, 185);
            button1.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(87, 727);
            button1.Name = "button1";
            button1.Size = new Size(390, 44);
            button1.TabIndex = 6;
            button1.Text = "register";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(162, 791);
            label3.Name = "label3";
            label3.Size = new Size(230, 30);
            label3.TabIndex = 7;
            label3.Text = "already have ?";
            label3.Click += label3_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSlateGray;
            button2.Location = new Point(303, 785);
            button2.Name = "button2";
            button2.Size = new Size(89, 36);
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
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(19, 22, 21);
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.ForeColor = SystemColors.InactiveCaption;
            textBox5.Location = new Point(92, 138);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "FirstName";
            textBox5.Size = new Size(385, 53);
            textBox5.TabIndex = 10;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.FromArgb(19, 22, 21);
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.ForeColor = SystemColors.InactiveCaption;
            textBox6.Location = new Point(92, 230);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "LastName";
            textBox6.Size = new Size(385, 53);
            textBox6.TabIndex = 11;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // label9
            // 
            label9.ForeColor = Color.Red;
            label9.Location = new Point(92, 676);
            label9.Name = "label9";
            label9.Size = new Size(385, 38);
            label9.TabIndex = 17;
            label9.Text = "not same with password";
            label9.Visible = false;
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.ForeColor = Color.Red;
            label10.Location = new Point(92, 378);
            label10.Name = "label10";
            label10.Size = new Size(385, 33);
            label10.TabIndex = 18;
            label10.Text = "already exist";
            label10.Visible = false;
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.ForeColor = Color.Red;
            label11.Location = new Point(92, 476);
            label11.Name = "label11";
            label11.Size = new Size(385, 38);
            label11.TabIndex = 19;
            label11.Text = "not valid";
            label11.Visible = false;
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.ForeColor = Color.Red;
            label12.Location = new Point(92, 576);
            label12.Name = "label12";
            label12.Size = new Size(385, 38);
            label12.TabIndex = 20;
            label12.Text = "password is too short";
            label12.Visible = false;
            label12.Click += label12_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.Tomato;
            label4.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(92, 66);
            label4.Name = "label4";
            label4.Size = new Size(385, 69);
            label4.TabIndex = 21;
            label4.Text = "Rows mustn't be empty!";
            label4.Visible = false;
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.ForeColor = Color.Red;
            label5.Location = new Point(228, 378);
            label5.Name = "label5";
            label5.Size = new Size(385, 38);
            label5.TabIndex = 22;
            label5.Text = "do use expressions";
            label5.Visible = false;
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.ForeColor = Color.Red;
            label6.Location = new Point(175, 476);
            label6.Name = "label6";
            label6.Size = new Size(385, 31);
            label6.TabIndex = 23;
            label6.Text = "already exist";
            label6.Visible = false;
            // 
            // button3
            // 
            button3.Location = new Point(435, 796);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 24;
            button3.Text = "refresh";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(586, 861);
            Controls.Add(button3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
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
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button3;
    }
}