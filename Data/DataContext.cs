using API_TesteRegistro.Models;
using Microsoft.EntityFrameworkCore;

namespace API_TesteRegistro.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Hospede> Hospedes { get; set;}
        public DbSet<Funcionario> Funcionarios { get; set;}
        public DbSet<Reserva> Reservas { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //TO DO: aplicar mapeamento das propriedades
        }
    }
}
