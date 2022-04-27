using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Filmes.App.Dados
{
    public class ClienteConfiguration : PessoaConfiguration<Cliente>
    {
        public override void Configure(EntityTypeBuilder<Cliente> builder)
        {
            base.Configure(builder);

            builder.ToTable("client");

            builder.Property(c => c.Id).HasColumnName("client_id");

            builder.Property<DateTime>("create_date").
                HasColumnType("datetime").
                HasDefaultValueSql("getdate()")
                .IsRequired();


        }
    }
}
