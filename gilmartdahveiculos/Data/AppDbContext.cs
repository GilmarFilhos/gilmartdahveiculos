using gilmartdahveiculos.Models;
using Microsoft.EntityFrameworkCore;

namespace gilmartdahveiculos.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Cor> Cores { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Modelo> Modelos { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Autor> Autor { get; set; }
        public DbSet<Orange> orange { get; set; }
        public DbSet<Clientes> Clientes {get; set;} 

    }
}
