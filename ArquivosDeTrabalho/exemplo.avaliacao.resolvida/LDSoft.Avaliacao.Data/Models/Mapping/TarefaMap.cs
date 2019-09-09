using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LDSoft.Avaliacao.Data.Models.Mapping
{
    public class TarefaMap : EntityTypeConfiguration<Tarefa>
    {
        public TarefaMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Titulo)
                .HasMaxLength(200);

            this.Property(t => t.Situacao)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("Tarefa");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.IdFuncionario).HasColumnName("IdFuncionario");
            this.Property(t => t.Titulo).HasColumnName("Titulo");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
            this.Property(t => t.Executada).HasColumnName("Executada");
            this.Property(t => t.Situacao).HasColumnName("Situacao");

            // Relationships
            this.HasRequired(t => t.Funcionario)
                .WithMany(t => t.Tarefas)
                .HasForeignKey(d => d.IdFuncionario);

        }
    }
}
