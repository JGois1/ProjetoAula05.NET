using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoAula05.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula05.Mappings
{
    /// <summary>
    /// Classe de mapeamento para a entidade Funcionário
    /// </summary>
    public class FuncionarioMap : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            //nome da tabela no banco de dados
            builder.ToTable("FUNCIONARIO");

            //definir qual campo é a chave primária da tabela
            builder.HasKey(f => f.Id);

            //mapear o campo ID da tabela
            builder.Property(f => f.Id)
                .HasColumnName("ID"); //nome do campo

            //mapear o campo Nome da tabela
            builder.Property(f => f.Nome)
                .HasColumnName("NOME") //nome do campo
                .HasMaxLength(100) //varchar(100)
                .IsRequired(); //not null

            //mapear o campo Cpf da tabela
            builder.Property(f => f.Cpf)
                .HasColumnName("CPF") //nome do campo
                .HasMaxLength(11) //varchar(11)
                .IsRequired(); //not null

            //mapear o campo Data de Admissão da tabela
            builder.Property(f => f.DataAdmissao)
                .HasColumnName("DATAADMISSAO") //nome do campo
                .HasColumnType("date") //tipo do campo: date
                .IsRequired(); //not null

            //mapear o campo Tipo do Funcionário da tabela
            builder.Property(f => f.TipoFuncionario)
                .HasColumnName("TIPO") //nome do campo
                .IsRequired(); //not null
        }
    }
}



