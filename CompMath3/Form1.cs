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
        public delegate double CurFun(double x);
        public CurFun CurrentFunction;

        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //MaximizeBox = false;
            Chart.Visible = false;

            Fxtb.ReadOnly = true;
            Xnum.Minimum = -1000;
            Xnum.DecimalPlaces = 3;


            CurrentFunction = Math.Sin;
            Func.Items.Add("Sin(x)");
            Func.Items.Add("Sqrt(x)");
            Func.Items.Add("x^2");
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

            Fx.Text = Func.SelectedItem.ToString();

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
                x += ((double)Step.Value * (double)Steps.Value) / 1000)
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
                FirstNode.Minimum = -1000;

                Xnum.Minimum = -1000;
                CurrentFunction = Math.Sin;
            }
            if (Func.SelectedItem.ToString() == "Sqrt(x)")
            {
                FirstNode.Minimum = 0;

                Xnum.Minimum = 0;
                CurrentFunction = Math.Sqrt;
            }
            if (Func.SelectedItem.ToString() == "x^2")
            {
                FirstNode.Minimum = -1000;

                Xnum.Minimum = -1000;
                CurrentFunction = x => x * x;
            }

            Fx.Text = Func.SelectedItem.ToString();

            //MessageBox.Show(CurrentFunction(5).ToString());
        }
        private void Interpolate_Click(object sender, EventArgs e)
        {
            BuildCharts();
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

        private void Xnum_ValueChanged(object sender, EventArgs e)
        {
            Fxtb.Text = CurrentFunction((double)Xnum.Value).ToString();
        }
    }

}
