using CursoEFCore.Data.Configurations;
using CursoEFCore.Domain;
using Microsoft.EntityFrameworkCore;

namespace CursoEFCore.Data
{
     public class ApplicationContext : DbContext
     {
         public DbSet<Pedido> Pedidos { get; set;}

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
             optionsBuilder.UseSqlServer("Data source=(localdb)\\mssqlocaldb;Initial Catalog=CursoEFCore;Integrated Security=true");
         }

         protected override void OnModelCreating(ModelBuilder modelBuilder)
         {
             modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);
         }
     }
}