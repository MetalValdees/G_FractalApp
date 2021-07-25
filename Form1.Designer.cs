
namespace G_FractalApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Point1X = new System.Windows.Forms.TextBox();
            this.Point1Y = new System.Windows.Forms.TextBox();
            this.Point2X = new System.Windows.Forms.TextBox();
            this.Point3X = new System.Windows.Forms.TextBox();
            this.Point2Y = new System.Windows.Forms.TextBox();
            this.Point3Y = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Point3 = new System.Windows.Forms.RadioButton();
            this.Point2 = new System.Windows.Forms.RadioButton();
            this.Point1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxSteps = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Point4 = new System.Windows.Forms.RadioButton();
            this.Point4X = new System.Windows.Forms.TextBox();
            this.Point4Y = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(304, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(501, 501);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Точка 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Точка 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Точка 3";
            // 
            // Point1X
            // 
            this.Point1X.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Point1X.Location = new System.Drawing.Point(107, 51);
            this.Point1X.MaxLength = 3;
            this.Point1X.Name = "Point1X";
            this.Point1X.Size = new System.Drawing.Size(60, 29);
            this.Point1X.TabIndex = 4;
            this.Point1X.Text = "0";
            this.Point1X.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Point1X_KeyPress);
            this.Point1X.Leave += new System.EventHandler(this.Point1X_Leave);
            // 
            // Point1Y
            // 
            this.Point1Y.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Point1Y.Location = new System.Drawing.Point(173, 51);
            this.Point1Y.MaxLength = 3;
            this.Point1Y.Name = "Point1Y";
            this.Point1Y.Size = new System.Drawing.Size(60, 29);
            this.Point1Y.TabIndex = 5;
            this.Point1Y.Text = "0";
            this.Point1Y.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Point1Y_KeyPress);
            this.Point1Y.Leave += new System.EventHandler(this.Point1Y_Leave);
            // 
            // Point2X
            // 
            this.Point2X.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Point2X.Location = new System.Drawing.Point(107, 91);
            this.Point2X.MaxLength = 3;
            this.Point2X.Name = "Point2X";
            this.Point2X.Size = new System.Drawing.Size(60, 29);
            this.Point2X.TabIndex = 6;
            this.Point2X.Text = "0";
            this.Point2X.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Point2X_KeyPress);
            this.Point2X.Leave += new System.EventHandler(this.Point2X_Leave);
            // 
            // Point3X
            // 
            this.Point3X.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Point3X.Location = new System.Drawing.Point(107, 131);
            this.Point3X.MaxLength = 3;
            this.Point3X.Name = "Point3X";
            this.Point3X.Size = new System.Drawing.Size(60, 29);
            this.Point3X.TabIndex = 7;
            this.Point3X.Text = "0";
            this.Point3X.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Point3X_KeyPress);
            this.Point3X.Leave += new System.EventHandler(this.Point3X_Leave);
            // 
            // Point2Y
            // 
            this.Point2Y.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Point2Y.Location = new System.Drawing.Point(173, 91);
            this.Point2Y.MaxLength = 3;
            this.Point2Y.Name = "Point2Y";
            this.Point2Y.Size = new System.Drawing.Size(60, 29);
            this.Point2Y.TabIndex = 8;
            this.Point2Y.Text = "0";
            this.Point2Y.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Point2Y_KeyPress);
            this.Point2Y.Leave += new System.EventHandler(this.Point2Y_Leave);
            // 
            // Point3Y
            // 
            this.Point3Y.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Point3Y.Location = new System.Drawing.Point(173, 131);
            this.Point3Y.MaxLength = 3;
            this.Point3Y.Name = "Point3Y";
            this.Point3Y.Size = new System.Drawing.Size(60, 29);
            this.Point3Y.TabIndex = 9;
            this.Point3Y.Text = "0";
            this.Point3Y.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Point3Y_KeyPress);
            this.Point3Y.Leave += new System.EventHandler(this.Point3Y_Leave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Point4);
            this.panel1.Controls.Add(this.Point3);
            this.panel1.Controls.Add(this.Point2);
            this.panel1.Controls.Add(this.Point1);
            this.panel1.Location = new System.Drawing.Point(240, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(39, 174);
            this.panel1.TabIndex = 10;
            // 
            // Point3
            // 
            this.Point3.AutoSize = true;
            this.Point3.Location = new System.Drawing.Point(13, 88);
            this.Point3.Name = "Point3";
            this.Point3.Size = new System.Drawing.Size(14, 13);
            this.Point3.TabIndex = 13;
            this.Point3.UseVisualStyleBackColor = true;
            // 
            // Point2
            // 
            this.Point2.AutoSize = true;
            this.Point2.Location = new System.Drawing.Point(13, 48);
            this.Point2.Name = "Point2";
            this.Point2.Size = new System.Drawing.Size(14, 13);
            this.Point2.TabIndex = 12;
            this.Point2.UseVisualStyleBackColor = true;
            // 
            // Point1
            // 
            this.Point1.AutoSize = true;
            this.Point1.Checked = true;
            this.Point1.Location = new System.Drawing.Point(13, 8);
            this.Point1.Name = "Point1";
            this.Point1.Size = new System.Drawing.Size(14, 13);
            this.Point1.TabIndex = 11;
            this.Point1.TabStop = true;
            this.Point1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(125, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(189, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(285, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 14);
            this.label6.TabIndex = 13;
            this.label6.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(273, 509);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 14);
            this.label7.TabIndex = 14;
            this.label7.Text = "500";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(779, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 14);
            this.label8.TabIndex = 15;
            this.label8.Text = "500";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(301, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 14);
            this.label9.TabIndex = 16;
            this.label9.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(35, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 22);
            this.label10.TabIndex = 17;
            this.label10.Text = "Шагов";
            // 
            // textBoxSteps
            // 
            this.textBoxSteps.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSteps.Location = new System.Drawing.Point(19, 259);
            this.textBoxSteps.MaxLength = 6;
            this.textBoxSteps.Name = "textBoxSteps";
            this.textBoxSteps.Size = new System.Drawing.Size(101, 29);
            this.textBoxSteps.TabIndex = 18;
            this.textBoxSteps.Text = "999999";
            this.textBoxSteps.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSteps_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(65, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 35);
            this.button1.TabIndex = 19;
            this.button1.Text = "Пуск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(140, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 22);
            this.label11.TabIndex = 22;
            this.label11.Text = "Задержка";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(144, 259);
            this.textBox1.MaxLength = 4;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(101, 29);
            this.textBox1.TabIndex = 23;
            this.textBox1.Text = "0";
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(247, 266);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 22);
            this.label12.TabIndex = 24;
            this.label12.Text = "мс";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(65, 348);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(168, 35);
            this.button4.TabIndex = 25;
            this.button4.Text = "Очистка";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(528, 526);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 21);
            this.label13.TabIndex = 26;
            this.label13.Text = "0 x 0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.label14.Location = new System.Drawing.Point(50, 163);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(162, 22);
            this.label14.TabIndex = 27;
            this.label14.Text = "Начальная точка";
            // 
            // Point4
            // 
            this.Point4.AutoSize = true;
            this.Point4.Location = new System.Drawing.Point(13, 153);
            this.Point4.Name = "Point4";
            this.Point4.Size = new System.Drawing.Size(14, 13);
            this.Point4.TabIndex = 14;
            this.Point4.UseVisualStyleBackColor = true;
            // 
            // Point4X
            // 
            this.Point4X.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Point4X.Location = new System.Drawing.Point(107, 196);
            this.Point4X.MaxLength = 3;
            this.Point4X.Name = "Point4X";
            this.Point4X.Size = new System.Drawing.Size(60, 29);
            this.Point4X.TabIndex = 28;
            this.Point4X.Text = "0";
            this.Point4X.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Point4X_KeyPress);
            this.Point4X.Leave += new System.EventHandler(this.Point4X_Leave);
            // 
            // Point4Y
            // 
            this.Point4Y.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Point4Y.Location = new System.Drawing.Point(172, 196);
            this.Point4Y.MaxLength = 3;
            this.Point4Y.Name = "Point4Y";
            this.Point4Y.Size = new System.Drawing.Size(60, 29);
            this.Point4Y.TabIndex = 29;
            this.Point4Y.Text = "0";
            this.Point4Y.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Point4Y_KeyPress);
            this.Point4Y.Leave += new System.EventHandler(this.Point4Y_Leave);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(552, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 22);
            this.label15.TabIndex = 30;
            this.label15.Text = "X";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(275, 244);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 22);
            this.label16.TabIndex = 31;
            this.label16.Text = "Y";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 552);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Point4Y);
            this.Controls.Add(this.Point4X);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxSteps);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Point3Y);
            this.Controls.Add(this.Point2Y);
            this.Controls.Add(this.Point3X);
            this.Controls.Add(this.Point2X);
            this.Controls.Add(this.Point1Y);
            this.Controls.Add(this.Point1X);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Point1X;
        private System.Windows.Forms.TextBox Point1Y;
        private System.Windows.Forms.TextBox Point2X;
        private System.Windows.Forms.TextBox Point3X;
        private System.Windows.Forms.TextBox Point2Y;
        private System.Windows.Forms.TextBox Point3Y;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton Point3;
        private System.Windows.Forms.RadioButton Point2;
        private System.Windows.Forms.RadioButton Point1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxSteps;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton Point4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Point4X;
        private System.Windows.Forms.TextBox Point4Y;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}

