using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore
{
    public class Trama
    {
        public Int64 Trama_Id { get; set; }
        public string Imei { get; set; }
        public DateTime Fecha { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public decimal Velocidad { get; set; }
        public decimal Rumbo { get; set; }
        public decimal Distancia { get; set; }
        public int VehiculoID { get; set; }

        public virtual Vehiculo Vehiculo { get; set; }
    }
}
