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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelModel.Location = new System.Drawing.Point(29, 27);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(57, 16);
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
            this.labelGeometry.Location = new System.Drawing.Point(433, 27);
            this.labelGeometry.Name = "labelGeometry";
            this.labelGeometry.Size = new System.Drawing.Size(224, 16);
            this.labelGeometry.TabIndex = 2;
            this.labelGeometry.Text = "Геометрические характеристики";
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelR.Location = new System.Drawing.Point(433, 90);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(30, 16);
            this.labelR.TabIndex = 3;
            this.labelR.Text = "R = ";
            // 
            // textBoxR
            // 
            this.textBoxR.Location = new System.Drawing.Point(487, 87);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(241, 22);
            this.textBoxR.TabIndex = 4;
            // 
            // textBoxRn
            // 
            this.textBoxRn.Location = new System.Drawing.Point(487, 115);
            this.textBoxRn.Name = "textBoxRn";
            this.textBoxRn.Size = new System.Drawing.Size(241, 22);
            this.textBoxRn.TabIndex = 6;
            // 
            // labelRn
            // 
            this.labelRn.AutoSize = true;
            this.labelRn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelRn.Location = new System.Drawing.Point(433, 118);
            this.labelRn.Name = "labelRn";
            this.labelRn.Size = new System.Drawing.Size(31, 16);
            this.labelRn.TabIndex = 5;
            this.labelRn.Text = "rn = ";
            // 
            // textBoxTetha
            // 
            this.textBoxTetha.Location = new System.Drawing.Point(487, 143);
            this.textBoxTetha.Name = "textBoxTetha";
            this.textBoxTetha.Size = new System.Drawing.Size(241, 22);
            this.textBoxTetha.TabIndex = 8;
            // 
            // labelTetha
            // 
            this.labelTetha.AutoSize = true;
            this.labelTetha.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTetha.Location = new System.Drawing.Point(433, 146);
            this.labelTetha.Name = "labelTetha";
            this.labelTetha.Size = new System.Drawing.Size(27, 16);
            this.labelTetha.TabIndex = 7;
            this.labelTetha.Text = "θ = ";
            // 
            // textBoxLc
            // 
            this.textBoxLc.Location = new System.Drawing.Point(487, 171);
            this.textBoxLc.Name = "textBoxLc";
            this.textBoxLc.Size = new System.Drawing.Size(241, 22);
            this.textBoxLc.TabIndex = 10;
            // 
            // labelLc
            // 
            this.labelLc.AutoSize = true;
            this.labelLc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelLc.Location = new System.Drawing.Point(433, 174);
            this.labelLc.Name = "labelLc";
            this.labelLc.Size = new System.Drawing.Size(34, 16);
            this.labelLc.TabIndex = 9;
            this.labelLc.Text = "Lc = ";
            // 
            // textBoxL
            // 
            this.textBoxL.Location = new System.Drawing.Point(487, 199);
            this.textBoxL.Name = "textBoxL";
            this.textBoxL.Size = new System.Drawing.Size(241, 22);
            this.textBoxL.TabIndex = 12;
            // 
            // labelL
            // 
            this.labelL.AutoSize = true;
            this.labelL.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelL.Location = new System.Drawing.Point(433, 202);
            this.labelL.Name = "labelL";
            this.labelL.Size = new System.Drawing.Size(27, 16);
            this.labelL.TabIndex = 11;
            this.labelL.Text = "L = ";
            // 
            // labelalpha
            // 
            this.labelalpha.AutoSize = true;
            this.labelalpha.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelalpha.Location = new System.Drawing.Point(433, 253);
            this.labelalpha.Name = "labelalpha";
            this.labelalpha.Size = new System.Drawing.Size(54, 16);
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
            this.alphaValue.Location = new System.Drawing.Point(714, 253);
            this.alphaValue.Name = "alphaValue";
            this.alphaValue.Size = new System.Drawing.Size(18, 16);
            this.alphaValue.TabIndex = 15;
            this.alphaValue.Text = "0°";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 564);
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
            this.Text = "Расчет аэродинамических характеристик летательного аппарата";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
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
    }
}

