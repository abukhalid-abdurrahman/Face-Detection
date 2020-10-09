namespace Face_Detection
{
    partial class Menu
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
            this.videoBtn = new System.Windows.Forms.Button();
            this.imageBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // videoBtn
            // 
            this.videoBtn.Location = new System.Drawing.Point(12, 12);
            this.videoBtn.Name = "videoBtn";
            this.videoBtn.Size = new System.Drawing.Size(295, 42);
            this.videoBtn.TabIndex = 0;
            this.videoBtn.Text = "Video Face Detection";
            this.videoBtn.UseVisualStyleBackColor = true;
            this.videoBtn.Click += new System.EventHandler(this.videoBtn_Click);
            // 
            // imageBtn
            // 
            this.imageBtn.Location = new System.Drawing.Point(12, 60);
            this.imageBtn.Name = "imageBtn";
            this.imageBtn.Size = new System.Drawing.Size(295, 42);
            this.imageBtn.TabIndex = 1;
            this.imageBtn.Text = "Image Face Detection";
            this.imageBtn.UseVisualStyleBackColor = true;
            this.imageBtn.Click += new System.EventHandler(this.imageBtn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 110);
            this.Controls.Add(this.imageBtn);
            this.Controls.Add(this.videoBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button videoBtn;
        private System.Windows.Forms.Button imageBtn;
    }
}