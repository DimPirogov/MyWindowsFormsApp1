namespace Guldkortet
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.buttonKopplaUpp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 12);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(477, 342);
            this.listBox.TabIndex = 0;
            // 
            // buttonKopplaUpp
            // 
            this.buttonKopplaUpp.Location = new System.Drawing.Point(12, 368);
            this.buttonKopplaUpp.Name = "buttonKopplaUpp";
            this.buttonKopplaUpp.Size = new System.Drawing.Size(201, 70);
            this.buttonKopplaUpp.TabIndex = 1;
            this.buttonKopplaUpp.Text = "Koppla upp";
            this.buttonKopplaUpp.UseVisualStyleBackColor = true;
            this.buttonKopplaUpp.Click += new System.EventHandler(this.buttonKopplaUpp_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 70);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ladda Kunder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(558, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 70);
            this.button2.TabIndex = 3;
            this.button2.Text = "Ladda kort";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(558, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(201, 70);
            this.button3.TabIndex = 4;
            this.button3.Text = "Avsluta";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonKopplaUpp);
            this.Controls.Add(this.listBox);
            this.Name = "Form1";
            this.Text = "NOS_Lyssnare";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button buttonKopplaUpp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

