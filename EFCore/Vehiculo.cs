using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore
{
    public class Vehiculo
    {
        public int Vehiculo_Id { get; set; }
        public string Matricula { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public virtual ICollection<Transaccion> Transacciones { get; set; }
        public virtual ICollection<Trama> Tramas { get; set; }
    }
}
