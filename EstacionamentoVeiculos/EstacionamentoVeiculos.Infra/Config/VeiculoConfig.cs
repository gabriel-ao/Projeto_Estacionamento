using EstacionamentoVeiculos.Infra.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EstacionamentoVeiculos.Infra.Config
{
    public class VeiculoConfig : IEntityTypeConfiguration<Veiculo>
    {
        public void Configure(EntityTypeBuilder<Veiculo> builder)
        {
            builder.ToTable("Veiculo");
            builder.HasKey(x => x.Id).HasName("Id_Veiculo");
            builder.Property(x => x.Id).HasColumnName("Id");

            builder.HasOne(x => x.Usuario).WithMany(t => t.Veiculos).HasForeignKey(x => x.UsuarioId);
        }
    }
}
