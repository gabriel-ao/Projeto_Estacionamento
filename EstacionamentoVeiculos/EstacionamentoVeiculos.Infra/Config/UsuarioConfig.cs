using EstacionamentoVeiculos.Infra.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstacionamentoVeiculos.Infra.Config
{
    class UsuarioConfig : IEntityTypeConfiguration<Usuario>
    {

        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuarios");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("Id");
        }
    }
}
