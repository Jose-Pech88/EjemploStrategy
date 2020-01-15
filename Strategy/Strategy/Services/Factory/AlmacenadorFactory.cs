using Strategy.Services.Factory.Interfaces;
using Strategy.Services.Interfaces;

namespace Strategy.Services.Factory
{
    public class AlmacenadorFactory : IAlmacenadorFactory
    {
        public IAlmacenadorImagen ObtenerEstrategia(string _cExtension)
        {
            IAlmacenadorImagen almacenadorImagen = null;
            switch (_cExtension)
            {
                case "JPEG":
                    almacenadorImagen = new AlmacenadorJPEGStrategy();
                    break;
                case "PNG":
                    almacenadorImagen = new AlmacenadorPNGStrategy();
                    break;
                case "GIF":
                    almacenadorImagen = new AlmacenadorGIFStrategy();
                    break;
                case "BMP":
                    almacenadorImagen = new AlmacenadorBMPStrategy();
                    break;
                default:
                    break;
            }
            return almacenadorImagen;
        }
    }
}
