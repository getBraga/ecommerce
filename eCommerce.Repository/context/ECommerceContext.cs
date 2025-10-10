using eCommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Repository.context
{
    public class ECommerceContext : DbContext
    {

        public ECommerceContext(DbContextOptions<ECommerceContext> options) : base(options)
        {


        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<EnderecoEntrega> EnderecosEntregas { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ECommerceContext).Assembly);


        }
    }
}
