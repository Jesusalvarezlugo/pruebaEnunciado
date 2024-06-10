using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaEnunciado.Dtos
{
    internal class VehiculoDto
    {
        long idVehiculo;
        string matricula = "aaaaa";
        string tipoVehiculo = "aaaaa";
        string zonaDestino = "aaaaa";
        string llevaMercancia ="aaaaa";
        DateTime fechaPasoControl= DateTime.Now;

        public long IdVehiculo { get => idVehiculo; set => idVehiculo = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public string TipoVehiculo { get => tipoVehiculo; set => tipoVehiculo = value; }
        public string ZonaDestino { get => zonaDestino; set => zonaDestino = value; }
        public string LlevaMercancia { get => llevaMercancia; set => llevaMercancia = value; }
        public DateTime FechaPasoControl { get => fechaPasoControl; set => fechaPasoControl = value; }
    }
}
