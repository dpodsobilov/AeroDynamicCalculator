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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPageCyvDer = new System.Windows.Forms.TabPage();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьМодельToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьМодельToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.saveToCSVButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPageMzn.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelModel.Location = new System.Drawing.Point(29, 27);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(201, 25);
            this.labelModel.TabIndex = 0;
            this.labelModel.Text = "Спускаемая капсула";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(32, 62);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.labelGeometry.Size = new System.Drawing.Size(357, 25);
            this.labelGeometry.TabIndex = 2;
            this.labelGeometry.Text = "Геометрические характеристики СК\r\n";
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelR.Location = new System.Drawing.Point(452, 137);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(47, 25);
            this.labelR.TabIndex = 3;
            this.labelR.Text = "R = ";
            // 
            // textBoxR
            // 
            this.textBoxR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxR.Location = new System.Drawing.Point(507, 134);
            this.textBoxR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxR.MaxLength = 20;
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(241, 30);
            this.textBoxR.TabIndex = 4;
            this.textBoxR.Text = "0,4";
            // 
            // textBoxRn
            // 
            this.textBoxRn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRn.Location = new System.Drawing.Point(507, 171);
            this.textBoxRn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRn.MaxLength = 20;
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
            this.labelRn.Location = new System.Drawing.Point(452, 175);
            this.labelRn.Name = "labelRn";
            this.labelRn.Size = new System.Drawing.Size(51, 25);
            this.labelRn.TabIndex = 5;
            this.labelRn.Text = "rn = ";
            // 
            // textBoxTetha
            // 
            this.textBoxTetha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTetha.Location = new System.Drawing.Point(507, 208);
            this.textBoxTetha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTetha.MaxLength = 20;
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
            this.labelTetha.Location = new System.Drawing.Point(452, 212);
            this.labelTetha.Name = "labelTetha";
            this.labelTetha.Size = new System.Drawing.Size(45, 25);
            this.labelTetha.TabIndex = 7;
            this.labelTetha.Text = "θ = ";
            // 
            // buttonGraph
            // 
            this.buttonGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGraph.Location = new System.Drawing.Point(437, 295);
            this.buttonGraph.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGraph.Name = "buttonGraph";
            this.buttonGraph.Size = new System.Drawing.Size(323, 60);
            this.buttonGraph.TabIndex = 17;
            this.buttonGraph.Text = "Построить графики для АДХ";
            this.buttonGraph.UseVisualStyleBackColor = true;
            this.buttonGraph.Click += new System.EventHandler(this.buttonGraph_Click);
            // 
            // chart
            // 
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart.Name = "chart";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Name = "Series1";
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(900, 350);
            this.chart.TabIndex = 18;
            this.chart.Text = "chart1";
            title2.Name = "TitleM";
            title2.Text = "Зависимость mzn от угла атаки alpha";
            this.chart.Titles.Add(title2);
            this.chart.Visible = false;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageMzn);
            this.tabControl.Controls.Add(this.tabPageCy);
            this.tabControl.Controls.Add(this.tabPageCx);
            this.tabControl.Controls.Add(this.tabPageMzc);
            this.tabControl.Controls.Add(this.tabPageXd);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPageCyvDer);
            this.tabControl.Location = new System.Drawing.Point(843, 27);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(900, 382);
            this.tabControl.TabIndex = 26;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // tabPageMzn
            // 
            this.tabPageMzn.Controls.Add(this.chart);
            this.tabPageMzn.Location = new System.Drawing.Point(4, 25);
            this.tabPageMzn.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageMzn.Name = "tabPageMzn";
            this.tabPageMzn.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageMzn.Size = new System.Drawing.Size(892, 353);
            this.tabPageMzn.TabIndex = 0;
            this.tabPageMzn.Text = "Mzn";
            this.tabPageMzn.UseVisualStyleBackColor = true;
            // 
            // tabPageCy
            // 
            this.tabPageCy.Location = new System.Drawing.Point(4, 25);
            this.tabPageCy.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageCy.Name = "tabPageCy";
            this.tabPageCy.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageCy.Size = new System.Drawing.Size(892, 353);
            this.tabPageCy.TabIndex = 1;
            this.tabPageCy.Text = "Cy";
            this.tabPageCy.UseVisualStyleBackColor = true;
            // 
            // tabPageCx
            // 
            this.tabPageCx.Location = new System.Drawing.Point(4, 25);
            this.tabPageCx.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageCx.Name = "tabPageCx";
            this.tabPageCx.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageCx.Size = new System.Drawing.Size(892, 353);
            this.tabPageCx.TabIndex = 2;
            this.tabPageCx.Text = "Cx";
            this.tabPageCx.UseVisualStyleBackColor = true;
            // 
            // tabPageMzc
            // 
            this.tabPageMzc.Location = new System.Drawing.Point(4, 25);
            this.tabPageMzc.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageMzc.Name = "tabPageMzc";
            this.tabPageMzc.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageMzc.Size = new System.Drawing.Size(892, 353);
            this.tabPageMzc.TabIndex = 3;
            this.tabPageMzc.Text = "Mzc";
            this.tabPageMzc.UseVisualStyleBackColor = true;
            // 
            // tabPageXd
            // 
            this.tabPageXd.Location = new System.Drawing.Point(4, 25);
            this.tabPageXd.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageXd.Name = "tabPageXd";
            this.tabPageXd.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageXd.Size = new System.Drawing.Size(892, 353);
            this.tabPageXd.TabIndex = 4;
            this.tabPageXd.Text = "xD";
            this.tabPageXd.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(892, 353);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Cxv";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(892, 353);
            this.tabPage2.TabIndex = 6;
            this.tabPage2.Text = "Cyv";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPageCyvDer
            // 
            this.tabPageCyvDer.Location = new System.Drawing.Point(4, 25);
            this.tabPageCyvDer.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageCyvDer.Name = "tabPageCyvDer";
            this.tabPageCyvDer.Size = new System.Drawing.Size(892, 353);
            this.tabPageCyvDer.TabIndex = 7;
            this.tabPageCyvDer.Text = "Cyv\'(alpha)";
            this.tabPageCyvDer.UseVisualStyleBackColor = true;
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1761, 28);
            this.menuStrip.TabIndex = 27;
            this.menuStrip.Text = "menuStrip";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьМодельToolStripMenuItem,
            this.сохранитьМодельToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // загрузитьМодельToolStripMenuItem
            // 
            this.загрузитьМодельToolStripMenuItem.Name = "загрузитьМодельToolStripMenuItem";
            this.загрузитьМодельToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.загрузитьМодельToolStripMenuItem.Text = "Загрузить модель";
            this.загрузитьМодельToolStripMenuItem.Click += new System.EventHandler(this.loadModelClick);
            // 
            // сохранитьМодельToolStripMenuItem
            // 
            this.сохранитьМодельToolStripMenuItem.Name = "сохранитьМодельToolStripMenuItem";
            this.сохранитьМодельToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.сохранитьМодельToolStripMenuItem.Text = "Сохранить модель";
            this.сохранитьМодельToolStripMenuItem.Click += new System.EventHandler(this.saveModelClick);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = ".\\help\\help.html";
            // 
            // saveToCSVButton
            // 
            this.saveToCSVButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveToCSVButton.Location = new System.Drawing.Point(438, 368);
            this.saveToCSVButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveToCSVButton.Name = "saveToCSVButton";
            this.saveToCSVButton.Size = new System.Drawing.Size(322, 60);
            this.saveToCSVButton.TabIndex = 28;
            this.saveToCSVButton.Text = "Сохранить графики";
            this.saveToCSVButton.UseVisualStyleBackColor = true;
            this.saveToCSVButton.Visible = false;
            this.saveToCSVButton.Click += new System.EventHandler(this.saveToCSVButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1761, 439);
            this.Controls.Add(this.saveToCSVButton);
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
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расчет аэродинамических характеристик летательного аппарата";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPageMzn.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьМодельToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьМодельToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TabPage tabPageCyvDer;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Button saveToCSVButton;
    }
}

