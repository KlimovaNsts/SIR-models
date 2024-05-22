namespace SIR_модель
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartSIR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_size = new System.Windows.Forms.TextBox();
            this.textBox_step = new System.Windows.Forms.TextBox();
            this.textBox_gamma = new System.Windows.Forms.TextBox();
            this.textBox_beta = new System.Windows.Forms.TextBox();
            this.textBox_noi = new System.Windows.Forms.TextBox();
            this.textBox_tnop = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartSIR)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartSIR
            // 
            chartArea4.Name = "ChartArea1";
            this.chartSIR.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            legend4.Title = "SIR";
            legend4.TitleSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.GradientLine;
            this.chartSIR.Legends.Add(legend4);
            this.chartSIR.Location = new System.Drawing.Point(12, 12);
            this.chartSIR.Name = "chartSIR";
            series10.BorderWidth = 3;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Color = System.Drawing.Color.Blue;
            series10.Legend = "Legend1";
            series10.LegendText = "SUSCEPTIBLE";
            series10.Name = "Series1";
            series11.BorderWidth = 3;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series11.Color = System.Drawing.Color.Red;
            series11.Legend = "Legend1";
            series11.LegendText = "INFECTED";
            series11.Name = "Series2";
            series12.BorderWidth = 3;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series12.Color = System.Drawing.Color.Lime;
            series12.Legend = "Legend1";
            series12.LegendText = "RESISTANT";
            series12.Name = "Series3";
            this.chartSIR.Series.Add(series10);
            this.chartSIR.Series.Add(series11);
            this.chartSIR.Series.Add(series12);
            this.chartSIR.Size = new System.Drawing.Size(847, 426);
            this.chartSIR.TabIndex = 0;
            this.chartSIR.Text = "chart1";
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title4.Name = "Title1";
            title4.Text = "ГРАФИКИ";
            this.chartSIR.Titles.Add(title4);
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button.Location = new System.Drawing.Point(875, 261);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(241, 56);
            this.button.TabIndex = 1;
            this.button.Text = "ПОСТРОИТЬ";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(875, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 56);
            this.button1.TabIndex = 2;
            this.button1.Text = "ОЧИСТИТЬ ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(875, 385);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(241, 56);
            this.button2.TabIndex = 3;
            this.button2.Text = "ВЫХОД";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_size);
            this.groupBox1.Controls.Add(this.textBox_step);
            this.groupBox1.Controls.Add(this.textBox_gamma);
            this.groupBox1.Controls.Add(this.textBox_beta);
            this.groupBox1.Controls.Add(this.textBox_noi);
            this.groupBox1.Controls.Add(this.textBox_tnop);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(875, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 243);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox_size
            // 
            this.textBox_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_size.Location = new System.Drawing.Point(152, 201);
            this.textBox_size.Name = "textBox_size";
            this.textBox_size.Size = new System.Drawing.Size(393, 30);
            this.textBox_size.TabIndex = 11;
            // 
            // textBox_step
            // 
            this.textBox_step.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_step.Location = new System.Drawing.Point(256, 164);
            this.textBox_step.Name = "textBox_step";
            this.textBox_step.Size = new System.Drawing.Size(289, 30);
            this.textBox_step.TabIndex = 10;
            // 
            // textBox_gamma
            // 
            this.textBox_gamma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_gamma.Location = new System.Drawing.Point(441, 129);
            this.textBox_gamma.Name = "textBox_gamma";
            this.textBox_gamma.Size = new System.Drawing.Size(104, 30);
            this.textBox_gamma.TabIndex = 9;
            // 
            // textBox_beta
            // 
            this.textBox_beta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_beta.Location = new System.Drawing.Point(441, 93);
            this.textBox_beta.Name = "textBox_beta";
            this.textBox_beta.Size = new System.Drawing.Size(104, 30);
            this.textBox_beta.TabIndex = 8;
            // 
            // textBox_noi
            // 
            this.textBox_noi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_noi.Location = new System.Drawing.Point(372, 57);
            this.textBox_noi.Name = "textBox_noi";
            this.textBox_noi.Size = new System.Drawing.Size(173, 30);
            this.textBox_noi.TabIndex = 7;
            // 
            // textBox_tnop
            // 
            this.textBox_tnop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_tnop.Location = new System.Drawing.Point(232, 21);
            this.textBox_tnop.Name = "textBox_tnop";
            this.textBox_tnop.Size = new System.Drawing.Size(313, 30);
            this.textBox_tnop.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Масштаб =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(5, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Временной шаг (дни) =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(5, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(404, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Коэффициент выздоровления (gamma) =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(393, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Коэффициент инфекционности (beta) =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Начальное число инфекционных =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Общее население =";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 448);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button);
            this.Controls.Add(this.chartSIR);
            this.Name = "Form1";
            this.Text = "Графики SIR-модели";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartSIR)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartSIR;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_size;
        private System.Windows.Forms.TextBox textBox_step;
        private System.Windows.Forms.TextBox textBox_gamma;
        private System.Windows.Forms.TextBox textBox_beta;
        private System.Windows.Forms.TextBox textBox_noi;
        private System.Windows.Forms.TextBox textBox_tnop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

