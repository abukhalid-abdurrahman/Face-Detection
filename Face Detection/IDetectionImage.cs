using System.Drawing;

namespace Face_Detection
{
    interface IDetectionImage
    {
        Bitmap Detect(Bitmap bitmap);
    }
}
