using EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFG.Contrato
{
    public interface IRepositoryBases
    {
        List<Base> GetAllBases();
        Base GetBase(int id);
        void InsertarBase(Base _base);
        void DeleteBase(Base _base);
        void GuardarDatos();
    }
}
