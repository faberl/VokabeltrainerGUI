
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
            this.lblLanguage1 = new System.Windows.Forms.Label();
            this.lblLanguage2 = new System.Windows.Forms.Label();
            this.cbxLanguage1 = new System.Windows.Forms.ComboBox();
            this.cbxLanguage2 = new System.Windows.Forms.ComboBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.tbnStartTraining = new System.Windows.Forms.Button();
            this.btnStartTest = new System.Windows.Forms.Button();
            this.btnAddWord = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblStats = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLanguage1
            // 
            this.lblLanguage1.AutoSize = true;
            this.lblLanguage1.Location = new System.Drawing.Point(107, 77);
            this.lblLanguage1.Name = "lblLanguage1";
            this.lblLanguage1.Size = new System.Drawing.Size(126, 25);
            this.lblLanguage1.TabIndex = 0;
            this.lblLanguage1.Text = "Language 1";
            // 
            // lblLanguage2
            // 
            this.lblLanguage2.AutoSize = true;
            this.lblLanguage2.Location = new System.Drawing.Point(429, 77);
            this.lblLanguage2.Name = "lblLanguage2";
            this.lblLanguage2.Size = new System.Drawing.Size(126, 25);
            this.lblLanguage2.TabIndex = 1;
            this.lblLanguage2.Text = "Language 2";
            // 
            // cbxLanguage1
            // 
            this.cbxLanguage1.FormattingEnabled = true;
            this.cbxLanguage1.Location = new System.Drawing.Point(65, 114);
            this.cbxLanguage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxLanguage1.Name = "cbxLanguage1";
            this.cbxLanguage1.Size = new System.Drawing.Size(224, 33);
            this.cbxLanguage1.TabIndex = 2;
            // 
            // cbxLanguage2
            // 
            this.cbxLanguage2.FormattingEnabled = true;
            this.cbxLanguage2.Location = new System.Drawing.Point(387, 114);
            this.cbxLanguage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxLanguage2.Name = "cbxLanguage2";
            this.cbxLanguage2.Size = new System.Drawing.Size(224, 33);
            this.cbxLanguage2.TabIndex = 3;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(215, 28);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(233, 25);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Select your Languages";
            // 
            // tbnStartTraining
            // 
            this.tbnStartTraining.Location = new System.Drawing.Point(215, 172);
            this.tbnStartTraining.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbnStartTraining.Name = "tbnStartTraining";
            this.tbnStartTraining.Size = new System.Drawing.Size(234, 42);
            this.tbnStartTraining.TabIndex = 5;
            this.tbnStartTraining.Text = "Start Training";
            this.tbnStartTraining.UseVisualStyleBackColor = true;
            this.tbnStartTraining.Click += new System.EventHandler(this.tbnStartTraining_Click);
            // 
            // btnStartTest
            // 
            this.btnStartTest.Location = new System.Drawing.Point(215, 238);
            this.btnStartTest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStartTest.Name = "btnStartTest";
            this.btnStartTest.Size = new System.Drawing.Size(234, 47);
            this.btnStartTest.TabIndex = 6;
            this.btnStartTest.Text = "Start Test";
            this.btnStartTest.UseVisualStyleBackColor = true;
            this.btnStartTest.Click += new System.EventHandler(this.btnStartTest_Click);
            // 
            // btnAddWord
            // 
            this.btnAddWord.Location = new System.Drawing.Point(215, 307);
            this.btnAddWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Size = new System.Drawing.Size(234, 45);
            this.btnAddWord.TabIndex = 7;
            this.btnAddWord.Text = "Add new word";
            this.btnAddWord.UseVisualStyleBackColor = true;
            this.btnAddWord.Click += new System.EventHandler(this.btnAddWord_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(215, 370);
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
            this.lblStats.Location = new System.Drawing.Point(873, 28);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(173, 25);
            this.lblStats.TabIndex = 9;
            this.lblStats.Text = "Current statistics";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 460);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddWord);
            this.Controls.Add(this.btnStartTest);
            this.Controls.Add(this.tbnStartTraining);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.cbxLanguage2);
            this.Controls.Add(this.cbxLanguage1);
            this.Controls.Add(this.lblLanguage2);
            this.Controls.Add(this.lblLanguage1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainView";
            this.Text = "Vokabeltrainer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLanguage1;
        private System.Windows.Forms.Label lblLanguage2;
        private System.Windows.Forms.ComboBox cbxLanguage1;
        private System.Windows.Forms.ComboBox cbxLanguage2;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button tbnStartTraining;
        private System.Windows.Forms.Button btnStartTest;
        private System.Windows.Forms.Button btnAddWord;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblStats;
    }
}

