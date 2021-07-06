
namespace VokabeltrainerGUI
{
    partial class MainView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblLanguage1 = new System.Windows.Forms.Label();
            this.lblLanguage2 = new System.Windows.Forms.Label();
            this.cbxLanguage1 = new System.Windows.Forms.ComboBox();
            this.cbxLanguage2 = new System.Windows.Forms.ComboBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnStartTest = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblStats = new System.Windows.Forms.Label();
            this.chartResults = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnResetStats = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartResults)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLanguage1
            // 
            this.lblLanguage1.AutoSize = true;
            this.lblLanguage1.Location = new System.Drawing.Point(109, 139);
            this.lblLanguage1.Name = "lblLanguage1";
            this.lblLanguage1.Size = new System.Drawing.Size(126, 25);
            this.lblLanguage1.TabIndex = 0;
            this.lblLanguage1.Text = "Language 1";
            // 
            // lblLanguage2
            // 
            this.lblLanguage2.AutoSize = true;
            this.lblLanguage2.Location = new System.Drawing.Point(436, 139);
            this.lblLanguage2.Name = "lblLanguage2";
            this.lblLanguage2.Size = new System.Drawing.Size(126, 25);
            this.lblLanguage2.TabIndex = 1;
            this.lblLanguage2.Text = "Language 2";
            // 
            // cbxLanguage1
            // 
            this.cbxLanguage1.FormattingEnabled = true;
            this.cbxLanguage1.Location = new System.Drawing.Point(72, 185);
            this.cbxLanguage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxLanguage1.Name = "cbxLanguage1";
            this.cbxLanguage1.Size = new System.Drawing.Size(224, 33);
            this.cbxLanguage1.TabIndex = 2;
            // 
            // cbxLanguage2
            // 
            this.cbxLanguage2.FormattingEnabled = true;
            this.cbxLanguage2.Location = new System.Drawing.Point(396, 185);
            this.cbxLanguage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxLanguage2.Name = "cbxLanguage2";
            this.cbxLanguage2.Size = new System.Drawing.Size(224, 33);
            this.cbxLanguage2.TabIndex = 3;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(227, 77);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(233, 25);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Select your Languages";
            // 
            // btnStartTest
            // 
            this.btnStartTest.Location = new System.Drawing.Point(214, 307);
            this.btnStartTest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStartTest.Name = "btnStartTest";
            this.btnStartTest.Size = new System.Drawing.Size(234, 47);
            this.btnStartTest.TabIndex = 6;
            this.btnStartTest.Text = "Start Test";
            this.btnStartTest.UseVisualStyleBackColor = true;
            this.btnStartTest.Click += new System.EventHandler(this.btnStartTest_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(214, 435);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(234, 46);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.Location = new System.Drawing.Point(885, 28);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(173, 25);
            this.lblStats.TabIndex = 9;
            this.lblStats.Text = "Current statistics";
            // 
            // chartResults
            // 
            this.chartResults.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartResults.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartResults.Legends.Add(legend1);
            this.chartResults.Location = new System.Drawing.Point(693, 77);
            this.chartResults.Name = "chartResults";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Color = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "S1";
            this.chartResults.Series.Add(series1);
            this.chartResults.Size = new System.Drawing.Size(502, 415);
            this.chartResults.TabIndex = 10;
            this.chartResults.Text = "chart1";
            // 
            // btnResetStats
            // 
            this.btnResetStats.Location = new System.Drawing.Point(214, 368);
            this.btnResetStats.Name = "btnResetStats";
            this.btnResetStats.Size = new System.Drawing.Size(234, 51);
            this.btnResetStats.TabIndex = 11;
            this.btnResetStats.Text = "Reset Statisitcs";
            this.btnResetStats.UseVisualStyleBackColor = true;
            this.btnResetStats.Click += new System.EventHandler(this.btnResetStats_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 504);
            this.Controls.Add(this.btnResetStats);
            this.Controls.Add(this.chartResults);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStartTest);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.cbxLanguage2);
            this.Controls.Add(this.cbxLanguage1);
            this.Controls.Add(this.lblLanguage2);
            this.Controls.Add(this.lblLanguage1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainView";
            this.Text = "Vokabeltrainer";
            ((System.ComponentModel.ISupportInitialize)(this.chartResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLanguage1;
        private System.Windows.Forms.Label lblLanguage2;
        private System.Windows.Forms.ComboBox cbxLanguage1;
        private System.Windows.Forms.ComboBox cbxLanguage2;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnStartTest;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResults;
        private System.Windows.Forms.Button btnResetStats;
    }
}

