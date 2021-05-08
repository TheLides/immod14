
namespace Lab14
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.meanNum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.varNum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.daysNumeric = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.varietyLabel = new System.Windows.Forms.Label();
            this.xiLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.averageError = new System.Windows.Forms.Label();
            this.varienceError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meanNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "freq";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Legend = "Legend1";
            series10.Name = "distr";
            this.chart1.Series.Add(series9);
            this.chart1.Series.Add(series10);
            this.chart1.Size = new System.Drawing.Size(574, 355);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(725, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mean";
            // 
            // meanNum
            // 
            this.meanNum.DecimalPlaces = 4;
            this.meanNum.Location = new System.Drawing.Point(795, 64);
            this.meanNum.Name = "meanNum";
            this.meanNum.Size = new System.Drawing.Size(185, 22);
            this.meanNum.TabIndex = 2;
            this.meanNum.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(700, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Variance";
            // 
            // varNum
            // 
            this.varNum.DecimalPlaces = 4;
            this.varNum.Location = new System.Drawing.Point(795, 156);
            this.varNum.Name = "varNum";
            this.varNum.Size = new System.Drawing.Size(185, 22);
            this.varNum.TabIndex = 4;
            this.varNum.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(592, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Number of experiments";
            // 
            // daysNumeric
            // 
            this.daysNumeric.Location = new System.Drawing.Point(795, 255);
            this.daysNumeric.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.daysNumeric.Name = "daysNumeric";
            this.daysNumeric.Size = new System.Drawing.Size(185, 22);
            this.daysNumeric.TabIndex = 6;
            this.daysNumeric.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(795, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 53);
            this.button1.TabIndex = 7;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(47, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Average:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(47, 450);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Variance:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(47, 494);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Xi squared:";
            // 
            // averageLabel
            // 
            this.averageLabel.AutoSize = true;
            this.averageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.averageLabel.Location = new System.Drawing.Point(150, 408);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(18, 20);
            this.averageLabel.TabIndex = 11;
            this.averageLabel.Text = "0";
            // 
            // varietyLabel
            // 
            this.varietyLabel.AutoSize = true;
            this.varietyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.varietyLabel.Location = new System.Drawing.Point(150, 450);
            this.varietyLabel.Name = "varietyLabel";
            this.varietyLabel.Size = new System.Drawing.Size(18, 20);
            this.varietyLabel.TabIndex = 12;
            this.varietyLabel.Text = "0";
            // 
            // xiLabel
            // 
            this.xiLabel.AutoSize = true;
            this.xiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xiLabel.Location = new System.Drawing.Point(150, 494);
            this.xiLabel.Name = "xiLabel";
            this.xiLabel.Size = new System.Drawing.Size(18, 20);
            this.xiLabel.TabIndex = 13;
            this.xiLabel.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(318, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Error (%):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(318, 450);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Error (%):";
            // 
            // averageError
            // 
            this.averageError.AutoSize = true;
            this.averageError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.averageError.Location = new System.Drawing.Point(418, 408);
            this.averageError.Name = "averageError";
            this.averageError.Size = new System.Drawing.Size(18, 20);
            this.averageError.TabIndex = 16;
            this.averageError.Text = "0";
            // 
            // varienceError
            // 
            this.varienceError.AutoSize = true;
            this.varienceError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.varienceError.Location = new System.Drawing.Point(418, 450);
            this.varienceError.Name = "varienceError";
            this.varienceError.Size = new System.Drawing.Size(18, 20);
            this.varienceError.TabIndex = 17;
            this.varienceError.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 556);
            this.Controls.Add(this.varienceError);
            this.Controls.Add(this.averageError);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.xiLabel);
            this.Controls.Add(this.varietyLabel);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.daysNumeric);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.varNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.meanNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meanNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown meanNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown varNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown daysNumeric;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label varietyLabel;
        private System.Windows.Forms.Label xiLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label averageError;
        private System.Windows.Forms.Label varienceError;
    }
}

