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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.labelModel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelGeometry = new System.Windows.Forms.Label();
            this.labelR = new System.Windows.Forms.Label();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.textBoxRn = new System.Windows.Forms.TextBox();
            this.labelRn = new System.Windows.Forms.Label();
            this.textBoxTetha = new System.Windows.Forms.TextBox();
            this.labelTetha = new System.Windows.Forms.Label();
            this.buttonGraph = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageMzn = new System.Windows.Forms.TabPage();
            this.tabPageCy = new System.Windows.Forms.TabPage();
            this.tabPageCx = new System.Windows.Forms.TabPage();
            this.tabPageMzc = new System.Windows.Forms.TabPage();
            this.tabPageXd = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPageMzn.SuspendLayout();
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
            this.labelR.Location = new System.Drawing.Point(339, 111);
            this.labelR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(38, 20);
            this.labelR.TabIndex = 3;
            this.labelR.Text = "R = ";
            // 
            // textBoxR
            // 
            this.textBoxR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxR.Location = new System.Drawing.Point(380, 109);
            this.textBoxR.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxR.MaxLength = 20;
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(182, 26);
            this.textBoxR.TabIndex = 4;
            this.textBoxR.Text = "0,4";
            // 
            // textBoxRn
            // 
            this.textBoxRn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRn.Location = new System.Drawing.Point(380, 139);
            this.textBoxRn.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRn.MaxLength = 20;
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
            this.labelRn.Location = new System.Drawing.Point(339, 142);
            this.labelRn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRn.Name = "labelRn";
            this.labelRn.Size = new System.Drawing.Size(40, 20);
            this.labelRn.TabIndex = 5;
            this.labelRn.Text = "rn = ";
            // 
            // textBoxTetha
            // 
            this.textBoxTetha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTetha.Location = new System.Drawing.Point(380, 169);
            this.textBoxTetha.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTetha.MaxLength = 20;
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
            this.labelTetha.Location = new System.Drawing.Point(339, 172);
            this.labelTetha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTetha.Name = "labelTetha";
            this.labelTetha.Size = new System.Drawing.Size(35, 20);
            this.labelTetha.TabIndex = 7;
            this.labelTetha.Text = "θ = ";
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
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Margin = new System.Windows.Forms.Padding(2);
            this.chart.Name = "chart";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(675, 284);
            this.chart.TabIndex = 18;
            this.chart.Text = "chart1";
            title1.Name = "TitleM";
            title1.Text = "Зависимость mzn от угла атаки alpha";
            this.chart.Titles.Add(title1);
            this.chart.Visible = false;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageMzn);
            this.tabControl.Controls.Add(this.tabPageCy);
            this.tabControl.Controls.Add(this.tabPageCx);
            this.tabControl.Controls.Add(this.tabPageMzc);
            this.tabControl.Controls.Add(this.tabPageXd);
            this.tabControl.Location = new System.Drawing.Point(632, 22);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(675, 310);
            this.tabControl.TabIndex = 26;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // tabPageMzn
            // 
            this.tabPageMzn.Controls.Add(this.chart);
            this.tabPageMzn.Location = new System.Drawing.Point(4, 22);
            this.tabPageMzn.Name = "tabPageMzn";
            this.tabPageMzn.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMzn.Size = new System.Drawing.Size(667, 284);
            this.tabPageMzn.TabIndex = 0;
            this.tabPageMzn.Text = "Mzn";
            this.tabPageMzn.UseVisualStyleBackColor = true;
            // 
            // tabPageCy
            // 
            this.tabPageCy.Location = new System.Drawing.Point(4, 22);
            this.tabPageCy.Name = "tabPageCy";
            this.tabPageCy.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCy.Size = new System.Drawing.Size(667, 284);
            this.tabPageCy.TabIndex = 1;
            this.tabPageCy.Text = "Cy";
            this.tabPageCy.UseVisualStyleBackColor = true;
            // 
            // tabPageCx
            // 
            this.tabPageCx.Location = new System.Drawing.Point(4, 22);
            this.tabPageCx.Name = "tabPageCx";
            this.tabPageCx.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCx.Size = new System.Drawing.Size(667, 284);
            this.tabPageCx.TabIndex = 2;
            this.tabPageCx.Text = "Cx";
            this.tabPageCx.UseVisualStyleBackColor = true;
            // 
            // tabPageMzc
            // 
            this.tabPageMzc.Location = new System.Drawing.Point(4, 22);
            this.tabPageMzc.Name = "tabPageMzc";
            this.tabPageMzc.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMzc.Size = new System.Drawing.Size(667, 284);
            this.tabPageMzc.TabIndex = 3;
            this.tabPageMzc.Text = "Mzc";
            this.tabPageMzc.UseVisualStyleBackColor = true;
            // 
            // tabPageXd
            // 
            this.tabPageXd.Location = new System.Drawing.Point(4, 22);
            this.tabPageXd.Name = "tabPageXd";
            this.tabPageXd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageXd.Size = new System.Drawing.Size(667, 284);
            this.tabPageXd.TabIndex = 4;
            this.tabPageXd.Text = "xD";
            this.tabPageXd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1321, 357);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.buttonGraph);
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
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPageMzn.ResumeLayout(false);
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
        private System.Windows.Forms.Button buttonGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageMzn;
        private System.Windows.Forms.TabPage tabPageCy;
        private System.Windows.Forms.TabPage tabPageCx;
        private System.Windows.Forms.TabPage tabPageMzc;
        private System.Windows.Forms.TabPage tabPageXd;
    }
}

