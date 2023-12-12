
namespace Tyuiu.SavitskiyDN.WindowsForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.labelStart = new System.Windows.Forms.Label();
            this.numericStart = new System.Windows.Forms.NumericUpDown();
            this.labelFinish = new System.Windows.Forms.Label();
            this.numericFinish = new System.Windows.Forms.NumericUpDown();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.buttonDev = new System.Windows.Forms.Button();
            this.pictureBoxFunc = new System.Windows.Forms.PictureBox();
            this.textBoxRes = new System.Windows.Forms.TextBox();
            this.chartRes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.numericStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFinish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFunc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRes)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxDesc.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDesc.Location = new System.Drawing.Point(12, 12);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(426, 95);
            this.textBoxDesc.TabIndex = 1;
            this.textBoxDesc.TabStop = false;
            this.textBoxDesc.Text = "Для проведения рассчётов и построения графика \r\nнеобходимо ввести начальное и кон" +
    "ечное значение шага\r\nи нажать на кнопку \"ВЫПОЛНИТЬ РАССЧЁТ\"";
            this.textBoxDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelStart
            // 
            this.labelStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStart.AutoSize = true;
            this.labelStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStart.Location = new System.Drawing.Point(473, 20);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(67, 18);
            this.labelStart.TabIndex = 2;
            this.labelStart.Text = "Начало";
            // 
            // numericStart
            // 
            this.numericStart.Location = new System.Drawing.Point(476, 41);
            this.numericStart.Name = "numericStart";
            this.numericStart.Size = new System.Drawing.Size(64, 22);
            this.numericStart.TabIndex = 3;
            this.numericStart.ValueChanged += new System.EventHandler(this.numericStart_ValueChanged);
            // 
            // labelFinish
            // 
            this.labelFinish.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFinish.AutoSize = true;
            this.labelFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFinish.Location = new System.Drawing.Point(572, 20);
            this.labelFinish.Name = "labelFinish";
            this.labelFinish.Size = new System.Drawing.Size(56, 18);
            this.labelFinish.TabIndex = 4;
            this.labelFinish.Text = "Конец";
            // 
            // numericFinish
            // 
            this.numericFinish.Location = new System.Drawing.Point(575, 41);
            this.numericFinish.Name = "numericFinish";
            this.numericFinish.Size = new System.Drawing.Size(53, 22);
            this.numericFinish.TabIndex = 5;
            // 
            // buttonCalc
            // 
            this.buttonCalc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCalc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalc.Location = new System.Drawing.Point(453, 84);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(262, 51);
            this.buttonCalc.TabIndex = 6;
            this.buttonCalc.Text = "ВЫПОЛНИТЬ РАССЧЁТ";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // buttonDev
            // 
            this.buttonDev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDev.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDev.Location = new System.Drawing.Point(670, 12);
            this.buttonDev.Name = "buttonDev";
            this.buttonDev.Size = new System.Drawing.Size(120, 61);
            this.buttonDev.TabIndex = 7;
            this.buttonDev.Text = "О разработчике";
            this.buttonDev.UseVisualStyleBackColor = true;
            this.buttonDev.Click += new System.EventHandler(this.buttonDev_Click);
            // 
            // pictureBoxFunc
            // 
            this.pictureBoxFunc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxFunc.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFunc.Image")));
            this.pictureBoxFunc.Location = new System.Drawing.Point(12, 130);
            this.pictureBoxFunc.Name = "pictureBoxFunc";
            this.pictureBoxFunc.Size = new System.Drawing.Size(284, 60);
            this.pictureBoxFunc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFunc.TabIndex = 8;
            this.pictureBoxFunc.TabStop = false;
            // 
            // textBoxRes
            // 
            this.textBoxRes.Location = new System.Drawing.Point(12, 196);
            this.textBoxRes.Multiline = true;
            this.textBoxRes.Name = "textBoxRes";
            this.textBoxRes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRes.Size = new System.Drawing.Size(284, 279);
            this.textBoxRes.TabIndex = 9;
            // 
            // chartRes
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRes.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRes.Legends.Add(legend1);
            this.chartRes.Location = new System.Drawing.Point(317, 141);
            this.chartRes.Name = "chartRes";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartRes.Series.Add(series1);
            this.chartRes.Size = new System.Drawing.Size(486, 334);
            this.chartRes.TabIndex = 10;
            this.chartRes.Text = "chartRes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 501);
            this.Controls.Add(this.chartRes);
            this.Controls.Add(this.textBoxRes);
            this.Controls.Add(this.pictureBoxFunc);
            this.Controls.Add(this.buttonDev);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.numericFinish);
            this.Controls.Add(this.labelFinish);
            this.Controls.Add(this.numericStart);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.textBoxDesc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFinish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFunc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.NumericUpDown numericStart;
        private System.Windows.Forms.Label labelFinish;
        private System.Windows.Forms.NumericUpDown numericFinish;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Button buttonDev;
        private System.Windows.Forms.PictureBox pictureBoxFunc;
        private System.Windows.Forms.TextBox textBoxRes;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRes;
    }
}

