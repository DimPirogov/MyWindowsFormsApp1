namespace Avdelningsrapport
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
            this.connect = new System.Windows.Forms.Button();
            this.sendAll = new System.Windows.Forms.Button();
            this.sendMarked = new System.Windows.Forms.Button();
            this.loadList = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.quitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(13, 340);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(214, 76);
            this.connect.TabIndex = 1;
            this.connect.Text = "Koppla till server";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // sendAll
            // 
            this.sendAll.Enabled = false;
            this.sendAll.Location = new System.Drawing.Point(251, 341);
            this.sendAll.Name = "sendAll";
            this.sendAll.Size = new System.Drawing.Size(182, 23);
            this.sendAll.TabIndex = 2;
            this.sendAll.Text = "Skicka alla objekt";
            this.sendAll.UseVisualStyleBackColor = true;
            this.sendAll.Click += new System.EventHandler(this.sendAll_Click);
            // 
            // sendMarked
            // 
            this.sendMarked.Enabled = false;
            this.sendMarked.Location = new System.Drawing.Point(251, 367);
            this.sendMarked.Name = "sendMarked";
            this.sendMarked.Size = new System.Drawing.Size(182, 23);
            this.sendMarked.TabIndex = 3;
            this.sendMarked.Text = "Skicka markerat objekt";
            this.sendMarked.UseVisualStyleBackColor = true;
            this.sendMarked.Click += new System.EventHandler(this.sendMarked_Click);
            // 
            // loadList
            // 
            this.loadList.Location = new System.Drawing.Point(251, 393);
            this.loadList.Name = "loadList";
            this.loadList.Size = new System.Drawing.Size(182, 23);
            this.loadList.TabIndex = 4;
            this.loadList.Text = "Ladda lista";
            this.loadList.UseVisualStyleBackColor = true;
            this.loadList.Click += new System.EventHandler(this.loadList_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(569, 316);
            this.listBox1.TabIndex = 5;
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(452, 341);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(130, 75);
            this.quitButton.TabIndex = 6;
            this.quitButton.Text = "Avsluta";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 429);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.loadList);
            this.Controls.Add(this.sendMarked);
            this.Controls.Add(this.sendAll);
            this.Controls.Add(this.connect);
            this.Name = "Form1";
            this.Text = "Avdelningsrappport";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Button sendAll;
        private System.Windows.Forms.Button sendMarked;
        private System.Windows.Forms.Button loadList;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button quitButton;
    }
}

