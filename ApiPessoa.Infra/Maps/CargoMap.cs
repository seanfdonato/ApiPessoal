using ApiPessoa.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ApiPessoa.Infra.Maps
{
    class CargoMap : IEntityTypeConfiguration<Cargo>
    {
        public void Configure(EntityTypeBuilder<Cargo> builder)
        {
            builder.ToTable("SiaiDp_Cargo");
            builder.HasKey(r => r.IdCargo);
            builder.Property(r => r.CodigoCargo);
            builder.Property(r => r.IdOrgao);
            builder.Property(r => r.AtribuicoesCargo);
            builder.Property(r => r.CargaHoraria).HasColumnType("tinyint");
            builder.Property(r => r.CargaHorariaVariavel).HasColumnType("tinyint");
            builder.Property(r => r.IdLegislacao);
            builder.Property(r => r.IdCarreira);
            builder.Property(r => r.LocalId);
            builder.Property(r => r.Ativo);
        }
    }
}
