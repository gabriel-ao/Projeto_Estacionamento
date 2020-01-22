using EstacionamentoVeiculos.Infra.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EstacionamentoVeiculos.Infra.Config
{
    class VeiculoConfig : IEntityTypeConfiguration<Veiculo>
    {
        public void Configure(EntityTypeBuilder<Veiculo> builder)
        {
            builder.ToTable("Veiculos");
            builder.HasKey(x => x.Id) ;
            builder.Property(x => x.Id).HasColumnName("Id");
        }
    }
}
