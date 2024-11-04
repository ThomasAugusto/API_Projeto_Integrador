using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_Projeto_Integrador.Migrations
{
    /// <inheritdoc />
    public partial class PopulaTipoEmpreendimentos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into tipo_Empreendimentos (`Tipo`) " +
                    "Values ('Shopping')");
            mb.Sql("Insert into tipo_Empreendimentos (`Tipo`) " +
                    "Values ('Loja')");
            mb.Sql("Insert into tipo_Empreendimentos (`Tipo`) " +
                    "Values ('Faculdade')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from tipo_Empreendimentos");
        }
    }
}
