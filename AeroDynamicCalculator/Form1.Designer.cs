namespace AeroDynamicCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.labelModel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelGeometry = new System.Windows.Forms.Label();
            this.labelR = new System.Windows.Forms.Label();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.textBoxRn = new System.Windows.Forms.TextBox();
            this.labelRn = new System.Windows.Forms.Label();
            this.textBoxTetha = new System.Windows.Forms.TextBox();
            this.labelTetha = new System.Windows.Forms.Label();
            this.labelalpha = new System.Windows.Forms.Label();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.alphaValue = new System.Windows.Forms.Label();
            this.chartCy = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonGraph = new System.Windows.Forms.Button();
            this.chartM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCx = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelAlphaNow = new System.Windows.Forms.Label();
            this.labelCxValue = new System.Windows.Forms.Label();
            this.labelCyValue = new System.Windows.Forms.Label();
            this.labelMValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCx)).BeginInit();
            this.SuspendLayout();
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelModel.Location = new System.Drawing.Point(22, 22);
            this.labelModel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(70, 20);
            this.labelModel.TabIndex = 0;
            this.labelModel.Text = "Модель";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(24, 50);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(261, 240);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // labelGeometry
            // 
            this.labelGeometry.AutoSize = true;
            this.labelGeometry.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelGeometry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGeometry.Location = new System.Drawing.Point(325, 22);
            this.labelGeometry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGeometry.Name = "labelGeometry";
            this.labelGeometry.Size = new System.Drawing.Size(260, 20);
            this.labelGeometry.TabIndex = 2;
            this.labelGeometry.Text = "Геометрические характеристики";
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelR.Location = new System.Drawing.Point(325, 73);
            this.labelR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(38, 20);
            this.labelR.TabIndex = 3;
            this.labelR.Text = "R = ";
            // 
            // textBoxR
            // 
            this.textBoxR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxR.Location = new System.Drawing.Point(365, 71);
            this.textBoxR.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(182, 26);
            this.textBoxR.TabIndex = 4;
            this.textBoxR.Text = "0,4";
            // 
            // textBoxRn
            // 
            this.textBoxRn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRn.Location = new System.Drawing.Point(365, 101);
            this.textBoxRn.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRn.Name = "textBoxRn";
            this.textBoxRn.Size = new System.Drawing.Size(182, 26);
            this.textBoxRn.TabIndex = 6;
            this.textBoxRn.Text = "0,3";
            // 
            // labelRn
            // 
            this.labelRn.AutoSize = true;
            this.labelRn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelRn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRn.Location = new System.Drawing.Point(325, 104);
            this.labelRn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRn.Name = "labelRn";
            this.labelRn.Size = new System.Drawing.Size(40, 20);
            this.labelRn.TabIndex = 5;
            this.labelRn.Text = "rn = ";
            // 
            // textBoxTetha
            // 
            this.textBoxTetha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTetha.Location = new System.Drawing.Point(365, 131);
            this.textBoxTetha.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTetha.Name = "textBoxTetha";
            this.textBoxTetha.Size = new System.Drawing.Size(182, 26);
            this.textBoxTetha.TabIndex = 8;
            this.textBoxTetha.Text = "45";
            // 
            // labelTetha
            // 
            this.labelTetha.AutoSize = true;
            this.labelTetha.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTetha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTetha.Location = new System.Drawing.Point(325, 134);
            this.labelTetha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTetha.Name = "labelTetha";
            this.labelTetha.Size = new System.Drawing.Size(35, 20);
            this.labelTetha.TabIndex = 7;
            this.labelTetha.Text = "θ = ";
            // 
            // labelalpha
            // 
            this.labelalpha.AutoSize = true;
            this.labelalpha.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelalpha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelalpha.Location = new System.Drawing.Point(320, 191);
            this.labelalpha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelalpha.Name = "labelalpha";
            this.labelalpha.Size = new System.Drawing.Size(65, 20);
            this.labelalpha.TabIndex = 13;
            this.labelalpha.Text = "alpha = ";
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(381, 191);
            this.trackBar.Margin = new System.Windows.Forms.Padding(2);
            this.trackBar.Maximum = 90;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(166, 45);
            this.trackBar.TabIndex = 14;
            this.trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // alphaValue
            // 
            this.alphaValue.AutoSize = true;
            this.alphaValue.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.alphaValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alphaValue.Location = new System.Drawing.Point(552, 191);
            this.alphaValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.alphaValue.Name = "alphaValue";
            this.alphaValue.Size = new System.Drawing.Size(23, 20);
            this.alphaValue.TabIndex = 15;
            this.alphaValue.Text = "0°";
            // 
            // chartCy
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCy.ChartAreas.Add(chartArea1);
            this.chartCy.Location = new System.Drawing.Point(24, 337);
            this.chartCy.Margin = new System.Windows.Forms.Padding(2);
            this.chartCy.Name = "chartCy";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            this.chartCy.Series.Add(series1);
            this.chartCy.Size = new System.Drawing.Size(574, 244);
            this.chartCy.TabIndex = 16;
            this.chartCy.Text = "chart1";
            title1.Name = "TitleCy";
            title1.Text = "Зависимость Cy от угла атаки alpha";
            this.chartCy.Titles.Add(title1);
            // 
            // buttonGraph
            // 
            this.buttonGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGraph.Location = new System.Drawing.Point(328, 240);
            this.buttonGraph.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGraph.Name = "buttonGraph";
            this.buttonGraph.Size = new System.Drawing.Size(242, 49);
            this.buttonGraph.TabIndex = 17;
            this.buttonGraph.Text = "Построить графики";
            this.buttonGraph.UseVisualStyleBackColor = true;
            this.buttonGraph.Click += new System.EventHandler(this.buttonGraph_Click);
            // 
            // chartM
            // 
            chartArea2.Name = "ChartArea1";
            this.chartM.ChartAreas.Add(chartArea2);
            this.chartM.Location = new System.Drawing.Point(680, 50);
            this.chartM.Margin = new System.Windows.Forms.Padding(2);
            this.chartM.Name = "chartM";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Name = "Series1";
            this.chartM.Series.Add(series2);
            this.chartM.Size = new System.Drawing.Size(574, 244);
            this.chartM.TabIndex = 18;
            this.chartM.Text = "chart1";
            title2.Name = "TitleM";
            title2.Text = "Зависимость mzn от угла атаки alpha";
            this.chartM.Titles.Add(title2);
            // 
            // chartCx
            // 
            chartArea3.Name = "ChartArea1";
            this.chartCx.ChartAreas.Add(chartArea3);
            this.chartCx.Location = new System.Drawing.Point(680, 337);
            this.chartCx.Margin = new System.Windows.Forms.Padding(2);
            this.chartCx.Name = "chartCx";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Name = "Series1";
            this.chartCx.Series.Add(series3);
            this.chartCx.Size = new System.Drawing.Size(574, 244);
            this.chartCx.TabIndex = 19;
            this.chartCx.Text = "chart1";
            title3.Name = "TitleCx";
            title3.Text = "Зависимость Cx от угла атаки alpha";
            this.chartCx.Titles.Add(title3);
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelAlphaNow
            // 
            this.labelAlphaNow.AutoSize = true;
            this.labelAlphaNow.Location = new System.Drawing.Point(610, 151);
            this.labelAlphaNow.Name = "labelAlphaNow";
            this.labelAlphaNow.Size = new System.Drawing.Size(35, 13);
            this.labelAlphaNow.TabIndex = 20;
            this.labelAlphaNow.Text = "label1";
            // 
            // labelCxValue
            // 
            this.labelCxValue.AutoSize = true;
            this.labelCxValue.Location = new System.Drawing.Point(705, 587);
            this.labelCxValue.Name = "labelCxValue";
            this.labelCxValue.Size = new System.Drawing.Size(19, 13);
            this.labelCxValue.TabIndex = 21;
            this.labelCxValue.Text = "Cx";
            // 
            // labelCyValue
            // 
            this.labelCyValue.AutoSize = true;
            this.labelCyValue.Location = new System.Drawing.Point(73, 587);
            this.labelCyValue.Name = "labelCyValue";
            this.labelCyValue.Size = new System.Drawing.Size(19, 13);
            this.labelCyValue.TabIndex = 22;
            this.labelCyValue.Text = "Cy";
            // 
            // labelMValue
            // 
            this.labelMValue.AutoSize = true;
            this.labelMValue.Location = new System.Drawing.Point(705, 306);
            this.labelMValue.Name = "labelMValue";
            this.labelMValue.Size = new System.Drawing.Size(16, 13);
            this.labelMValue.TabIndex = 23;
            this.labelMValue.Text = "M";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 616);
            this.Controls.Add(this.labelMValue);
            this.Controls.Add(this.labelCyValue);
            this.Controls.Add(this.labelCxValue);
            this.Controls.Add(this.labelAlphaNow);
            this.Controls.Add(this.chartCx);
            this.Controls.Add(this.chartM);
            this.Controls.Add(this.buttonGraph);
            this.Controls.Add(this.chartCy);
            this.Controls.Add(this.alphaValue);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.labelalpha);
            this.Controls.Add(this.textBoxTetha);
            this.Controls.Add(this.labelTetha);
            this.Controls.Add(this.textBoxRn);
            this.Controls.Add(this.labelRn);
            this.Controls.Add(this.textBoxR);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.labelGeometry);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.labelModel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расчет аэродинамических характеристик летательного аппарата";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelGeometry;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.TextBox textBoxRn;
        private System.Windows.Forms.Label labelRn;
        private System.Windows.Forms.TextBox textBoxTetha;
        private System.Windows.Forms.Label labelTetha;
        private System.Windows.Forms.Label labelalpha;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label alphaValue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCy;
        private System.Windows.Forms.Button buttonGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCx;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelAlphaNow;
        private System.Windows.Forms.Label labelCxValue;
        private System.Windows.Forms.Label labelCyValue;
        private System.Windows.Forms.Label labelMValue;
    }
}

