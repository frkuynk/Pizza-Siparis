namespace pizza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            listBox1 = new ListBox();
            label7 = new Label();
            label8 = new Label();
            listBox2 = new ListBox();
            label9 = new Label();
            listBox3 = new ListBox();
            label10 = new Label();
            listBox4 = new ListBox();
            label11 = new Label();
            listBox5 = new ListBox();
            label12 = new Label();
            listBox6 = new ListBox();
            groupBox2 = new GroupBox();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(417, 9);
            label1.Name = "label1";
            label1.Size = new Size(120, 29);
            label1.TabIndex = 0;
            label1.Text = "Pizza Arş";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label2.Location = new Point(34, 103);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(116, 24);
            label2.TabIndex = 1;
            label2.Text = "Adı Soyadı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label3.Location = new Point(34, 163);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 24);
            label3.TabIndex = 2;
            label3.Text = "Telefon:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 14F);
            textBox1.Location = new Point(154, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(149, 29);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 14F);
            textBox2.Location = new Point(154, 163);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(149, 29);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Microsoft Sans Serif", 14F);
            textBox3.Location = new Point(154, 237);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(149, 89);
            textBox3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label4.Location = new Point(34, 237);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(71, 24);
            label4.TabIndex = 5;
            label4.Text = "Adres:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label5.Location = new Point(34, 425);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(77, 24);
            label5.TabIndex = 7;
            label5.Text = "İçecek:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label6.Location = new Point(34, 369);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(100, 24);
            label6.TabIndex = 8;
            label6.Text = "PizzaBoy:";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Microsoft Sans Serif", 14F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Küçük", "Orta", "Büyük" });
            comboBox1.Location = new Point(154, 366);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(149, 32);
            comboBox1.TabIndex = 9;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Microsoft Sans Serif", 14F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Su", "Kola", "Gazoz", "Ayran ", "Limonata", "Şalgam" });
            comboBox2.Location = new Point(154, 417);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(149, 32);
            comboBox2.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(932, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Microsoft Sans Serif", 14F);
            checkBox1.Location = new Point(15, 29);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(82, 28);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "Sucuk";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Microsoft Sans Serif", 14F);
            checkBox2.Location = new Point(126, 63);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(73, 28);
            checkBox2.TabIndex = 13;
            checkBox2.Text = "Biber";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Microsoft Sans Serif", 14F);
            checkBox3.Location = new Point(15, 63);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(86, 28);
            checkBox3.TabIndex = 14;
            checkBox3.Text = "Mantar";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Microsoft Sans Serif", 14F);
            checkBox4.Location = new Point(214, 29);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(85, 28);
            checkBox4.TabIndex = 15;
            checkBox4.Text = "Zeytin ";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Font = new Font("Microsoft Sans Serif", 14F);
            checkBox5.Location = new Point(126, 29);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(76, 28);
            checkBox5.TabIndex = 16;
            checkBox5.Text = "Kaşar";
            checkBox5.UseVisualStyleBackColor = true;
            checkBox5.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Font = new Font("Microsoft Sans Serif", 14F);
            checkBox6.Location = new Point(214, 63);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(56, 28);
            checkBox6.TabIndex = 17;
            checkBox6.Text = "Acı";
            checkBox6.UseVisualStyleBackColor = true;
            checkBox6.CheckedChanged += checkBox6_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox5);
            groupBox1.Controls.Add(checkBox6);
            groupBox1.Location = new Point(372, 103);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(321, 118);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Malzeme";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            button1.Location = new Point(372, 270);
            button1.Name = "button1";
            button1.Size = new Size(149, 32);
            button1.TabIndex = 25;
            button1.Text = "Sipariş";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            button2.Location = new Point(544, 270);
            button2.Name = "button2";
            button2.Size = new Size(149, 32);
            button2.TabIndex = 26;
            button2.Text = "Temizle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Microsoft Sans Serif", 15F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(12, 550);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(138, 129);
            listBox1.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label7.Location = new Point(12, 523);
            label7.Margin = new Padding(1, 0, 1, 0);
            label7.Name = "label7";
            label7.Size = new Size(110, 24);
            label7.TabIndex = 28;
            label7.Text = "Adı Soyadı";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label8.Location = new Point(175, 523);
            label8.Margin = new Padding(1, 0, 1, 0);
            label8.Name = "label8";
            label8.Size = new Size(81, 24);
            label8.TabIndex = 30;
            label8.Text = "Telefon";
            // 
            // listBox2
            // 
            listBox2.Font = new Font("Microsoft Sans Serif", 15F);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Location = new Point(175, 550);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(143, 129);
            listBox2.TabIndex = 29;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label9.Location = new Point(534, 523);
            label9.Margin = new Padding(1, 0, 1, 0);
            label9.Name = "label9";
            label9.Size = new Size(94, 24);
            label9.TabIndex = 32;
            label9.Text = "PizzaBoy";
            // 
            // listBox3
            // 
            listBox3.Font = new Font("Microsoft Sans Serif", 15F);
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 25;
            listBox3.Location = new Point(351, 550);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(147, 129);
            listBox3.TabIndex = 31;
            listBox3.SelectedIndexChanged += listBox3_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label10.Location = new Point(717, 523);
            label10.Margin = new Padding(1, 0, 1, 0);
            label10.Name = "label10";
            label10.Size = new Size(71, 24);
            label10.TabIndex = 34;
            label10.Text = "İçecek";
            // 
            // listBox4
            // 
            listBox4.Font = new Font("Microsoft Sans Serif", 15F);
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 25;
            listBox4.Location = new Point(534, 550);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(146, 129);
            listBox4.TabIndex = 33;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label11.Location = new Point(351, 523);
            label11.Margin = new Padding(1, 0, 1, 0);
            label11.Name = "label11";
            label11.Size = new Size(65, 24);
            label11.TabIndex = 36;
            label11.Text = "Adres";
            // 
            // listBox5
            // 
            listBox5.Font = new Font("Microsoft Sans Serif", 15F);
            listBox5.FormattingEnabled = true;
            listBox5.ItemHeight = 25;
            listBox5.Location = new Point(717, 550);
            listBox5.Name = "listBox5";
            listBox5.Size = new Size(140, 129);
            listBox5.TabIndex = 35;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label12.Location = new Point(877, 523);
            label12.Margin = new Padding(1, 0, 1, 0);
            label12.Name = "label12";
            label12.Size = new Size(94, 24);
            label12.TabIndex = 38;
            label12.Text = "Malzeme";
            // 
            // listBox6
            // 
            listBox6.Font = new Font("Microsoft Sans Serif", 15F);
            listBox6.FormattingEnabled = true;
            listBox6.ItemHeight = 25;
            listBox6.Location = new Point(877, 550);
            listBox6.Name = "listBox6";
            listBox6.Size = new Size(249, 129);
            listBox6.TabIndex = 37;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Location = new Point(372, 331);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(321, 118);
            groupBox2.TabIndex = 39;
            groupBox2.TabStop = false;
            groupBox2.Text = "Malzeme";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(229, 84);
            label18.Name = "label18";
            label18.Size = new Size(0, 13);
            label18.TabIndex = 5;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(126, 84);
            label17.Name = "label17";
            label17.Size = new Size(0, 13);
            label17.TabIndex = 4;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(15, 84);
            label16.Name = "label16";
            label16.Size = new Size(0, 13);
            label16.TabIndex = 3;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(229, 35);
            label15.Name = "label15";
            label15.Size = new Size(0, 13);
            label15.TabIndex = 2;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(126, 35);
            label14.Name = "label14";
            label14.Size = new Size(0, 13);
            label14.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(15, 35);
            label13.Name = "label13";
            label13.Size = new Size(0, 13);
            label13.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(1138, 691);
            Controls.Add(groupBox2);
            Controls.Add(label12);
            Controls.Add(listBox6);
            Controls.Add(label11);
            Controls.Add(listBox5);
            Controls.Add(label10);
            Controls.Add(listBox4);
            Controls.Add(label9);
            Controls.Add(listBox3);
            Controls.Add(label8);
            Controls.Add(listBox2);
            Controls.Add(label7);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Pizza";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private GroupBox groupBox1;
        private Button button1;
        private Button button2;
        private ListBox listBox1;
        private Label label7;
        private Label label8;
        private ListBox listBox2;
        private Label label9;
        private ListBox listBox3;
        private Label label10;
        private ListBox listBox4;
        private Label label11;
        private ListBox listBox5;
        private Label label12;
        private ListBox listBox6;
        private GroupBox groupBox2;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
    }
}
