namespace WatchMovie
{
    partial class homepage
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            label6 = new Label();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(254, 69);
            label1.TabIndex = 0;
            label1.Text = "                       ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1656, 9);
            label2.Name = "label2";
            label2.Size = new Size(254, 69);
            label2.TabIndex = 1;
            label2.Text = "                       ";
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(1532, 22);
            label3.Name = "label3";
            label3.Size = new Size(45, 43);
            label3.TabIndex = 2;
            label3.Text = " ";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom;
            textBox1.BackColor = Color.FromArgb(19, 22, 21);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.Menu;
            textBox1.Location = new Point(282, 104);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "                                    Search movies ...";
            textBox1.Size = new Size(1091, 44);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(31, 208, 185);
            button1.Location = new Point(390, 445);
            button1.Name = "button1";
            button1.Size = new Size(877, 54);
            button1.TabIndex = 5;
            button1.Text = "go to the homepage";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(64, 839);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // button2
            // 
            button2.Location = new Point(1504, 124);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 9;
            button2.Text = "search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1695, 124);
            button3.Name = "button3";
            button3.Size = new Size(122, 34);
            button3.TabIndex = 10;
            button3.Text = "search";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(390, 795);
            label4.Name = "label4";
            label4.Size = new Size(88, 38);
            label4.TabIndex = 11;
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(1583, 27);
            label5.Name = "label5";
            label5.Size = new Size(52, 38);
            label5.TabIndex = 12;
            label5.Click += label5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(282, 205);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1091, 248);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button4
            // 
            button4.Location = new Point(697, 172);
            button4.Name = "button4";
            button4.Size = new Size(193, 34);
            button4.TabIndex = 14;
            button4.Text = "search";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Green;
            label6.Location = new Point(1498, 96);
            label6.Name = "label6";
            label6.Size = new Size(137, 25);
            label6.TabIndex = 15;
            label6.Text = "search by genre";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Green;
            label9.Location = new Point(1690, 96);
            label9.Name = "label9";
            label9.Size = new Size(127, 25);
            label9.TabIndex = 16;
            label9.Text = "search by type";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.likepic;
            pictureBox1.Location = new Point(1379, 205);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // homepage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Web_capture_26_7_2023_63958_watchmovieshd_ru;
            ClientSize = new Size(1907, 839);
            Controls.Add(pictureBox1);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "homepage";
            Load += homepage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button2;
        private Button button3;
        private Label label4;
        private Label label5;
        private DataGridView dataGridView1;
        private Button button4;
        private Label label6;
        private Label label9;
        private PictureBox pictureBox1;
    }
}