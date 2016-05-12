using EFCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFData
{
    public class UsuarioMap: EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            //Key
            HasKey(t => t.Usuario_Id);

            //Property
            Property(t => t.Usuario_Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.Nombre);
            Property(t => t.User);
            Property(t => t.Password);

            //table
            ToTable("Usuarios");
        }
    }
}
