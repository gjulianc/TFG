using EFCore;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFData
{
    public class BaseMap:EntityTypeConfiguration<Base>
    {
        
        public BaseMap()
        {
            //Key
            HasKey(t => t.Base_Id);

            //Property
            Property(t => t.Base_Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.Descripcion);
            Property(t => t.Latitud);
            Property(t => t.Longitud);

            //table
            ToTable("Bases");
        }
    }
}
