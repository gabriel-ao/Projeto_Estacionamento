using EstacionamentoVeiculos.Infra.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EstacionamentoVeiculos.Infra.Config
{
    class UsuarioConfig : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");
            builder.HasKey(x => x.Id).HasName("Id");
            builder.Property(x => x.Id).HasColumnName("Id");
        }
    }
}
