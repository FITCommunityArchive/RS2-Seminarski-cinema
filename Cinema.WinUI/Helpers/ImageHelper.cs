using System.Drawing;
using System.IO;

namespace Cinema.WinUI.Helpers
{
    public static class ImageHelper
    {
        public static Image ToImage(this byte[] byteArray)
        {
            using (MemoryStream memoryStream = new MemoryStream(byteArray))
            {
                Image image = Image.FromStream(memoryStream);
                return image;
            }
        }
    }
}
