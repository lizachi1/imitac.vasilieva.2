namespace WindowsFormsApp2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btPredict = new System.Windows.Forms.Button();
            this.NumUsd = new System.Windows.Forms.NumericUpDown();
            this.NumEuro = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUsd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumEuro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btPredict);
            this.panel1.Controls.Add(this.NumUsd);
            this.panel1.Controls.Add(this.NumEuro);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 153);
            this.panel1.TabIndex = 0;
            // 
            // btPredict
            // 
            this.btPredict.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btPredict.Font = new System.Drawing.Font("Circe", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btPredict.Location = new System.Drawing.Point(547, 46);
            this.btPredict.Name = "btPredict";
            this.btPredict.Size = new System.Drawing.Size(148, 43);
            this.btPredict.TabIndex = 4;
            this.btPredict.Text = "Старт/Стоп";
            this.btPredict.UseVisualStyleBackColor = false;
            this.btPredict.Click += new System.EventHandler(this.btPredict_Click);
            // 
            // NumUsd
            // 
            this.NumUsd.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.NumUsd.DecimalPlaces = 2;
            this.NumUsd.Location = new System.Drawing.Point(248, 69);
            this.NumUsd.Name = "NumUsd";
            this.NumUsd.Size = new System.Drawing.Size(97, 20);
            this.NumUsd.TabIndex = 3;
            this.NumUsd.Value = new decimal(new int[] {
            7728,
            0,
            0,
            131072});
            // 
            // NumEuro
            // 
            this.NumEuro.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.NumEuro.DecimalPlaces = 2;
            this.NumEuro.Location = new System.Drawing.Point(48, 69);
            this.NumEuro.Name = "NumEuro";
            this.NumEuro.Size = new System.Drawing.Size(97, 20);
            this.NumEuro.TabIndex = 2;
            this.NumEuro.Value = new decimal(new int[] {
            8333,
            0,
            0,
            131072});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Circe Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(242, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Курс Доллара";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Circe Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(42, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Курс Евро";
            // 
            // chart1
            // 
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Minimum = 60D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(78, 219);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.BorderColor = System.Drawing.Color.White;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.DodgerBlue;
            series1.IsValueShownAsLabel = true;
            series1.LabelFormat = "C";
            series1.Legend = "Legend1";
            series1.Name = "Курс Евро";
            series1.ShadowColor = System.Drawing.Color.Silver;
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsValueShownAsLabel = true;
            series2.LabelFormat = "C";
            series2.Legend = "Legend1";
            series2.Name = "Курс Доллара";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(617, 410);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.яку_восстановлено_копnия;
            this.ClientSize = new System.Drawing.Size(771, 688);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUsd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumEuro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btPredict;
        private System.Windows.Forms.NumericUpDown NumUsd;
        private System.Windows.Forms.NumericUpDown NumEuro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
    }
}

