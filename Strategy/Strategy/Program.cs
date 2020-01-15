using Strategy.Services.Factory;
using Strategy.Services.Factory.Interfaces;
using Strategy.Services.Interfaces;
using System;
using System.Threading;

namespace Strategi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InicializarAplicacion();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void InicializarAplicacion()
        {
            var cNombreImagen = string.Empty;
            var cExtensionImagen = string.Empty;
            Console.WriteLine("Capturar nombre de la imagen");
            cNombreImagen = Console.ReadLine();
            
            IAlmacenadorFactory almacenadorFactory = new AlmacenadorFactory();
            IAlmacenadorImagen almacenadorImagen;
            do
            {
                ImprimirMenu();
                cExtensionImagen = Console.ReadLine();
                almacenadorImagen = almacenadorFactory.ObtenerEstrategia(cExtensionImagen);
                if (almacenadorImagen == null)
                    Console.WriteLine("Formato no válido");

            } while (almacenadorImagen==null);            
           
            Console.WriteLine(almacenadorImagen.GuardarImagen(cNombreImagen, cExtensionImagen));
            Thread.Sleep(1500);
            Console.ReadKey();
            Console.Clear();
            InicializarAplicacion();
        }

        static void ImprimirMenu()
        {
            Console.WriteLine("\r");
            Console.WriteLine("Captura la Extensión de la imagen, sugeridos:");
            Console.WriteLine("JPEG");
            Console.WriteLine("PNG");
            Console.WriteLine("GIF");
            Console.WriteLine("BMP");
        }
    }
}
