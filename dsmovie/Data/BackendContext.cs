using dsmovie.Entities;
using dsmovie.Repository.Mappings;
using Microsoft.EntityFrameworkCore;

namespace dsmovie.Data
{
    public class BackendContext : DbContext
    {
        public BackendContext(DbContextOptions<BackendContext> options) : base (options)
        {
                
        }
        public DbSet<Filme> DbFilmes { get; set; }
        public DbSet<Avaliacao> DbAvaliacaos { get; set; }
        public DbSet<Usuario> DbUsuarios { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FilmeMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
