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
            this.textBoxLc = new System.Windows.Forms.TextBox();
            this.labelLc = new System.Windows.Forms.Label();
            this.textBoxL = new System.Windows.Forms.TextBox();
            this.labelL = new System.Windows.Forms.Label();
            this.labelalpha = new System.Windows.Forms.Label();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.alphaValue = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonGraph = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelModel.Location = new System.Drawing.Point(29, 27);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(84, 25);
            this.labelModel.TabIndex = 0;
            this.labelModel.Text = "Модель";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(32, 61);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(348, 295);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // labelGeometry
            // 
            this.labelGeometry.AutoSize = true;
            this.labelGeometry.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelGeometry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGeometry.Location = new System.Drawing.Point(433, 27);
            this.labelGeometry.Name = "labelGeometry";
            this.labelGeometry.Size = new System.Drawing.Size(327, 25);
            this.labelGeometry.TabIndex = 2;
            this.labelGeometry.Text = "Геометрические характеристики";
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelR.Location = new System.Drawing.Point(433, 90);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(47, 25);
            this.labelR.TabIndex = 3;
            this.labelR.Text = "R = ";
            // 
            // textBoxR
            // 
            this.textBoxR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxR.Location = new System.Drawing.Point(487, 87);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(241, 30);
            this.textBoxR.TabIndex = 4;
            this.textBoxR.Text = "0,4";
            // 
            // textBoxRn
            // 
            this.textBoxRn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRn.Location = new System.Drawing.Point(487, 115);
            this.textBoxRn.Name = "textBoxRn";
            this.textBoxRn.Size = new System.Drawing.Size(241, 30);
            this.textBoxRn.TabIndex = 6;
            this.textBoxRn.Text = "0,3";
            // 
            // labelRn
            // 
            this.labelRn.AutoSize = true;
            this.labelRn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelRn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRn.Location = new System.Drawing.Point(433, 118);
            this.labelRn.Name = "labelRn";
            this.labelRn.Size = new System.Drawing.Size(51, 25);
            this.labelRn.TabIndex = 5;
            this.labelRn.Text = "rn = ";
            // 
            // textBoxTetha
            // 
            this.textBoxTetha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTetha.Location = new System.Drawing.Point(487, 143);
            this.textBoxTetha.Name = "textBoxTetha";
            this.textBoxTetha.Size = new System.Drawing.Size(241, 30);
            this.textBoxTetha.TabIndex = 8;
            this.textBoxTetha.Text = "45";
            // 
            // labelTetha
            // 
            this.labelTetha.AutoSize = true;
            this.labelTetha.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTetha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTetha.Location = new System.Drawing.Point(433, 146);
            this.labelTetha.Name = "labelTetha";
            this.labelTetha.Size = new System.Drawing.Size(45, 25);
            this.labelTetha.TabIndex = 7;
            this.labelTetha.Text = "θ = ";
            // 
            // textBoxLc
            // 
            this.textBoxLc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLc.Location = new System.Drawing.Point(487, 171);
            this.textBoxLc.Name = "textBoxLc";
            this.textBoxLc.Size = new System.Drawing.Size(241, 30);
            this.textBoxLc.TabIndex = 10;
            this.textBoxLc.Text = "0,3";
            // 
            // labelLc
            // 
            this.labelLc.AutoSize = true;
            this.labelLc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelLc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLc.Location = new System.Drawing.Point(433, 174);
            this.labelLc.Name = "labelLc";
            this.labelLc.Size = new System.Drawing.Size(55, 25);
            this.labelLc.TabIndex = 9;
            this.labelLc.Text = "Lc = ";
            // 
            // textBoxL
            // 
            this.textBoxL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxL.Location = new System.Drawing.Point(487, 199);
            this.textBoxL.Name = "textBoxL";
            this.textBoxL.Size = new System.Drawing.Size(241, 30);
            this.textBoxL.TabIndex = 12;
            this.textBoxL.Text = "0,35";
            // 
            // labelL
            // 
            this.labelL.AutoSize = true;
            this.labelL.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelL.Location = new System.Drawing.Point(433, 202);
            this.labelL.Name = "labelL";
            this.labelL.Size = new System.Drawing.Size(45, 25);
            this.labelL.TabIndex = 11;
            this.labelL.Text = "L = ";
            // 
            // labelalpha
            // 
            this.labelalpha.AutoSize = true;
            this.labelalpha.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelalpha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelalpha.Location = new System.Drawing.Point(406, 253);
            this.labelalpha.Name = "labelalpha";
            this.labelalpha.Size = new System.Drawing.Size(82, 25);
            this.labelalpha.TabIndex = 13;
            this.labelalpha.Text = "alpha = ";
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(487, 253);
            this.trackBar.Maximum = 180;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(221, 56);
            this.trackBar.TabIndex = 14;
            this.trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // alphaValue
            // 
            this.alphaValue.AutoSize = true;
            this.alphaValue.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.alphaValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alphaValue.Location = new System.Drawing.Point(714, 253);
            this.alphaValue.Name = "alphaValue";
            this.alphaValue.Size = new System.Drawing.Size(31, 25);
            this.alphaValue.TabIndex = 15;
            this.alphaValue.Text = "0°";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(32, 415);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(766, 300);
            this.chart1.TabIndex = 16;
            this.chart1.Text = "chart1";
            title1.Name = "TitleCy";
            title1.Text = "Зависимость Cy от угла атаки alpha";
            this.chart1.Titles.Add(title1);
            // 
            // buttonGraph
            // 
            this.buttonGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGraph.Location = new System.Drawing.Point(438, 295);
            this.buttonGraph.Name = "buttonGraph";
            this.buttonGraph.Size = new System.Drawing.Size(322, 60);
            this.buttonGraph.TabIndex = 17;
            this.buttonGraph.Text = "Построить графики";
            this.buttonGraph.UseVisualStyleBackColor = true;
            this.buttonGraph.Click += new System.EventHandler(this.buttonGraph_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 758);
            this.Controls.Add(this.buttonGraph);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.alphaValue);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.labelalpha);
            this.Controls.Add(this.textBoxL);
            this.Controls.Add(this.labelL);
            this.Controls.Add(this.textBoxLc);
            this.Controls.Add(this.labelLc);
            this.Controls.Add(this.textBoxTetha);
            this.Controls.Add(this.labelTetha);
            this.Controls.Add(this.textBoxRn);
            this.Controls.Add(this.labelRn);
            this.Controls.Add(this.textBoxR);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.labelGeometry);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.labelModel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расчет аэродинамических характеристик летательного аппарата";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
        private System.Windows.Forms.TextBox textBoxLc;
        private System.Windows.Forms.Label labelLc;
        private System.Windows.Forms.TextBox textBoxL;
        private System.Windows.Forms.Label labelL;
        private System.Windows.Forms.Label labelalpha;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label alphaValue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonGraph;
    }
}

