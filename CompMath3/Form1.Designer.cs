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
            ((System.ComponentModel.ISupportInitialize)(this.FirstNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Step)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Steps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstNode
            // 
            this.FirstNode.Location = new System.Drawing.Point(21, 96);
            this.FirstNode.Name = "FirstNode";
            this.FirstNode.Size = new System.Drawing.Size(70, 20);
            this.FirstNode.TabIndex = 0;
            this.FirstNode.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Первый узел";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Шаг";
            // 
            // Step
            // 
            this.Step.Location = new System.Drawing.Point(21, 173);
            this.Step.Name = "Step";
            this.Step.Size = new System.Drawing.Size(70, 20);
            this.Step.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Количество узлов";
            // 
            // Steps
            // 
            this.Steps.Location = new System.Drawing.Point(21, 245);
            this.Steps.Name = "Steps";
            this.Steps.Size = new System.Drawing.Size(49, 20);
            this.Steps.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Функция";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Func
            // 
            this.Func.Location = new System.Drawing.Point(21, 36);
            this.Func.Name = "Func";
            this.Func.Size = new System.Drawing.Size(50, 20);
            this.Func.TabIndex = 7;
            this.Func.Text = "Sin(x)";
            this.Func.SelectedItemChanged += new System.EventHandler(this.Func_SelectedItemChanged);
            // 
            // Interpolate
            // 
            this.Interpolate.Location = new System.Drawing.Point(21, 292);
            this.Interpolate.Name = "Interpolate";
            this.Interpolate.Size = new System.Drawing.Size(105, 23);
            this.Interpolate.TabIndex = 8;
            this.Interpolate.Text = "Интерполировать";
            this.Interpolate.UseVisualStyleBackColor = true;
            this.Interpolate.Click += new System.EventHandler(this.Interpolate_Click);
            // 
            // Chart
            // 
            chartArea2.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Chart.Legends.Add(legend2);
            this.Chart.Location = new System.Drawing.Point(132, -1);
            this.Chart.Name = "Chart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.Chart.Series.Add(series2);
            this.Chart.Size = new System.Drawing.Size(1281, 810);
            this.Chart.TabIndex = 9;
            this.Chart.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 810);
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
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.FirstNode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Step)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Steps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
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
    }
}

