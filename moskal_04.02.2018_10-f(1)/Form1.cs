using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace moskal_04._02._2018_10_f_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Show();
            chart2.Hide(); 
            double  x;
            //chart1.Series["x = c * y ^ (-3 / 4) *| ctg(b * y) |"].Points.Clear();
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox5.Text);

            for (double t = -100; t < 100; t++)
            {
                //x = Math.Cos(y * b);
                x = c * t * Math.Pow(t, (-3 / 4)) * Math.Abs(Math.Cos(b * t) / Math.Sin(b * t));
                if (!((t > 50) || (t < -50)))
                    this.chart1.Series["x=c*y^(-3/4)*|ctg(b*y)|"].Points.AddXY(t, x);
            }
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            chart2.Show();
            chart1.Hide();
            double y, x;
            //chart1.Series["x = c * y ^ (-3 / 4) *| ctg(b * y) |"].Points.Clear();
            double a = double.Parse(textBox4.Text);
            double b = double.Parse(textBox2.Text);
            double k = double.Parse(textBox1.Text);
            double d = double.Parse(textBox3.Text);


            for (double t = -100; t < 100; t++)
            {
                //x = Math.Cos(y * b);
                x = Math.Abs(Math.Pow(t, (1 / 3))) * Math.Pow((Math.Cos(b * t)), 2);
                y = a * Math.Sqrt(Math.Abs(d - t) * Math.Abs(t - k)) * Math.Sin(b * t);
                if (!((y > 50) || (y < -50)))
                    this.chart2.Series["x=|t^(1/3)|*(Cos(b*t))^2; y=a*(√|d-t|*|t-k|)*sin(b*t)"].Points.AddXY(x, y);
            }
        }
    }
}
