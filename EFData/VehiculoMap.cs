using EFCore;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFData
{
    public class VehiculoMap: EntityTypeConfiguration<Vehiculo>
    {
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
       
    }
}
