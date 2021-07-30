using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartSchool.Dominio.Alunos;

namespace SmartSchool.Dados.Modulos.Usuarios
{
	public class AlunoMapeamento : IEntityTypeConfiguration<Aluno>
	{
		public void Configure(EntityTypeBuilder<Aluno> builder)
		{
			builder.ToTable("ALUNO");

			builder.Property(b => b.ID)
					.HasColumnName("USUA_ID_USUARIO")
					.ValueGeneratedNever()
					.IsRequired();

			builder.Property(b => b.Ativo)
				   .HasColumnName("USUA_IN_ATIVO")
				   .IsRequired();

			builder.Property(b => b.Nome)
					.HasColumnName("USUA_NM_NOME")
					.HasMaxLength(32)
					.IsRequired();

			builder.Property(b => b.Sobrenome)
					.HasColumnName("USUA_NM_SOBRENOME")
					.HasMaxLength(128)
					.IsRequired();

			builder.Property(b => b.DataNascimento)
					.HasColumnName("USUA_DT_NASCIMENTO")
					.IsRequired();

			builder.Property(b => b.Telefone)
					.HasColumnName("USUA_NR_TELEFONE")
					.HasMaxLength(16);		   
		}
	}
}
