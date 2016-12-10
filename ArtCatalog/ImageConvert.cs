using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ArtCatalog
{
    class ImageConvert
    {
        // Конструктор без параметров (служит только для создания экземпляра класса)
        public ImageConvert()
        { }

        // Метод конвертации с Image в массив байтов
        public byte[] imageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream(); // Экземпляр класса для для побайтового чтения
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif); //конвертаия
            return ms.ToArray();
        }

        // обратный метод
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

    }
}
