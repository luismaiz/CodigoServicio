using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace ServicioWcfSoapRest.Core
{
    internal static class JuegoDataSource
    {
        private static List<Juego> _juegos;

        public static List<Juego> Juegos
        {
            get
            {
                return CreateDataSource();
            }
        }

        private static List<Juego> CreateDataSource()
        {
            _juegos = new List<Juego>();

            _juegos.Add(new Juego()
            {
                Ruta = "123456",
                Nombre = "Atari",
                Descripcion = "Descripcion Atari",
                Imagen = ConvertImageToByteArray(new Bitmap(@"C:\Juegos\Atari\image.jpg"), ImageFormat.Jpeg),
            });

            _juegos.Add(new Juego()
            {
                Ruta = "123456",
                Nombre = "Neo Geo",
                Descripcion = "Descripcion Neo GEO",
                Imagen = ConvertImageToByteArray(new Bitmap(@"C:\Juegos\Neo Geo\image.jpg"), ImageFormat.Jpeg),
            });

            _juegos.Add(new Juego()
            {
                Ruta = "123456",
                Nombre = "Play",
                Descripcion = "Descripcion Play",
                Imagen = ConvertImageToByteArray(new Bitmap(@"C:\Juegos\Play\image.jpg"), ImageFormat.Jpeg),
            });

            return _juegos;
        }

        public static byte[] ConvertImageToByteArray
        (System.Drawing.Image _image, ImageFormat _formatImage)
        {
            byte[] ImageByte;

            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    _image.Save(ms, _formatImage);
                    ImageByte = ms.ToArray();
                }
            }
            catch (Exception) { throw; }
            return ImageByte;
        }
    }

}