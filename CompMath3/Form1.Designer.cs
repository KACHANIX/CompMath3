namespace CompMath3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.FirstNode = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Step = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Steps = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.Func = new System.Windows.Forms.DomainUpDown();
            this.Interpolate = new System.Windows.Forms.Button();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Xnum = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.Fx = new System.Windows.Forms.Label();
            this.Fxtb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.FirstNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Step)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Steps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Xnum)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstNode
            // 
            this.FirstNode.Location = new System.Drawing.Point(28, 118);
            this.FirstNode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FirstNode.Name = "FirstNode";
            this.FirstNode.Size = new System.Drawing.Size(93, 22);
            this.FirstNode.TabIndex = 0;
            this.FirstNode.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Первый узел";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Шаг";
            // 
            // Step
            // 
            this.Step.Location = new System.Drawing.Point(28, 213);
            this.Step.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Step.Name = "Step";
            this.Step.Size = new System.Drawing.Size(93, 22);
            this.Step.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 262);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Количество узлов";
            // 
            // Steps
            // 
            this.Steps.Location = new System.Drawing.Point(28, 302);
            this.Steps.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Steps.Name = "Steps";
            this.Steps.Size = new System.Drawing.Size(65, 22);
            this.Steps.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Функция";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Func
            // 
            this.Func.Location = new System.Drawing.Point(28, 44);
            this.Func.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Func.Name = "Func";
            this.Func.Size = new System.Drawing.Size(67, 22);
            this.Func.TabIndex = 7;
            this.Func.Text = "Sin(x)";
            this.Func.SelectedItemChanged += new System.EventHandler(this.Func_SelectedItemChanged);
            // 
            // Interpolate
            // 
            this.Interpolate.Location = new System.Drawing.Point(28, 359);
            this.Interpolate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Interpolate.Name = "Interpolate";
            this.Interpolate.Size = new System.Drawing.Size(140, 28);
            this.Interpolate.TabIndex = 8;
            this.Interpolate.Text = "Интерполировать";
            this.Interpolate.UseVisualStyleBackColor = true;
            this.Interpolate.Click += new System.EventHandler(this.Interpolate_Click);
            // 
            // Chart
            // 
            this.Chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Chart.Legends.Add(legend2);
            this.Chart.Location = new System.Drawing.Point(176, -1);
            this.Chart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Chart.Name = "Chart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.Chart.Series.Add(series2);
            this.Chart.Size = new System.Drawing.Size(1260, 681);
            this.Chart.TabIndex = 9;
            this.Chart.Text = "chart1";
            // 
            // Xnum
            // 
            this.Xnum.Location = new System.Drawing.Point(3, 658);
            this.Xnum.Name = "Xnum";
            this.Xnum.Size = new System.Drawing.Size(75, 22);
            this.Xnum.TabIndex = 10;
            this.Xnum.ValueChanged += new System.EventHandler(this.Xnum_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 624);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "X";
            // 
            // Fx
            // 
            this.Fx.AutoSize = true;
            this.Fx.Location = new System.Drawing.Point(119, 624);
            this.Fx.Name = "Fx";
            this.Fx.Size = new System.Drawing.Size(32, 17);
            this.Fx.TabIndex = 12;
            this.Fx.Text = "F(x)";
            // 
            // Fxtb
            // 
            this.Fxtb.Location = new System.Drawing.Point(101, 657);
            this.Fxtb.Name = "Fxtb";
            this.Fxtb.Size = new System.Drawing.Size(67, 22);
            this.Fxtb.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1449, 697);
            this.Controls.Add(this.Fxtb);
            this.Controls.Add(this.Fx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Xnum);
            this.Controls.Add(this.Chart);
            this.Controls.Add(this.Interpolate);
            this.Controls.Add(this.Func);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Steps);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Step);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstNode);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.FirstNode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Step)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Steps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Xnum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Interpolate;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        public System.Windows.Forms.NumericUpDown FirstNode;
        public System.Windows.Forms.NumericUpDown Step;
        public System.Windows.Forms.NumericUpDown Steps;
        public System.Windows.Forms.DomainUpDown Func;
        private System.Windows.Forms.NumericUpDown Xnum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Fx;
        private System.Windows.Forms.TextBox Fxtb;
    }
}

