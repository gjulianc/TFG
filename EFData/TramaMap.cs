using EFCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using TFG.Contrato;

namespace EFData
{
    public class TramaMap: EntityTypeConfiguration<Trama>, IRepositoryTramas
    {
        protected EFDbContext ctx = new EFDbContext();

        public TramaMap()
        {

            HasKey(t => t.Trama_Id);

            //Property
            Property(t => t.Trama_Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.Fecha);
            Property(t => t.Imei);
            Property(t => t.Latitud);
            Property(t => t.VehiculoID).IsRequired();

            //table
            ToTable("Tramas");

            //relationship
            HasRequired(t => t.Vehiculo).WithMany(c => c.Tramas).HasForeignKey(t => t.VehiculoID).WillCascadeOnDelete(false);
            
        }

        public void DeleteTrama(Trama trama)
        {
            ctx.Set<Trama>().Remove(trama);
            GuardarDatos();
        }

        public List<Trama> GetAllTramas()
        {
            return ctx.Set<Trama>().ToList();
        }

        public Trama GetTrama(int id)
        {
            return ctx.Set<Trama>().Find(id);
        }

        public void GuardarDatos()
        {
            ctx.SaveChanges();
        }

        public void InsertarTrama(Trama trama)
        {
            ctx.Set<Trama>().Add(trama);
            this.GuardarDatos();
        }
    }
}
