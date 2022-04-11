using dsmovie.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace dsmovie.Repository.Mappings
{
    public class AvaliacaoMap : IEntityTypeConfiguration<Avaliacao>
    {
        public void Configure(EntityTypeBuilder<Avaliacao> builder)
        {
            builder.ToTable("tb_score");
            builder.Property(x => x.IdFilme).HasColumnName("movie_id").HasColumnType("bigint");
            builder.Property(x => x.IdUsuario).HasColumnName("user_id").HasColumnType("bigint");
            builder.Property(x => x.Valor).HasColumnName("value").HasColumnType("float");
        }
    }
}
