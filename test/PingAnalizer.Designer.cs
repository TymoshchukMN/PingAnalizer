using System.Drawing;

namespace PingAnalizer
{
    partial class FmLogAnalizer
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tb1FilePath = new System.Windows.Forms.TextBox();
            this.btSelect1File = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btSelect2File = new System.Windows.Forms.Button();
            this.tb2FilePath = new System.Windows.Forms.TextBox();
            this.btSelect3File = new System.Windows.Forms.Button();
            this.tb3FilePath = new System.Windows.Forms.TextBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btClose = new System.Windows.Forms.Button();
            this.btMaximize = new System.Windows.Forms.Button();
            this.btHide = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.SuspendLayout();
            // 
            // tb1FilePath
            // 
            this.tb1FilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb1FilePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.tb1FilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb1FilePath.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tb1FilePath.Location = new System.Drawing.Point(157, 32);
            this.tb1FilePath.Name = "tb1FilePath";
            this.tb1FilePath.ReadOnly = true;
            this.tb1FilePath.Size = new System.Drawing.Size(670, 20);
            this.tb1FilePath.TabIndex = 0;
            // 
            // btSelect1File
            // 
            this.btSelect1File.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btSelect1File.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btSelect1File.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSelect1File.Location = new System.Drawing.Point(12, 32);
            this.btSelect1File.Name = "btSelect1File";
            this.btSelect1File.Size = new System.Drawing.Size(120, 23);
            this.btSelect1File.TabIndex = 1;
            this.btSelect1File.Text = "Select first log file";
            this.btSelect1File.UseVisualStyleBackColor = false;
            this.btSelect1File.Click += new System.EventHandler(this.BtSelectFirtsFile_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(862, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Display data";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btSelect2File
            // 
            this.btSelect2File.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btSelect2File.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSelect2File.Location = new System.Drawing.Point(12, 62);
            this.btSelect2File.Name = "btSelect2File";
            this.btSelect2File.Size = new System.Drawing.Size(120, 23);
            this.btSelect2File.TabIndex = 5;
            this.btSelect2File.Text = "Select second log file";
            this.btSelect2File.UseVisualStyleBackColor = false;
            this.btSelect2File.Click += new System.EventHandler(this.BtSelect2File_Click);
            // 
            // tb2FilePath
            // 
            this.tb2FilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb2FilePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.tb2FilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb2FilePath.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tb2FilePath.Location = new System.Drawing.Point(157, 62);
            this.tb2FilePath.Name = "tb2FilePath";
            this.tb2FilePath.ReadOnly = true;
            this.tb2FilePath.Size = new System.Drawing.Size(670, 20);
            this.tb2FilePath.TabIndex = 4;
            // 
            // btSelect3File
            // 
            this.btSelect3File.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btSelect3File.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSelect3File.Location = new System.Drawing.Point(12, 92);
            this.btSelect3File.Name = "btSelect3File";
            this.btSelect3File.Size = new System.Drawing.Size(120, 23);
            this.btSelect3File.TabIndex = 7;
            this.btSelect3File.Text = "Select third log file";
            this.btSelect3File.UseVisualStyleBackColor = false;
            this.btSelect3File.Click += new System.EventHandler(this.BtSelect3File_Click);
            // 
            // tb3FilePath
            // 
            this.tb3FilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb3FilePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.tb3FilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb3FilePath.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tb3FilePath.Location = new System.Drawing.Point(157, 92);
            this.tb3FilePath.Name = "tb3FilePath";
            this.tb3FilePath.ReadOnly = true;
            this.tb3FilePath.Size = new System.Drawing.Size(670, 20);
            this.tb3FilePath.TabIndex = 6;
            // 
            // chart2
            // 
            this.chart2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            chartArea10.AxisX.Interval = 1D;
            chartArea10.AxisX.IsLabelAutoFit = false;
            chartArea10.AxisX.LabelStyle.Angle = -90;
            chartArea10.AxisX.LabelStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            chartArea10.AxisX.Title = "ping time";
            chartArea10.AxisX.TitleForeColor = System.Drawing.Color.WhiteSmoke;
            chartArea10.AxisY.LabelStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            chartArea10.AxisY.Title = "milliseconds";
            chartArea10.AxisY.TitleForeColor = System.Drawing.Color.WhiteSmoke;
            chartArea10.BackColor = System.Drawing.Color.DimGray;
            chartArea10.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            chartArea10.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea10);
            legend10.Enabled = false;
            legend10.Name = "Legend1";
            this.chart2.Legends.Add(legend10);
            this.chart2.Location = new System.Drawing.Point(10, 401);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series10.BorderWidth = 5;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series10.IsVisibleInLegend = false;
            series10.Legend = "Legend1";
            series10.MarkerBorderColor = System.Drawing.Color.Red;
            series10.MarkerColor = System.Drawing.Color.White;
            series10.MarkerSize = 8;
            series10.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series10.Name = "StatGaph2";
            series10.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            this.chart2.Series.Add(series10);
            this.chart2.Size = new System.Drawing.Size(1155, 230);
            this.chart2.TabIndex = 8;
            this.chart2.Text = "chart2";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            chartArea11.AxisX.Interval = 1D;
            chartArea11.AxisX.IsLabelAutoFit = false;
            chartArea11.AxisX.LabelStyle.Angle = -90;
            chartArea11.AxisX.LabelStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            chartArea11.AxisX.Title = "ping time";
            chartArea11.AxisX.TitleForeColor = System.Drawing.Color.WhiteSmoke;
            chartArea11.AxisY.LabelStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            chartArea11.AxisY.Title = "milliseconds";
            chartArea11.AxisY.TitleForeColor = System.Drawing.Color.WhiteSmoke;
            chartArea11.BackColor = System.Drawing.Color.DimGray;
            chartArea11.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            chartArea11.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea11);
            legend11.Enabled = false;
            legend11.ForeColor = System.Drawing.Color.WhiteSmoke;
            legend11.Name = "Legend1";
            this.chart1.Legends.Add(legend11);
            this.chart1.Location = new System.Drawing.Point(10, 166);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series11.BorderWidth = 5;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series11.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(215)))));
            series11.IsVisibleInLegend = false;
            series11.Legend = "Legend1";
            series11.MarkerBorderColor = System.Drawing.Color.Fuchsia;
            series11.MarkerColor = System.Drawing.Color.White;
            series11.MarkerSize = 8;
            series11.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series11.Name = "StatGaph1";
            series11.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            this.chart1.Series.Add(series11);
            this.chart1.Size = new System.Drawing.Size(1154, 230);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // chart3
            // 
            this.chart3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            chartArea12.AxisX.Interval = 1D;
            chartArea12.AxisX.IsLabelAutoFit = false;
            chartArea12.AxisX.LabelStyle.Angle = -90;
            chartArea12.AxisX.LabelStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            chartArea12.AxisX.Title = "ping time";
            chartArea12.AxisX.TitleForeColor = System.Drawing.Color.WhiteSmoke;
            chartArea12.AxisY.LabelStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            chartArea12.AxisY.Title = "milliseconds";
            chartArea12.AxisY.TitleForeColor = System.Drawing.Color.WhiteSmoke;
            chartArea12.BackColor = System.Drawing.Color.DimGray;
            chartArea12.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            chartArea12.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea12);
            legend12.Enabled = false;
            legend12.Name = "Legend1";
            this.chart3.Legends.Add(legend12);
            this.chart3.Location = new System.Drawing.Point(10, 641);
            this.chart3.Name = "chart3";
            this.chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series12.BorderWidth = 5;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series12.Color = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(75)))), ((int)(((byte)(250)))), ((int)(((byte)(215)))));
            series12.IsVisibleInLegend = false;
            series12.Legend = "Legend1";
            series12.MarkerBorderColor = System.Drawing.Color.Blue;
            series12.MarkerSize = 8;
            series12.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series12.Name = "StatGaph3";
            series12.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            this.chart3.Series.Add(series12);
            this.chart3.Size = new System.Drawing.Size(1155, 230);
            this.chart3.TabIndex = 11;
            this.chart3.Text = "chart3";
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btClose.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Location = new System.Drawing.Point(1140, 3);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(30, 25);
            this.btClose.TabIndex = 12;
            this.btClose.Text = "X";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btMaximize
            // 
            this.btMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btMaximize.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMaximize.Location = new System.Drawing.Point(1104, 3);
            this.btMaximize.Name = "btMaximize";
            this.btMaximize.Size = new System.Drawing.Size(30, 25);
            this.btMaximize.TabIndex = 13;
            this.btMaximize.Text = "▢";
            this.btMaximize.UseVisualStyleBackColor = false;
            this.btMaximize.Click += new System.EventHandler(this.BtMaximize_Click);
            // 
            // btHide
            // 
            this.btHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btHide.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHide.Location = new System.Drawing.Point(1068, 3);
            this.btHide.Name = "btHide";
            this.btHide.Size = new System.Drawing.Size(30, 25);
            this.btHide.TabIndex = 14;
            this.btHide.Text = "__";
            this.btHide.UseVisualStyleBackColor = false;
            // 
            // FmLogAnalizer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1178, 884);
            this.Controls.Add(this.btHide);
            this.Controls.Add(this.btMaximize);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.btSelect3File);
            this.Controls.Add(this.tb3FilePath);
            this.Controls.Add(this.btSelect2File);
            this.Controls.Add(this.tb2FilePath);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btSelect1File);
            this.Controls.Add(this.tb1FilePath);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmLogAnalizer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PingAnalizer";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FmLogAnalizer_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb1FilePath;
        private System.Windows.Forms.Button btSelect1File;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btSelect2File;
        private System.Windows.Forms.TextBox tb2FilePath;
        private System.Windows.Forms.Button btSelect3File;
        private System.Windows.Forms.TextBox tb3FilePath;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btMaximize;
        private System.Windows.Forms.Button btHide;
    }
}

