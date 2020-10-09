namespace Face_Detection
{
    partial class FaceCamera
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
            this.CameraArea = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CameraArea)).BeginInit();
            this.SuspendLayout();
            // 
            // CameraArea
            // 
            this.CameraArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CameraArea.Location = new System.Drawing.Point(0, 0);
            this.CameraArea.Name = "CameraArea";
            this.CameraArea.Size = new System.Drawing.Size(800, 450);
            this.CameraArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CameraArea.TabIndex = 0;
            this.CameraArea.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CameraArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Face Detection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CameraArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox CameraArea;
    }
}

