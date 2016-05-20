using EFCore;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using TFG.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EFData
{
    public class VehiculoMap: EntityTypeConfiguration<Vehiculo>, IRepositoryVehiculos
    {
        protected EFDbContext ctx = new EFDbContext();

        public VehiculoMap()
        {
            //Key
            HasKey(t => t.Vehiculo_Id);

            //Property
            Property(t => t.Vehiculo_Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.Matricula);
            Property(t => t.Marca);
            Property(t => t.Modelo);

            //table
            ToTable("Vehiculos");
        }

        public void DeleteVehiculo(Vehiculo vehiculo)
        {
            ctx.Set<Vehiculo>().Remove(vehiculo);
            GuardarDatos();
        }

        public List<Vehiculo> GetAllVehiculos()
        {
            return ctx.Set<Vehiculo>().ToList();
        }

        public Vehiculo GetVehiculo(int id)
        {
            return ctx.Set<Vehiculo>().Find(id);
        }

        public void GuardarDatos()
        {
            ctx.SaveChanges();
        }

        public void InsertarVehiculo(Vehiculo vehiculo)
        {
            ctx.Set<Vehiculo>().Add(vehiculo);
            this.GuardarDatos();
        }
    }
}
