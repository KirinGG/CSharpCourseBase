using System.Drawing;

namespace ImageTest
{
    class ImageHandler
    {
        static void Main(string[] args)
        {
            Bitmap image = new Bitmap("..\\..\\image.jpg");
            
            for (int y = 0; y < image.Height; ++y)
            {
                for (int x = 0; x < image.Width; ++x)
                {
                    Color pixel = image.GetPixel(x, y);
                    Color newColor = GetGreyColor(pixel);
                    
                    image.SetPixel(x, y, newColor);
                }
            }

            image.Save("out.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        public static Color GetGreyColor(Color pixel)
        {
            int greyColor = (int)(0.3 * pixel.R + 0.59 * pixel.G + 0.11 * pixel.B);
            return Color.FromArgb(greyColor, greyColor, greyColor);
        }
    }
}
