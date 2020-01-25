using EstacionamentoVeiculos.Infra.Entities;
using EstacionamentoVeiculos.Infra.Entities.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EstacionamentoVeiculos.Infra.Config
{
    class UsuarioConfig : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            var veiculoTeste = new Veiculo();
            builder.ToTable("Usuario");
            builder.HasKey(x => x.Id).HasName("Id_Usuario");
            builder.Property(x => x.Id).HasColumnName("Id");
            //builder.HasOne(x => x.Veiculo).WithOne(t => t.UsuarioFK).HasForeignKey<Veiculo>(t => t.UsuarioId);
            builder.HasOne(x => x.Veiculos).WithOne(u => u.);
        }
    }
}
