namespace Youtube_dl_WinGui
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
            this.GoButton = new System.Windows.Forms.Button();
            this.URLbox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.DestinationBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFolder = new System.Windows.Forms.Button();
            this.addUrl = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GoButton
            // 
            this.GoButton.BackColor = System.Drawing.Color.Teal;
            this.GoButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GoButton.Location = new System.Drawing.Point(497, 235);
            this.GoButton.Margin = new System.Windows.Forms.Padding(4);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(92, 50);
            this.GoButton.TabIndex = 1;
            this.GoButton.Text = "Download mp3";
            this.GoButton.UseVisualStyleBackColor = false;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // URLbox
            // 
            this.URLbox.Location = new System.Drawing.Point(100, 45);
            this.URLbox.Margin = new System.Windows.Forms.Padding(4);
            this.URLbox.Multiline = true;
            this.URLbox.Name = "URLbox";
            this.URLbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.URLbox.Size = new System.Drawing.Size(389, 276);
            this.URLbox.TabIndex = 3;
            // 
            // DestinationBox
            // 
            this.DestinationBox.Location = new System.Drawing.Point(100, 6);
            this.DestinationBox.Margin = new System.Windows.Forms.Padding(4);
            this.DestinationBox.Name = "DestinationBox";
            this.DestinationBox.Size = new System.Drawing.Size(389, 22);
            this.DestinationBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(497, 3);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Destination";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "URL";
            // 
            // openFolder
            // 
            this.openFolder.Location = new System.Drawing.Point(497, 293);
            this.openFolder.Margin = new System.Windows.Forms.Padding(4);
            this.openFolder.Name = "openFolder";
            this.openFolder.Size = new System.Drawing.Size(92, 28);
            this.openFolder.TabIndex = 8;
            this.openFolder.Text = "Open folder";
            this.openFolder.UseVisualStyleBackColor = true;
            this.openFolder.Click += new System.EventHandler(this.openFolder_Click);
            // 
            // addUrl
            // 
            this.addUrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addUrl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addUrl.Location = new System.Drawing.Point(497, 45);
            this.addUrl.Margin = new System.Windows.Forms.Padding(4);
            this.addUrl.Name = "addUrl";
            this.addUrl.Size = new System.Drawing.Size(92, 63);
            this.addUrl.TabIndex = 9;
            this.addUrl.Text = "Add url from clipboard";
            this.addUrl.UseVisualStyleBackColor = false;
            this.addUrl.Click += new System.EventHandler(this.addUrl_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonReset.Location = new System.Drawing.Point(497, 116);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(92, 28);
            this.buttonReset.TabIndex = 10;
            this.buttonReset.Text = "Reset form";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(601, 336);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.addUrl);
            this.Controls.Add(this.openFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DestinationBox);
            this.Controls.Add(this.URLbox);
            this.Controls.Add(this.GoButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Youtube-dl - Download mp3 file from youtube";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.TextBox URLbox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox DestinationBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button openFolder;
        private System.Windows.Forms.Button addUrl;
        private System.Windows.Forms.Button buttonReset;
    }
}

