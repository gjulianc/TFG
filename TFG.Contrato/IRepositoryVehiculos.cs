using EFCore;
using System.Collections.Generic;

namespace TFG.Contrato
{
    public interface IRepositoryVehiculos
    {
        List<Vehiculo> GetAllVehiculos();
        Vehiculo GetVehiculo(int id);
        void InsertarVehiculo(Vehiculo vehiculo);
        void DeleteVehiculo(Vehiculo vehiculo);
        void GuardarDatos();
    }
}
