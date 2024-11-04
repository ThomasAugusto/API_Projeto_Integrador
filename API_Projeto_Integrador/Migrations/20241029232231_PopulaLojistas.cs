using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_Projeto_Integrador.Migrations
{
    /// <inheritdoc />
    public partial class PopulaLojistas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Lojistas(Nome, EmpreendimentoId)" +
                    "Values ('Cantina', 1)");
            mb.Sql("Insert into Lojistas(Nome, EmpreendimentoId)" +
                    "Values ('Laboratório 01', 1)");
            mb.Sql("Insert into Lojistas(Nome, EmpreendimentoId)" +
                    "Values ('Laboratório 02', 1)");
            mb.Sql("Insert into Lojistas(Nome, EmpreendimentoId)" +
                    "Values ('Sala 110', 1)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Lojistas");
        }
    }
}
