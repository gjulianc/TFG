using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore
{
    public class Transaccion
    {
        public Int64 Transaccion_Id { get;set;}
        public DateTime Fecha { get; set; }
        public decimal Litros { get; set; }
        public decimal Importe { get; set; }
        public int VehiculoID { get; set; }
        public int BaseID { get; set; }
        public virtual Vehiculo Vehiculo { get; set; }
        public virtual Base Base { get; set; }
    }
}
