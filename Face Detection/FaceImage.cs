using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Face_Detection
{
    public partial class FaceImage : Form
    {
        private static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml");

        public FaceImage()
        {
            InitializeComponent();
        }

        private void loadImageBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string filename = ofd.FileName;
                    Bitmap bitmap = LoadImage(filename);
                    imageBox.Image = new ImageDetection(cascadeClassifier).Detect(bitmap);
                }
            }
        }

        private Bitmap LoadImage(string _filename)
        {
            try
            {
                if (string.IsNullOrEmpty(_filename.Trim()))
                    return null;

                var bitmap = new Bitmap(_filename);
                return bitmap;
            }
            catch
            {
                return null;
            }
        }
    }
}
