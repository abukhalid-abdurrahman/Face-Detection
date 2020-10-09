using Emgu.CV;
using Emgu.CV.Structure;
using System.Drawing;

namespace Face_Detection
{
    class ImageDetection : IDetectionImage
    {
        private readonly CascadeClassifier cascadeClassifier;
        public ImageDetection(CascadeClassifier _cascadeClassifier)
        {
            this.cascadeClassifier = _cascadeClassifier;
        }
        public Bitmap Detect(Bitmap _bitmap)
        {
            try
            {
                Image<Bgr, byte> grayImage = new Image<Bgr, byte>(_bitmap);
                Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(grayImage, 1.2, 1);
                foreach (var rect in rectangles)
                {
                    using (Graphics graph = Graphics.FromImage(_bitmap))
                    {
                        using (Pen pen = new Pen(Color.Yellow, 1))
                        {
                            graph.DrawRectangle(pen, rect);
                        }
                    }
                }
                return _bitmap;
            }
            catch
            {
                return null;
            }
        }
    }
}
