using AForge.Video.DirectShow;
using System;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Face_Detection
{
    public partial class FaceCamera : Form
    {
        private static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml");
        private FilterInfoCollection filterInfoCollection;
        private VideoCaptureDevice device;
        public FaceCamera()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            device = new VideoCaptureDevice();
            InitDevice();
        }

        private void InitDevice()
        {
            device = new VideoCaptureDevice(filterInfoCollection[0].MonikerString);
            device.NewFrame += Device_NewFrame;
            device.Start();
        }

        private void Device_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            CameraArea.Image = new ImageDetection(cascadeClassifier).Detect(bitmap);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (device.IsRunning)
                device.Stop();
        }
    }
}
