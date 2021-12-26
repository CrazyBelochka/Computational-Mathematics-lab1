namespace vchmat4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(11, 194);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(500, 331);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите количество аргументов:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox1.Location = new System.Drawing.Point(15, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(47, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Заполните таблицу:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(11, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "x:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(11, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "f (x):";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Ввести";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox2.Location = new System.Drawing.Point(67, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(50, 20);
            this.textBox2.TabIndex = 21;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox3.Location = new System.Drawing.Point(123, 93);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(50, 20);
            this.textBox3.TabIndex = 22;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox4.Location = new System.Drawing.Point(235, 93);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(50, 20);
            this.textBox4.TabIndex = 24;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox5.Location = new System.Drawing.Point(179, 93);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(50, 20);
            this.textBox5.TabIndex = 23;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox6.Location = new System.Drawing.Point(347, 92);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(50, 20);
            this.textBox6.TabIndex = 26;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox7.Location = new System.Drawing.Point(291, 92);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(50, 20);
            this.textBox7.TabIndex = 25;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox8.Location = new System.Drawing.Point(403, 93);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(50, 20);
            this.textBox8.TabIndex = 27;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox9.Location = new System.Drawing.Point(403, 114);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(50, 20);
            this.textBox9.TabIndex = 34;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox10.Location = new System.Drawing.Point(347, 113);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(50, 20);
            this.textBox10.TabIndex = 33;
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox11.Location = new System.Drawing.Point(291, 113);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(50, 20);
            this.textBox11.TabIndex = 32;
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox12.Location = new System.Drawing.Point(235, 114);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(50, 20);
            this.textBox12.TabIndex = 31;
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox13.Location = new System.Drawing.Point(179, 114);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(50, 20);
            this.textBox13.TabIndex = 30;
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox14.Location = new System.Drawing.Point(123, 114);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(50, 20);
            this.textBox14.TabIndex = 29;
            // 
            // textBox15
            // 
            this.textBox15.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox15.Location = new System.Drawing.Point(67, 114);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(50, 20);
            this.textBox15.TabIndex = 28;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 39);
            this.button2.TabIndex = 44;
            this.button2.Text = "Построить первую производную";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(133, 149);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 39);
            this.button3.TabIndex = 45;
            this.button3.Text = "Построить вторую производную";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(11, 531);
            this.textBox20.Multiline = true;
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(500, 87);
            this.textBox20.TabIndex = 46;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(255, 149);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 39);
            this.button4.TabIndex = 47;
            this.button4.Text = "Построить график";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(523, 621);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox20);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.Button button4;
    }
}

