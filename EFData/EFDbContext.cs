using System.Data.Entity;

namespace EFData
{
    public class EFDbContext:DbContext
    {
        public EFDbContext()
            : base("name=DbConnectionString")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BaseMap());
            modelBuilder.Configurations.Add(new VehiculoMap());
            modelBuilder.Configurations.Add(new TransaccionMap());
            modelBuilder.Configurations.Add(new TramaMap());
            modelBuilder.Configurations.Add(new UsuarioMap());
        }  
    }
}
