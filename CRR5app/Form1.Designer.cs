namespace CRR5app
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            labelрHeader = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            textBox7 = new TextBox();
            label7 = new Label();
            textBox8 = new TextBox();
            label8 = new Label();
            textBox9 = new TextBox();
            label9 = new Label();
            textBox10 = new TextBox();
            label10 = new Label();
            textBox11 = new TextBox();
            label11 = new Label();
            textBox12 = new TextBox();
            label12 = new Label();
            textBox13 = new TextBox();
            label13 = new Label();
            textBox14 = new TextBox();
            label14 = new Label();
            textBox15 = new TextBox();
            label15 = new Label();
            button2 = new Button();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            label19 = new Label();
            label20 = new Label();
            textBoxOldComiss1 = new TextBox();
            textBoxNewComiss1 = new TextBox();
            toolTip1 = new ToolTip(components);
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(324, 565);
            label1.Name = "label1";
            label1.Size = new Size(153, 21);
            label1.TabIndex = 0;
            label1.Text = "Начальный столбец";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(324, 589);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "15";
            textBox1.Size = new Size(153, 23);
            textBox1.TabIndex = 1;
            textBox1.KeyPress += PassNumber;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(103, 603);
            button1.Name = "button1";
            button1.Size = new Size(209, 65);
            button1.TabIndex = 2;
            button1.Text = "Корректировать и сохранить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(324, 642);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(153, 23);
            textBox2.TabIndex = 4;
            textBox2.KeyPress += PassNumber;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(324, 618);
            label2.Name = "label2";
            label2.Size = new Size(145, 21);
            label2.TabIndex = 3;
            label2.Text = "Конечный столбец";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(180, 175);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(47, 23);
            textBox3.TabIndex = 6;
            textBox3.Text = "15";
            textBox3.KeyPress += PassNumber;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(169, 83);
            label3.Name = "label3";
            label3.Size = new Size(143, 64);
            label3.TabIndex = 5;
            label3.Text = "Комиссия за продажу по категории";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(341, 175);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(47, 23);
            textBox4.TabIndex = 8;
            textBox4.Text = "16";
            textBox4.KeyPress += PassNumber;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(321, 83);
            label4.Name = "label4";
            label4.Size = new Size(153, 69);
            label4.TabIndex = 7;
            label4.Text = "Новая комиссия за продажу по категории";
            // 
            // labelрHeader
            // 
            labelрHeader.AutoSize = true;
            labelрHeader.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelрHeader.Location = new Point(40, 9);
            labelрHeader.Name = "labelрHeader";
            labelрHeader.Size = new Size(429, 30);
            labelрHeader.TabIndex = 9;
            labelрHeader.Text = "Номера столбцов в алфовитной системе";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(30, 175);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(47, 23);
            textBox5.TabIndex = 11;
            textBox5.Text = "14";
            textBox5.KeyPress += PassNumber;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(21, 83);
            label5.Name = "label5";
            label5.Size = new Size(146, 73);
            label5.TabIndex = 10;
            label5.Text = "Цена продавца, руб. (с учетом скидки продавца)";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(29, 278);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(47, 23);
            textBox6.TabIndex = 13;
            textBox6.Text = "17";
            textBox6.KeyPress += PassNumber;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(24, 230);
            label6.Name = "label6";
            label6.Size = new Size(146, 45);
            label6.TabIndex = 12;
            label6.Text = "Цена реализации, руб.";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(179, 278);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(47, 23);
            textBox7.TabIndex = 15;
            textBox7.Text = "18";
            textBox7.KeyPress += PassNumber;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(168, 230);
            label7.Name = "label7";
            label7.Size = new Size(156, 45);
            label7.TabIndex = 14;
            label7.Text = "Количество продаж";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(340, 278);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(47, 23);
            textBox8.TabIndex = 17;
            textBox8.Text = "27";
            textBox8.KeyPress += PassNumber;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(324, 230);
            label8.Name = "label8";
            label8.Size = new Size(156, 45);
            label8.TabIndex = 16;
            label8.Text = "Новая итого к начислению, руб.";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(30, 385);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(47, 23);
            textBox9.TabIndex = 19;
            textBox9.Text = "23";
            textBox9.KeyPress += PassNumber;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(25, 315);
            label9.Name = "label9";
            label9.Size = new Size(146, 64);
            label9.TabIndex = 18;
            label9.Text = "Итого комиссия с учетом скидок и наценки, руб.";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(180, 385);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(47, 23);
            textBox10.TabIndex = 21;
            textBox10.Text = "25";
            textBox10.KeyPress += PassNumber;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(169, 315);
            label10.Name = "label10";
            label10.Size = new Size(146, 64);
            label10.TabIndex = 20;
            label10.Text = "Новая итого комиссия с учетом скидок и наценки, руб.";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(341, 385);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(47, 23);
            textBox11.TabIndex = 23;
            textBox11.Text = "21";
            textBox11.KeyPress += PassNumber;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(325, 315);
            label11.Name = "label11";
            label11.Size = new Size(146, 68);
            label11.TabIndex = 22;
            label11.Text = "Новая доплата за счет Ozon, руб.";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(26, 506);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(47, 23);
            textBox12.TabIndex = 25;
            textBox12.Text = "28";
            textBox12.KeyPress += PassNumber;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(23, 437);
            label12.Name = "label12";
            label12.Size = new Size(120, 64);
            label12.TabIndex = 24;
            label12.Text = "Цена реализации, руб. возврата";
            // 
            // textBox13
            // 
            textBox13.Location = new Point(176, 506);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(47, 23);
            textBox13.TabIndex = 27;
            textBox13.Text = "35";
            textBox13.KeyPress += PassNumber;
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(169, 437);
            label13.Name = "label13";
            label13.Size = new Size(146, 64);
            label13.TabIndex = 26;
            label13.Text = "Новая доплата за счет Ozon, руб. возврат";
            // 
            // textBox14
            // 
            textBox14.Location = new Point(337, 506);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(47, 23);
            textBox14.TabIndex = 29;
            textBox14.Text = "37";
            textBox14.KeyPress += PassNumber;
            // 
            // label14
            // 
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(321, 437);
            label14.Name = "label14";
            label14.Size = new Size(147, 66);
            label14.TabIndex = 28;
            label14.Text = "Новая итого комиссия с учетом скидок и наценки, руб.";
            // 
            // textBox15
            // 
            textBox15.Location = new Point(26, 564);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(47, 23);
            textBox15.TabIndex = 31;
            textBox15.Text = "39";
            textBox15.KeyPress += PassNumber;
            // 
            // label15
            // 
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(20, 532);
            label15.Name = "label15";
            label15.Size = new Size(194, 29);
            label15.TabIndex = 32;
            label15.Text = "Новая итого возвращено";
            // 
            // button2
            // 
            button2.Location = new Point(12, 612);
            button2.Name = "button2";
            button2.Size = new Size(65, 53);
            button2.TabIndex = 33;
            button2.Text = "Открыть отчёт";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(180, 58);
            label16.Name = "label16";
            label16.Size = new Size(110, 25);
            label16.TabIndex = 34;
            label16.Text = "Справочно";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(162, 205);
            label17.Name = "label17";
            label17.Size = new Size(125, 25);
            label17.TabIndex = 35;
            label17.Text = "Реализовано";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(127, 411);
            label18.Name = "label18";
            label18.Size = new Size(209, 25);
            label18.TabIndex = 36;
            label18.Text = "Возвращено клиентом";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(148, 259);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(160, 16);
            checkBox1.TabIndex = 37;
            checkBox1.Text = "В приоритете новый столбец";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.Location = new Point(289, 155);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(214, 16);
            checkBox2.TabIndex = 38;
            checkBox2.Text = "Корректировка только новых процентов";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            label19.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(103, 562);
            label19.Name = "label19";
            label19.Size = new Size(111, 24);
            label19.TabIndex = 40;
            label19.Text = "%Старая комиссия";
            // 
            // label20
            // 
            label20.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(209, 562);
            label20.Name = "label20";
            label20.Size = new Size(109, 24);
            label20.TabIndex = 41;
            label20.Text = "%Новая комиссия";
            // 
            // textBoxOldComiss1
            // 
            textBoxOldComiss1.Location = new Point(135, 577);
            textBoxOldComiss1.Name = "textBoxOldComiss1";
            textBoxOldComiss1.PlaceholderText = "0,08";
            textBoxOldComiss1.Size = new Size(47, 23);
            textBoxOldComiss1.TabIndex = 42;
            // 
            // textBoxNewComiss1
            // 
            textBoxNewComiss1.Location = new Point(240, 577);
            textBoxNewComiss1.Name = "textBoxNewComiss1";
            textBoxNewComiss1.PlaceholderText = "0,18";
            textBoxNewComiss1.Size = new Size(47, 23);
            textBoxNewComiss1.TabIndex = 43;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(460, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(14, 15);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(480, 141);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(14, 15);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 45;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(306, 252);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(14, 15);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 46;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 673);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxNewComiss1);
            Controls.Add(textBoxOldComiss1);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(button2);
            Controls.Add(textBox15);
            Controls.Add(label15);
            Controls.Add(textBox14);
            Controls.Add(label14);
            Controls.Add(textBox13);
            Controls.Add(label13);
            Controls.Add(textBox12);
            Controls.Add(label12);
            Controls.Add(textBox11);
            Controls.Add(label11);
            Controls.Add(textBox10);
            Controls.Add(label10);
            Controls.Add(textBox9);
            Controls.Add(label9);
            Controls.Add(textBox8);
            Controls.Add(label8);
            Controls.Add(textBox7);
            Controls.Add(label7);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(labelрHeader);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Корректировка отчёта о реализации";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private Label labelрHeader;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
        private TextBox textBox7;
        private Label label7;
        private TextBox textBox8;
        private Label label8;
        private TextBox textBox9;
        private Label label9;
        private TextBox textBox10;
        private Label label10;
        private TextBox textBox11;
        private Label label11;
        private TextBox textBox12;
        private Label label12;
        private TextBox textBox13;
        private Label label13;
        private TextBox textBox14;
        private Label label14;
        private TextBox textBox15;
        private Label label15;
        private Button button2;
        private Label label16;
        private Label label17;
        private Label label18;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label19;
        private Label label20;
        private TextBox textBoxOldComiss1;
        private TextBox textBoxNewComiss1;
        private ToolTip toolTip1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}