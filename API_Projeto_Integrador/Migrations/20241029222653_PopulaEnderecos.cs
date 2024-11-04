using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_Projeto_Integrador.Migrations
{
    /// <inheritdoc />
    public partial class PopulaEnderecos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Enderecos (Cidade, Estado, Logadrouro)" +
                    "Values ('Porto Alegre', 'RS', 'Av. Assis Brasil, 8450')");
            mb.Sql("Insert into Enderecos (Cidade, Estado, Logadrouro)" +
                    "Values ('Porto Alegre', 'RS', 'Rua Exemplo, 01')");
            mb.Sql("Insert into Enderecos (Cidade, Estado, Logadrouro)" +
                    "Values ('Porto Alegre', 'RS', 'Rua Exemplo, 02')");
            mb.Sql("Insert into Enderecos (Cidade, Estado, Logadrouro)" +
                    "Values ('Porto Alegre', 'RS', 'Rua Exemplo, 03')");
            mb.Sql("Insert into Enderecos (Cidade, Estado, Logadrouro)" +
                    "Values ('Porto Alegre', 'RS', 'Rua Exemplo, 04')");
            mb.Sql("Insert into Enderecos (Cidade, Estado, Logadrouro)" +
                    "Values ('Porto Alegre', 'RS', 'Rua Exemplo, 05')");
            mb.Sql("Insert into Enderecos (Cidade, Estado, Logadrouro)" +
                    "Values ('Porto Alegre', 'RS', 'Rua Exemplo, 06')");
            mb.Sql("Insert into Enderecos (Cidade, Estado, Logadrouro)" +
                    "Values ('Porto Alegre', 'RS', 'Rua Exemplo, 07')");
            mb.Sql("Insert into Enderecos (Cidade, Estado, Logadrouro)" +
                    "Values ('Porto Alegre', 'RS', 'Rua Exemplo, 08')");
            mb.Sql("Insert into Enderecos (Cidade, Estado, Logadrouro)" +
                    "Values ('Porto Alegre', 'RS', 'Rua Exemplo, 09')");
            mb.Sql("Insert into Enderecos (Cidade, Estado, Logadrouro)" +
                    "Values ('Porto Alegre', 'RS', 'Rua Exemplo, 10')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Enderecos");
        }
    }
}
