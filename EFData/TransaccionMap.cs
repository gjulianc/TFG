using EFCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFData
{
    class TransaccionMap: EntityTypeConfiguration<Transaccion>
    {
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

    }
}
