namespace ClipboardCollector
{
    partial class uxMainForm
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
            this.components = new System.ComponentModel.Container();
            this.uxText = new System.Windows.Forms.TextBox();
            this.uxPause = new System.Windows.Forms.Button();
            this.uxClear = new System.Windows.Forms.Button();
            this.uxTimer = new System.Windows.Forms.Timer(this.components);
            this.uxCopy = new System.Windows.Forms.Button();
            this.uxAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxText
            // 
            this.uxText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uxText.Location = new System.Drawing.Point(12, 12);
            this.uxText.Multiline = true;
            this.uxText.Name = "uxText";
            this.uxText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.uxText.Size = new System.Drawing.Size(561, 387);
            this.uxText.TabIndex = 0;
            // 
            // uxPause
            // 
            this.uxPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uxPause.Location = new System.Drawing.Point(12, 405);
            this.uxPause.Name = "uxPause";
            this.uxPause.Size = new System.Drawing.Size(75, 23);
            this.uxPause.TabIndex = 1;
            this.uxPause.Text = "Pause";
            this.uxPause.UseVisualStyleBackColor = true;
            this.uxPause.Click += new System.EventHandler(this.uxPause_Click);
            // 
            // uxClear
            // 
            this.uxClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uxClear.Location = new System.Drawing.Point(174, 405);
            this.uxClear.Name = "uxClear";
            this.uxClear.Size = new System.Drawing.Size(75, 23);
            this.uxClear.TabIndex = 2;
            this.uxClear.Text = "Clear";
            this.uxClear.UseVisualStyleBackColor = true;
            this.uxClear.Click += new System.EventHandler(this.uxClear_Click);
            // 
            // uxTimer
            // 
            this.uxTimer.Tick += new System.EventHandler(this.uxTimer_Tick);
            // 
            // uxCopy
            // 
            this.uxCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uxCopy.Location = new System.Drawing.Point(93, 405);
            this.uxCopy.Name = "uxCopy";
            this.uxCopy.Size = new System.Drawing.Size(75, 23);
            this.uxCopy.TabIndex = 3;
            this.uxCopy.Text = "Copy";
            this.uxCopy.UseVisualStyleBackColor = true;
            this.uxCopy.Click += new System.EventHandler(this.uxCopy_Click);
            // 
            // uxAbout
            // 
            this.uxAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uxAbout.Location = new System.Drawing.Point(498, 405);
            this.uxAbout.Name = "uxAbout";
            this.uxAbout.Size = new System.Drawing.Size(75, 23);
            this.uxAbout.TabIndex = 4;
            this.uxAbout.Text = "About";
            this.uxAbout.UseVisualStyleBackColor = true;
            this.uxAbout.Click += new System.EventHandler(this.uxAbout_Click);
            // 
            // uxMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 440);
            this.Controls.Add(this.uxAbout);
            this.Controls.Add(this.uxCopy);
            this.Controls.Add(this.uxClear);
            this.Controls.Add(this.uxPause);
            this.Controls.Add(this.uxText);
            this.Name = "uxMainForm";
            this.Text = "ClipboardCollector";
            this.Load += new System.EventHandler(this.uxMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxText;
        private System.Windows.Forms.Button uxPause;
        private System.Windows.Forms.Button uxClear;
        private System.Windows.Forms.Timer uxTimer;
        private System.Windows.Forms.Button uxCopy;
        private System.Windows.Forms.Button uxAbout;
    }
}

