using EFCore;
using System.Collections.Generic;

namespace TFG.Contrato
{
    public interface IRepositoryTransacciones
    {
        List<Transaccion> GetAllTransacciones();
        Transaccion GetTransaccion(int id);
        void InsertarTransaccion(Transaccion transaccion);
        void DeleteTransaccion(Transaccion transaccion);
        void GuardarDatos();
    }
}
