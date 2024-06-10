using PruebaEnunciado.Dtos;
using PruebaEnunciado.Servicios;

namespace PruebaEnunciado.Controladores
{

    class Program
    {
        public static List<VehiculoDto> listaVehiculos = new List<VehiculoDto>();
        public static void Main(string[] args)
        {
            OperativaInterfaz oi = new OperativaImplementacion();


            oi.InformacionVehiculo();
        }
    }
}
