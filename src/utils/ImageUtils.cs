using System.Drawing.Imaging;
using System.Drawing;

namespace Battleship.Utils
{
    public class ImageUtils
    {
        public static Bitmap SetBitmapAlpha(Bitmap bmpIn, int alpha)
        {
            Bitmap bmpOut = new Bitmap(bmpIn.Width, bmpIn.Height);
            Rectangle r = new Rectangle(0, 0, bmpIn.Width, bmpIn.Height);

            float a = alpha / 255f;
            float[][] matrixItems = {
                new float[] {1, 0, 0, 0, 0},
                new float[] {0, 1, 0, 0, 0},
                new float[] {0, 0, 1, 0, 0},
                new float[] {0, 0, 0, a, 0},
                new float[] {0, 0, 0, 0, 1}};

            ImageAttributes imageAtt = new ImageAttributes();
            imageAtt.SetColorMatrix(
                new ColorMatrix(matrixItems), ColorMatrixFlag.Default, ColorAdjustType.Bitmap
            );

            Graphics g = Graphics.FromImage(bmpOut);
            g.DrawImage(bmpIn, r, r.X, r.Y, r.Width, r.Height, GraphicsUnit.Pixel, imageAtt);

            return bmpOut;
        }
    }
}
