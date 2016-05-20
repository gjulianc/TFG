using EFCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFG.Contrato;

namespace EFData
{
    class TransaccionMap: EntityTypeConfiguration<Transaccion>, IRepositoryTransacciones
    {
        protected EFDbContext ctx = new EFDbContext();

        public TransaccionMap()
        {
            HasKey(t => t.Transaccion_Id);

            //Property
            Property(t => t.Transaccion_Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.Fecha);
            Property(t => t.Litros);
            Property(t => t.Importe);
            Property(t => t.VehiculoID).IsRequired();
            Property(t => t.BaseID).IsRequired();
           

            //table
            ToTable("Transacciones");

            //relationship
            HasRequired(t => t.Vehiculo).WithMany(c => c.Transacciones).HasForeignKey(t => t.VehiculoID).WillCascadeOnDelete(false);
            HasRequired(t => t.Base).WithMany(c => c.Transacciones).HasForeignKey(t => t.BaseID).WillCascadeOnDelete(false);
        }

        public void DeleteTransaccion(Transaccion transaccion)
        {
            ctx.Set<Transaccion>().Remove(transaccion);
            GuardarDatos();
        }

        public List<Transaccion> GetAllTransacciones()
        {
            return ctx.Set<Transaccion>().ToList();
        }

        public Transaccion GetTransaccion(int id)
        {
            return ctx.Set<Transaccion>().Find(id);
        }

        public void GuardarDatos()
        {
            ctx.SaveChanges();
        }

        public void InsertarTransaccion(Transaccion transaccion)
        {
            ctx.Set<Transaccion>().Add(transaccion);
            this.GuardarDatos();
        }

    }
}
