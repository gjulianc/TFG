using EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFG.Contrato
{
    public interface IRepositoryTramas
    {
        List<Trama> GetAllTramas();
        Trama GetTrama(int id);
        void InsertarTrama(Trama trama);
        void DeleteTrama(Trama trama);
        void GuardarDatos();
    }
}
