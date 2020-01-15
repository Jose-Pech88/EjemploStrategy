using Strategy.Services.Interfaces;
using System;

namespace Strategy.Services
{
    public class AlmacenadorImagenes
    {
        private readonly IAlmacenadorImagen AlmacenadorImagen;
        public AlmacenadorImagenes(IAlmacenadorImagen _almacenadorImagen)
        {
            this.AlmacenadorImagen = _almacenadorImagen ?? throw new ArgumentNullException(nameof(_almacenadorImagen));
        }

        public string AlmacenarImagen(string _cNombre, string _cExtension)
        {
            return this.AlmacenadorImagen.GuardarImagen(_cNombre, _cExtension);
        }
    }
}
