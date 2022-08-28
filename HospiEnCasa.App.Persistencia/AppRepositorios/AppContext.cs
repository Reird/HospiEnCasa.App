using Microsoft.EntityFrameworkCore;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public class AppContext : DbContext 
    {
        public DbSet<Gato> Gatos {get;set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
    {
        if (!optionBuilder.IsConfigured)
        {
            optionBuilder
            .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = HospiEncasatData");
        }
    }    
    }

}
