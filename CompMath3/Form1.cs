using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CompMath3
{
    public partial class Form1 : Form
    {
        public delegate double CurFun (double x);
        public CurFun CurrentFunction;
        
        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //MaximizeBox = false;
            Chart.Visible = false;


            CurrentFunction  = Math.Sin;
            Func.Items.Add("Sin(x)");
            Func.Items.Add("Sqrt(x)");
            Func.Items.Add("x^2");
            Func.Items.Add("Tg(x)");
            Func.ReadOnly = true;
            FirstNode.Minimum = -1000;
            FirstNode.DecimalPlaces = 4;

            Func.SelectedIndex = 0;
            Step.DecimalPlaces = 4;
            Step.Increment = 0.1M;
            Step.Minimum = 0.1M;

            Steps.Value = 20;
            Steps.Minimum = 1;
            Steps.Maximum = 10000;
            


            Steps.KeyPress += new KeyPressEventHandler(Key_down);
            Step.KeyPress += new KeyPressEventHandler(Key_down);
            FirstNode.KeyPress += new KeyPressEventHandler(Key_down);

        }
        private void Key_down(object sender, KeyPressEventArgs e)
        {
            if ((char)e.KeyChar == (Char)Keys.Enter)
            {
                BuildCharts();
            }
        }

        private void BuildCharts()
        {
            Chart.Visible = true;
            ChartArea ca = new ChartArea("Two charts");
            try
            {
                Chart.Series.Clear();
                Chart.ChartAreas.Clear();
            }
            catch { }
            //ca.AxisX.Minimum = -20;
            //ca.AxisX.Maximum = 20;
            Chart.ChartAreas.Add(ca);

            Series fun = new Series(Func.SelectedItem.ToString())
            {
                ChartType = SeriesChartType.Line,
                ChartArea = "Two charts"
            };
            for (double x = (double)FirstNode.Value; x <= (double)FirstNode.Value + (double)Step.Value * (double)Steps.Value;
                x += ((double)Step.Value * (double)Steps.Value)/1000)
            {
                fun.Points.AddXY(x, CurrentFunction(x));
            }
            Chart.Series.Add(fun);
            BuildInterpolation();
        }
        
        public void BuildInterpolation()
        {
            Series interpolatedfun = new Series("Interpolated")
            {
                ChartType = SeriesChartType.FastLine,
                ChartArea = "Two charts",
                Color = Color.Red
                
            };
            Series Nodes = new Series("Nodes")
            {
                ChartArea = "Two charts",
                ChartType = SeriesChartType.Point,
                Color = Color.Purple
            };
            for (double x = (double)FirstNode.Value; x <= (double)FirstNode.Value + (double)Step.Value * (double)Steps.Value;
                x += (double)Step.Value)
            {
                double lagrangePol = 0;

                for (double i = (double)FirstNode.Value; i <= (double)FirstNode.Value + (double)Step.Value * (double)Steps.Value;
                    i += (double)Step.Value)
                {
                    double BasicPol = 1;
                    for (double j = (double)FirstNode.Value; j <= (double)FirstNode.Value + (double)Step.Value * (double)Steps.Value;
                         j += (double)Step.Value)
                    {
                        if (j != i)
                        {
                            BasicPol *= (x - j) / (i - j);
                        }
                    }
                    lagrangePol += BasicPol * CurrentFunction(i);
                }
                interpolatedfun.Points.AddXY(x, lagrangePol);
                Nodes.Points.AddXY(x, lagrangePol);
            }
            Chart.Series.Add(interpolatedfun);
            Chart.Series.Add(Nodes);
        }

        private void Func_SelectedItemChanged(object sender, EventArgs e)
        {
            if (Func.SelectedItem.ToString() == "Sin(x)")
            {
                CurrentFunction = Math.Sin;
            }
            if (Func.SelectedItem.ToString() == "Sqrt(x)")
            {
                CurrentFunction = Math.Sqrt;
            }
            if (Func.SelectedItem.ToString() == "x^2")
            {
                CurrentFunction = x => x*x;
            }
            if (Func.SelectedItem.ToString() == "Tg(x)")
            {
                CurrentFunction = Math.Tan;
            }
            
            //MessageBox.Show(CurrentFunction(5).ToString());
        }
        private void Interpolate_Click(object sender, EventArgs e)
        {
            BuildCharts();
            //Chart myChart = new Chart();
            ////кладем его на форму и растягиваем на все окно.
            //myChart.Parent = this;
            //myChart.Dock = DockStyle.Fill;
            ////добавляем в Chart область для рисования графиков, их может быть
            ////много, поэтому даем ей имя.
            //myChart.ChartAreas.Add(new ChartArea("Math functions"));
            ////Создаем и настраиваем набор точек для рисования графика, в том
            ////не забыв указать имя области на которой хотим отобразить этот
            ////набор точек.
            //Series mySeriesOfPoint = new Series("Sinus");
            //mySeriesOfPoint.ChartType = SeriesChartType.Line;
            //mySeriesOfPoint.ChartArea = "Math functions";
            //for (double x = -Math.PI; x <= Math.PI; x += Math.PI / 1000)
            //{
            //    mySeriesOfPoint.Points.AddXY(x, Math.Sin(x));
            //}
            ////Добавляем созданный набор точек в Chart
            //myChart.Series.Add(mySeriesOfPoint);

            //this.Controls.Add(myChart);
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
    }

}
