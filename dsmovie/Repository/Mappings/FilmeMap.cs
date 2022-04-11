using dsmovie.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace dsmovie.Repository.Mappings
{
    public class FilmeMap : IEntityTypeConfiguration<Filme>
    {
        public void Configure(EntityTypeBuilder<Filme> builder)
        {
            //configuração da entidade filme para o banco relacional
            builder.ToTable("tb_movie");
            builder.Property(x => x.Id).HasColumnName("id").HasColumnType("bigint");
            builder.Property(x => x.Count).HasColumnName("count").HasColumnType("smallint");
            builder.Property(x => x.Image).HasColumnName("image").HasColumnType("varchar(255)");
            builder.Property(x => x.Score).HasColumnName("score").HasColumnType("float");
            builder.Property(x => x.Title).HasColumnName("title").HasColumnType("varchar(255)");
        }
    }
}
