using dsmovie.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace dsmovie.Repository.Mappings
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("tb_user");
            builder.Property(x => x.Id).HasColumnName("id").HasColumnType("bigint");
            builder.Property(x => x.Email).HasColumnName("email").HasColumnType("varchar(255)");
        }
    }
}
