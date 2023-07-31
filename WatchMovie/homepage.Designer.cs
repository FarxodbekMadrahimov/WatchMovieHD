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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            comboBox1 = new ComboBox();
            genreBindingSource = new BindingSource(components);
            comboBox2 = new ComboBox();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)genreBindingSource).BeginInit();
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
            // comboBox1
            // 
            comboBox1.BackColor = Color.SeaGreen;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1665, 85);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 7;
            comboBox1.TabStop = false;
            comboBox1.SelectedIndexChanged += comboBox1_load;
            // 
            // genreBindingSource
            // 
            genreBindingSource.DataSource = typeof(Core.Enum.genre);
            genreBindingSource.CurrentChanged += genreBindingSource_CurrentChanged;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.SeaGreen;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(1476, 85);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(159, 33);
            comboBox2.TabIndex = 8;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(1504, 124);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 9;
            button2.Text = "search";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(1695, 124);
            button3.Name = "button3";
            button3.Size = new Size(122, 34);
            button3.TabIndex = 10;
            button3.Text = "search";
            button3.UseVisualStyleBackColor = true;
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
            // homepage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Web_capture_26_7_2023_63958_watchmovieshd_ru;
            ClientSize = new Size(1907, 839);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "homepage";
            Load += homepage_Load;
            ((System.ComponentModel.ISupportInitialize)genreBindingSource).EndInit();
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
        private ComboBox comboBox1;
        private BindingSource genreBindingSource;
        private ComboBox comboBox2;
        private Button button2;
        private Button button3;
        private Label label4;
        private Label label5;
    }
}