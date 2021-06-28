
namespace VokabeltrainerGUI
{
    partial class TestView
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
            this.lblInputTranslation = new System.Windows.Forms.Label();
            this.lblLanguage2 = new System.Windows.Forms.Label();
            this.tbxLanguage1 = new System.Windows.Forms.TextBox();
            this.tbxLanguage2 = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblLanguage1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInputTranslation
            // 
            this.lblInputTranslation.AutoSize = true;
            this.lblInputTranslation.Location = new System.Drawing.Point(263, 30);
            this.lblInputTranslation.Name = "lblInputTranslation";
            this.lblInputTranslation.Size = new System.Drawing.Size(178, 25);
            this.lblInputTranslation.TabIndex = 0;
            this.lblInputTranslation.Text = "Input Translation ";
            // 
            // lblLanguage2
            // 
            this.lblLanguage2.AutoSize = true;
            this.lblLanguage2.Location = new System.Drawing.Point(459, 84);
            this.lblLanguage2.Name = "lblLanguage2";
            this.lblLanguage2.Size = new System.Drawing.Size(126, 25);
            this.lblLanguage2.TabIndex = 2;
            this.lblLanguage2.Text = "Language 2";
            // 
            // tbxLanguage1
            // 
            this.tbxLanguage1.Location = new System.Drawing.Point(92, 125);
            this.tbxLanguage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxLanguage1.Name = "tbxLanguage1";
            this.tbxLanguage1.Size = new System.Drawing.Size(185, 31);
            this.tbxLanguage1.TabIndex = 3;
            // 
            // tbxLanguage2
            // 
            this.tbxLanguage2.Location = new System.Drawing.Point(425, 125);
            this.tbxLanguage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxLanguage2.Name = "tbxLanguage2";
            this.tbxLanguage2.Size = new System.Drawing.Size(185, 31);
            this.tbxLanguage2.TabIndex = 4;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(280, 220);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(138, 36);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next Word";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(280, 269);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(138, 36);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblLanguage1
            // 
            this.lblLanguage1.AutoSize = true;
            this.lblLanguage1.Location = new System.Drawing.Point(123, 84);
            this.lblLanguage1.Name = "lblLanguage1";
            this.lblLanguage1.Size = new System.Drawing.Size(126, 25);
            this.lblLanguage1.TabIndex = 1;
            this.lblLanguage1.Text = "Language 1";
            // 
            // TestView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 318);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.tbxLanguage2);
            this.Controls.Add(this.tbxLanguage1);
            this.Controls.Add(this.lblLanguage2);
            this.Controls.Add(this.lblLanguage1);
            this.Controls.Add(this.lblInputTranslation);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TestView";
            this.Text = "Interaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInputTranslation;
        private System.Windows.Forms.Label lblLanguage2;
        private System.Windows.Forms.TextBox tbxLanguage1;
        private System.Windows.Forms.TextBox tbxLanguage2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblLanguage1;
    }
}