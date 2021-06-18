
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
            this.txbLanguage1 = new System.Windows.Forms.TextBox();
            this.txbLanguage2 = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblLanguage1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInputTranslation
            // 
            this.lblInputTranslation.AutoSize = true;
            this.lblInputTranslation.Location = new System.Drawing.Point(178, 33);
            this.lblInputTranslation.Name = "lblInputTranslation";
            this.lblInputTranslation.Size = new System.Drawing.Size(420, 32);
            this.lblInputTranslation.TabIndex = 0;
            this.lblInputTranslation.Text = "Input Translation into the second field";
            this.lblInputTranslation.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLanguage2
            // 
            this.lblLanguage2.AutoSize = true;
            this.lblLanguage2.Location = new System.Drawing.Point(497, 107);
            this.lblLanguage2.Name = "lblLanguage2";
            this.lblLanguage2.Size = new System.Drawing.Size(138, 32);
            this.lblLanguage2.TabIndex = 2;
            this.lblLanguage2.Text = "Language 2";
            // 
            // txbLanguage1
            // 
            this.txbLanguage1.Location = new System.Drawing.Point(100, 160);
            this.txbLanguage1.Name = "txbLanguage1";
            this.txbLanguage1.Size = new System.Drawing.Size(200, 39);
            this.txbLanguage1.TabIndex = 3;
            // 
            // txbLanguage2
            // 
            this.txbLanguage2.Location = new System.Drawing.Point(460, 160);
            this.txbLanguage2.Name = "txbLanguage2";
            this.txbLanguage2.Size = new System.Drawing.Size(200, 39);
            this.txbLanguage2.TabIndex = 4;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(303, 282);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(150, 46);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next Word";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(303, 344);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 46);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // lblLanguage1
            // 
            this.lblLanguage1.AutoSize = true;
            this.lblLanguage1.Location = new System.Drawing.Point(133, 107);
            this.lblLanguage1.Name = "lblLanguage1";
            this.lblLanguage1.Size = new System.Drawing.Size(138, 32);
            this.lblLanguage1.TabIndex = 1;
            this.lblLanguage1.Text = "Language 1";
            // 
            // Interaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 407);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txbLanguage2);
            this.Controls.Add(this.txbLanguage1);
            this.Controls.Add(this.lblLanguage2);
            this.Controls.Add(this.lblLanguage1);
            this.Controls.Add(this.lblInputTranslation);
            this.Name = "Interaction";
            this.Text = "Interaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInputTranslation;
        private System.Windows.Forms.Label lblLanguage2;
        private System.Windows.Forms.TextBox txbLanguage1;
        private System.Windows.Forms.TextBox txbLanguage2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblLanguage1;
    }
}