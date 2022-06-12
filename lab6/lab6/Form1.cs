using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //y = x * a + b                                         0
            //y = a * sin(x * b) + c                                1
            //y = a * cos(x * b + c)                                2
            //y = a * tg(x * b) + c                                 3
            //y = a * ctg(x * b + c)                                4
            //y = b * xa                                            5
            //y = a(x + b)                                          6
            //y = ((sin(x) + a * x) / ((x – (x)1 / 2) +1))b / x     7

            double step = 1, start = -10, end = 10, x, y, a, b, c;
            this.chart1.Series[0].Points.Clear();

            x = start;
            a = Convert.ToInt32(aValue.Value);
            b = Convert.ToInt32(bValue.Value);
            c = Convert.ToInt32(bValue.Value); 

            //done 1 2
            if (funcType.SelectedIndex == 0)
            {
                if(checkBox1.Checked)
                {
                    x = Convert.ToInt32(xValue.Value);
                    y = x * a + b;
                    this.chart1.Series[0].Points.AddXY(x, y);
                }
                else { 
                    while(x<=end)
                    {
                        y = x *a + b;
                        this.chart1.Series[0].Points.AddXY(x, y);
                        x += step;
                    }
                }
            }
            //done 1 2
            if (funcType.SelectedIndex == 1)
            {
                if (checkBox1.Checked)
                {
                    x = Convert.ToInt32(xValue.Value);
                    y = a * Math.Sin(x * b) + c;
                    this.chart1.Series[0].Points.AddXY(x, y);
                }
                else
                {
                    while (x <= end)
                    {
                        y = a * Math.Sin(x * b) + c;
                        this.chart1.Series[0].Points.AddXY(x, y);
                        x += step;
                    }
                }
               
            }
            //done 1 2
            if (funcType.SelectedIndex == 2)
            {
                if (checkBox1.Checked)
                {
                    x = Convert.ToInt32(xValue.Value);
                    y = a * Math.Cos(x * b + c);
                    this.chart1.Series[0].Points.AddXY(x, y);
                }
                else
                {
                    while (x <= end)
                    {
                        y = a * Math.Cos(x * b + c);
                        this.chart1.Series[0].Points.AddXY(x, y);
                        x += step;
                    }
                }
            }
            //done 1
            if (funcType.SelectedIndex == 3)
            {
                if (checkBox1.Checked)
                {
                    x = Convert.ToInt32(xValue.Value);
                    y = a * Math.Tan(x * b) + c;
                    this.chart1.Series[0].Points.AddXY(x, y);
                }
                else
                {
                    while (x <= end)
                    {
                        y = a * Math.Tan(x * b) + c;
                        this.chart1.Series[0].Points.AddXY(x, y);
                        x += step;
                    }
                }
            }
            //done 1 2
            if (funcType.SelectedIndex == 4)
            {
                start = -0.5;
                end = 1;
                x = start; 
                this.chart1.ChartAreas[0].AxisY.Minimum = -5;
                this.chart1.ChartAreas[0].AxisY.Maximum = 5;
                this.chart1.ChartAreas[0].AxisY.Interval = 1;
                this.chart1.ChartAreas[0].AxisX.Minimum = -5;
                this.chart1.ChartAreas[0].AxisX.Maximum = 5;
                this.chart1.ChartAreas[0].AxisY.Interval = 1;
                if (checkBox1.Checked)
                {
                    x = Convert.ToInt32(xValue.Value);
                    y = a * (1/Math.Tan(x * b + c));
                    this.chart1.Series[0].Points.AddXY(x, y);
                }
                else
                {
                    while (x <= end)
                    {
                        y = a * (1/Math.Tan(x * b + c));
                        this.chart1.Series[0].Points.AddXY(x, y);
                        x += step;
                    }
                }
            }
            //done 1 2
            if (funcType.SelectedIndex == 5)
            {
                if (checkBox1.Checked)
                {
                    x = Convert.ToInt32(xValue.Value);
                    y = b * Math.Pow(x, a);
                    this.chart1.Series[0].Points.AddXY(x, y);
                }
                else
                {
                    while (x <= end)
                    {
                        y = b * Math.Pow(x, a);
                        this.chart1.Series[0].Points.AddXY(x, y);
                        x += step;
                    }
                }
            }
            //done 1 2
            if (funcType.SelectedIndex == 6)
            {
                if (checkBox1.Checked)
                {
                    x = Convert.ToInt32(xValue.Value);
                    y = Math.Pow(a, (x + b));
                    this.chart1.Series[0].Points.AddXY(x, y);
                }
                else
                {
                    while (x <= end)
                    {
                        y = Math.Pow(a, (x + b));
                        this.chart1.Series[0].Points.AddXY(x, y);
                        x += step;
                    }
                }
            }
            //done 1
            if (funcType.SelectedIndex == 7)
            {
                if (checkBox1.Checked)
                {
                    x = Convert.ToInt32(xValue.Value);
                    y = Math.Pow(((Math.Sin(x) + a * x) / (x - Math.Pow(x, 1 / 2) + 1)), b / x);
                    this.chart1.Series[0].Points.AddXY(x, y);
                }
                else
                {
                    while (x <= end)
                    {
                        y = Math.Pow(((Math.Sin(x) + a * x) / (x - Math.Pow(x, 1 / 2) + 1)), b / x);
                        this.chart1.Series[0].Points.AddXY(x, y);
                        x += step;
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            aValue.Value = 1;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) 
            { 
                xValue.Enabled = true;
            }
            else
            {
                xValue.Enabled = false;
            }
        }
    }
}
