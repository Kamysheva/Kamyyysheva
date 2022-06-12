
namespace lab6
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.funcType = new System.Windows.Forms.ComboBox();
            this.bValue = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cValue = new System.Windows.Forms.NumericUpDown();
            this.xValue = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.aValue = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aValue)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX2.Interval = 5D;
            chartArea1.AxisX2.Maximum = 100D;
            chartArea1.AxisX2.Minimum = 100D;
            chartArea1.AxisY2.Interval = 5D;
            chartArea1.AxisY2.Maximum = 100D;
            chartArea1.AxisY2.Minimum = 100D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(21, 12);
            this.chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.Transparent;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.MarkerBorderColor = System.Drawing.Color.Transparent;
            series1.MarkerColor = System.Drawing.Color.DarkBlue;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(377, 281);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите функцию, график которой вы хотите построить\r\n";
            // 
            // funcType
            // 
            this.funcType.FormattingEnabled = true;
            this.funcType.Items.AddRange(new object[] {
            "y = x * a + b",
            "y = a * sin(x * b) + c",
            "y = a * cos(x * b + c)",
            "y = a * tg(x * b) + c",
            "y = a * ctg(x * b + c)",
            "y = b * x^a",
            "y = a^(x + b)",
            "y = ((sin(x) + a * x)/((x – (x)^(1/2)) + 1))^b/x"});
            this.funcType.Location = new System.Drawing.Point(20, 338);
            this.funcType.Name = "funcType";
            this.funcType.Size = new System.Drawing.Size(200, 21);
            this.funcType.TabIndex = 3;
            // 
            // bValue
            // 
            this.bValue.Location = new System.Drawing.Point(130, 370);
            this.bValue.Name = "bValue";
            this.bValue.Size = new System.Drawing.Size(52, 20);
            this.bValue.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "b =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "c =";
            // 
            // cValue
            // 
            this.cValue.Location = new System.Drawing.Point(215, 370);
            this.cValue.Name = "cValue";
            this.cValue.Size = new System.Drawing.Size(52, 20);
            this.cValue.TabIndex = 6;
            // 
            // xValue
            // 
            this.xValue.Enabled = false;
            this.xValue.Location = new System.Drawing.Point(248, 405);
            this.xValue.Name = "xValue";
            this.xValue.Size = new System.Drawing.Size(52, 20);
            this.xValue.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "a =";
            // 
            // aValue
            // 
            this.aValue.Location = new System.Drawing.Point(44, 370);
            this.aValue.Name = "aValue";
            this.aValue.Size = new System.Drawing.Size(52, 20);
            this.aValue.TabIndex = 10;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(21, 407);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(227, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Вычислить значение в данной точке, х=";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 478);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.aValue);
            this.Controls.Add(this.xValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bValue);
            this.Controls.Add(this.funcType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox funcType;
        private System.Windows.Forms.NumericUpDown bValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown cValue;
        private System.Windows.Forms.NumericUpDown xValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown aValue;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

