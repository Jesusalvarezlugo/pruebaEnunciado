using PruebaEnunciado.Controladores;
using PruebaEnunciado.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaEnunciado.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public void controlDeVehiculos()
        {
            VehiculoDto vehiculo = new VehiculoDto();
            if (vehiculo.TipoVehiculo == "P")
            {
                vehiculo.ZonaDestino ="Oeste";
                vehiculo.FechaPasoControl=DateTime.Now;
            }else if (vehiculo.TipoVehiculo=="F"||vehiculo.TipoVehiculo=="A")
            {
                vehiculo.ZonaDestino = "PIF";
                vehiculo.FechaPasoControl = DateTime.Now;

                string respuesta = "";
                Console.WriteLine("¿El vehiculo es apto?(s/n)");
                respuesta= Console.ReadLine();

                if (respuesta == "s")
                {
                    vehiculo.ZonaDestino = "Norte";
                }
                else
                {
                    vehiculo.ZonaDestino = "Sur";
                }


            }
        }

        public void InformacionVehiculo()
        {
            VehiculoDto vehiculo=new VehiculoDto();

            Console.WriteLine("Introduce la matricula del vehiculo: ");
            vehiculo.Matricula = Console.ReadLine();
            Console.WriteLine("Introduce que tipo de vehiculo es:(P,F o A) ");
            vehiculo.TipoVehiculo = Console.ReadLine();
            Console.WriteLine("¿Lleva mercancia?(s/n)");
            vehiculo.LlevaMercancia=Console.ReadLine();

            Program.listaVehiculos.Add(vehiculo);
        }
    }
}
