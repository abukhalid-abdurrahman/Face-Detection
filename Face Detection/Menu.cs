using System;
using System.Windows.Forms;

namespace Face_Detection
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void videoBtn_Click(object sender, EventArgs e)
        {
            FaceCamera faceCamera = new FaceCamera();
            faceCamera.ShowDialog(this);
        }

        private void imageBtn_Click(object sender, EventArgs e)
        {
            FaceImage faceImage = new FaceImage();
            faceImage.ShowDialog(this);
        }
    }
}
