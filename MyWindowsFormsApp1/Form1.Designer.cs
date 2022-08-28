using System;

namespace MyWindowsFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.myLabel = new System.Windows.Forms.Label();
            this.myTextBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tryck på mig för helvete!!!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // myLabel
            // 
            this.myLabel.AutoSize = true;
            this.myLabel.Location = new System.Drawing.Point(389, 283);
            this.myLabel.Name = "myLabel";
            this.myLabel.Size = new System.Drawing.Size(31, 13);
            this.myLabel.TabIndex = 1;
            this.myLabel.Text = "Hejja";
            this.myLabel.Click += new System.EventHandler(this.myLabel_Click);
            // 
            // myTextBox1
            // 
            this.myTextBox1.Location = new System.Drawing.Point(340, 83);
            this.myTextBox1.Name = "myTextBox1";
            this.myTextBox1.Size = new System.Drawing.Size(100, 20);
            this.myTextBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.myTextBox1);
            this.Controls.Add(this.myLabel);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Mitt Win Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label myLabel;
        private System.Windows.Forms.TextBox myTextBox1;
        private EventHandler button1_MouseHover;
        private EventHandler myLabel_Click;
    }
}

