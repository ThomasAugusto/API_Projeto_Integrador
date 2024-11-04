using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_Projeto_Integrador.Migrations
{
    /// <inheritdoc />
    public partial class PopulaEmpreendimentos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Empreendimentos (Nome, Tipo_EmpreendimentoID, EnderecoID)" +
                    "Values ('FATEC - SENAI', 3, 1)");
            mb.Sql("Insert into Empreendimentos (Nome, Tipo_EmpreendimentoID, EnderecoID)" +
                    "Values ('Shopping 01', 1, 2)");
            mb.Sql("Insert into Empreendimentos (Nome, Tipo_EmpreendimentoID, EnderecoID)" +
                    "Values ('Shopping 02', 1, 3)");
            mb.Sql("Insert into Empreendimentos (Nome, Tipo_EmpreendimentoID, EnderecoID)" +
                    "Values ('Shopping 03', 1, 4)");
            mb.Sql("Insert into Empreendimentos (Nome, Tipo_EmpreendimentoID, EnderecoID)" +
                    "Values ('Shopping 04', 1, 5)");
            mb.Sql("Insert into Empreendimentos (Nome, Tipo_EmpreendimentoID, EnderecoID)" +
                    "Values ('Shopping 05', 1, 6)");
            mb.Sql("Insert into Empreendimentos (Nome, Tipo_EmpreendimentoID, EnderecoID)" +
                    "Values ('Shopping 06', 1, 7)");
            mb.Sql("Insert into Empreendimentos (Nome, Tipo_EmpreendimentoID, EnderecoID)" +
                    "Values ('Loja 01', 2, 8)");
            mb.Sql("Insert into Empreendimentos (Nome, Tipo_EmpreendimentoID, EnderecoID)" +
                    "Values ('Loja 02', 2, 9)");
            mb.Sql("Insert into Empreendimentos (Nome, Tipo_EmpreendimentoID, EnderecoID)" +
                    "Values ('Loja 03', 2, 10)");
            mb.Sql("Insert into Empreendimentos (Nome, Tipo_EmpreendimentoID, EnderecoID)" +
                    "Values ('Loja 04', 2, 11)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Empreendimentos");
        }
    }
}
