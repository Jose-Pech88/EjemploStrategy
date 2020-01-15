using Strategy.Services.Interfaces;

namespace Strategy.Services.Factory.Interfaces
{
    public interface IAlmacenadorFactory
    {
        IAlmacenadorImagen ObtenerEstrategia(string _cExtension);
    }
}
