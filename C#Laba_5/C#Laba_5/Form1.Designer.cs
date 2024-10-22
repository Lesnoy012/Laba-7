namespace C_Laba_5
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InputKey = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ButtonFind = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.IndexForNeoptimBinarySearch = new System.Windows.Forms.TextBox();
            this.TimeForNeoptimBinarySearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.IndexForOptimDinarySearch = new System.Windows.Forms.TextBox();
            this.TimeForOptimBinarySearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.IndexForInterBinarySearch = new System.Windows.Forms.TextBox();
            this.TimeForInterBinarySearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.IndexForPosledBinarySearch = new System.Windows.Forms.TextBox();
            this.TimeForPosledBinatySearch = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.TimeForPosledNeupr = new System.Windows.Forms.TextBox();
            this.TimeForPosledUpr = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputKey)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-10, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 46);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(96, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Лабораторная работа №5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(21, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ключ";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // InputKey
            // 
            this.InputKey.Location = new System.Drawing.Point(83, 17);
            this.InputKey.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.InputKey.Name = "InputKey";
            this.InputKey.Size = new System.Drawing.Size(161, 20);
            this.InputKey.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ButtonFind);
            this.panel2.Controls.Add(this.InputKey);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(-10, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(431, 57);
            this.panel2.TabIndex = 2;
            // 
            // ButtonFind
            // 
            this.ButtonFind.Location = new System.Drawing.Point(258, 5);
            this.ButtonFind.Name = "ButtonFind";
            this.ButtonFind.Size = new System.Drawing.Size(152, 44);
            this.ButtonFind.TabIndex = 3;
            this.ButtonFind.Text = "Найти";
            this.ButtonFind.UseVisualStyleBackColor = true;
            this.ButtonFind.Click += new System.EventHandler(this.ButtonFindClick);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.IndexForNeoptimBinarySearch);
            this.panel3.Controls.Add(this.TimeForNeoptimBinarySearch);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(-6, 102);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(431, 111);
            this.panel3.TabIndex = 2;
            // 
            // IndexForNeoptimBinarySearch
            // 
            this.IndexForNeoptimBinarySearch.Location = new System.Drawing.Point(99, 82);
            this.IndexForNeoptimBinarySearch.Name = "IndexForNeoptimBinarySearch";
            this.IndexForNeoptimBinarySearch.ReadOnly = true;
            this.IndexForNeoptimBinarySearch.Size = new System.Drawing.Size(134, 20);
            this.IndexForNeoptimBinarySearch.TabIndex = 1;
            // 
            // TimeForNeoptimBinarySearch
            // 
            this.TimeForNeoptimBinarySearch.Location = new System.Drawing.Point(99, 43);
            this.TimeForNeoptimBinarySearch.Name = "TimeForNeoptimBinarySearch";
            this.TimeForNeoptimBinarySearch.ReadOnly = true;
            this.TimeForNeoptimBinarySearch.Size = new System.Drawing.Size(134, 20);
            this.TimeForNeoptimBinarySearch.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.Location = new System.Drawing.Point(17, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Индекс";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.Location = new System.Drawing.Point(17, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Время";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(57, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Неоптимальный бинарный поиск";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.IndexForOptimDinarySearch);
            this.panel4.Controls.Add(this.TimeForOptimBinarySearch);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(-2, 210);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(431, 111);
            this.panel4.TabIndex = 2;
            // 
            // IndexForOptimDinarySearch
            // 
            this.IndexForOptimDinarySearch.Location = new System.Drawing.Point(99, 82);
            this.IndexForOptimDinarySearch.Name = "IndexForOptimDinarySearch";
            this.IndexForOptimDinarySearch.ReadOnly = true;
            this.IndexForOptimDinarySearch.Size = new System.Drawing.Size(134, 20);
            this.IndexForOptimDinarySearch.TabIndex = 1;
            // 
            // TimeForOptimBinarySearch
            // 
            this.TimeForOptimBinarySearch.Location = new System.Drawing.Point(99, 43);
            this.TimeForOptimBinarySearch.Name = "TimeForOptimBinarySearch";
            this.TimeForOptimBinarySearch.ReadOnly = true;
            this.TimeForOptimBinarySearch.Size = new System.Drawing.Size(134, 20);
            this.TimeForOptimBinarySearch.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label6.Location = new System.Drawing.Point(17, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Индекс";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label7.Location = new System.Drawing.Point(17, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Время";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label8.Location = new System.Drawing.Point(57, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(287, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Оптимальный бинарный поиск";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.IndexForInterBinarySearch);
            this.panel5.Controls.Add(this.TimeForInterBinarySearch);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Location = new System.Drawing.Point(-2, 319);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(431, 111);
            this.panel5.TabIndex = 2;
            // 
            // IndexForInterBinarySearch
            // 
            this.IndexForInterBinarySearch.Location = new System.Drawing.Point(99, 82);
            this.IndexForInterBinarySearch.Name = "IndexForInterBinarySearch";
            this.IndexForInterBinarySearch.ReadOnly = true;
            this.IndexForInterBinarySearch.Size = new System.Drawing.Size(134, 20);
            this.IndexForInterBinarySearch.TabIndex = 1;
            // 
            // TimeForInterBinarySearch
            // 
            this.TimeForInterBinarySearch.Location = new System.Drawing.Point(99, 43);
            this.TimeForInterBinarySearch.Name = "TimeForInterBinarySearch";
            this.TimeForInterBinarySearch.ReadOnly = true;
            this.TimeForInterBinarySearch.Size = new System.Drawing.Size(134, 20);
            this.TimeForInterBinarySearch.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label9.Location = new System.Drawing.Point(17, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Индекс";
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label10.Location = new System.Drawing.Point(17, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "Время";
            this.label10.Click += new System.EventHandler(this.label1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label11.Location = new System.Drawing.Point(57, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(338, 24);
            this.label11.TabIndex = 0;
            this.label11.Text = "Интерполяционный бинарный поиск";
            this.label11.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.IndexForPosledBinarySearch);
            this.panel6.Controls.Add(this.TimeForPosledBinatySearch);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Location = new System.Drawing.Point(-2, 428);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(431, 111);
            this.panel6.TabIndex = 2;
            // 
            // IndexForPosledBinarySearch
            // 
            this.IndexForPosledBinarySearch.Location = new System.Drawing.Point(99, 82);
            this.IndexForPosledBinarySearch.Name = "IndexForPosledBinarySearch";
            this.IndexForPosledBinarySearch.ReadOnly = true;
            this.IndexForPosledBinarySearch.Size = new System.Drawing.Size(134, 20);
            this.IndexForPosledBinarySearch.TabIndex = 1;
            // 
            // TimeForPosledBinatySearch
            // 
            this.TimeForPosledBinatySearch.Location = new System.Drawing.Point(99, 43);
            this.TimeForPosledBinatySearch.Name = "TimeForPosledBinatySearch";
            this.TimeForPosledBinatySearch.ReadOnly = true;
            this.TimeForPosledBinatySearch.Size = new System.Drawing.Size(134, 20);
            this.TimeForPosledBinatySearch.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label12.Location = new System.Drawing.Point(17, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 24);
            this.label12.TabIndex = 0;
            this.label12.Text = "Индекс";
            this.label12.Click += new System.EventHandler(this.label1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label13.Location = new System.Drawing.Point(17, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 24);
            this.label13.TabIndex = 0;
            this.label13.Text = "Время";
            this.label13.Click += new System.EventHandler(this.label1_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label14.Location = new System.Drawing.Point(53, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(351, 24);
            this.label14.TabIndex = 0;
            this.label14.Text = "\"Последовательный\" бинарный поиск";
            this.label14.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.TimeForPosledNeupr);
            this.panel7.Controls.Add(this.TimeForPosledUpr);
            this.panel7.Controls.Add(this.label15);
            this.panel7.Controls.Add(this.label16);
            this.panel7.Controls.Add(this.label17);
            this.panel7.Location = new System.Drawing.Point(-2, 537);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(431, 111);
            this.panel7.TabIndex = 2;
            // 
            // TimeForPosledNeupr
            // 
            this.TimeForPosledNeupr.Location = new System.Drawing.Point(99, 82);
            this.TimeForPosledNeupr.Name = "TimeForPosledNeupr";
            this.TimeForPosledNeupr.ReadOnly = true;
            this.TimeForPosledNeupr.Size = new System.Drawing.Size(134, 20);
            this.TimeForPosledNeupr.TabIndex = 1;
            // 
            // TimeForPosledUpr
            // 
            this.TimeForPosledUpr.Location = new System.Drawing.Point(99, 57);
            this.TimeForPosledUpr.Name = "TimeForPosledUpr";
            this.TimeForPosledUpr.ReadOnly = true;
            this.TimeForPosledUpr.Size = new System.Drawing.Size(134, 20);
            this.TimeForPosledUpr.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label15.Location = new System.Drawing.Point(17, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 24);
            this.label15.TabIndex = 0;
            this.label15.Text = "Индекс";
            this.label15.Click += new System.EventHandler(this.label1_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label16.Location = new System.Drawing.Point(17, 52);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 24);
            this.label16.TabIndex = 0;
            this.label16.Text = "Время";
            this.label16.Click += new System.EventHandler(this.label1_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label17.Location = new System.Drawing.Point(80, 4);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(249, 48);
            this.label17.TabIndex = 0;
            this.label17.Text = "Последовательный поиск \r\nв упорядоченном массиве";
            this.label17.Click += new System.EventHandler(this.label1_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Location = new System.Drawing.Point(125, 654);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(150, 26);
            this.ButtonExit.TabIndex = 3;
            this.ButtonExit.Text = "Выйти";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExitClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(413, 679);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Ipatov V.M. 23VP1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputKey)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown InputKey;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TimeForNeoptimBinarySearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IndexForNeoptimBinarySearch;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox IndexForOptimDinarySearch;
        private System.Windows.Forms.TextBox TimeForOptimBinarySearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox IndexForInterBinarySearch;
        private System.Windows.Forms.TextBox TimeForInterBinarySearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox IndexForPosledBinarySearch;
        private System.Windows.Forms.TextBox TimeForPosledBinatySearch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox TimeForPosledNeupr;
        private System.Windows.Forms.TextBox TimeForPosledUpr;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button ButtonFind;
        private System.Windows.Forms.Button ButtonExit;
    }
}

