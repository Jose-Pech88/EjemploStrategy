using Strategy.Services.Interfaces;

namespace Strategy.Services
{
    public class AlmacenadorGIFStrategy : IAlmacenadorImagen
    {
        public string GuardarImagen(string _cCombreImagen, string _cExtensionImagen)
        {
            return string.Format("Se ha guardado la imagen {0}.{1} Correctamente.", _cCombreImagen, _cExtensionImagen);
        }
    }
}
