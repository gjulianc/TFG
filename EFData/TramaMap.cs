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
    public class TramaMap: EntityTypeConfiguration<Trama>
    {
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
    }
}
