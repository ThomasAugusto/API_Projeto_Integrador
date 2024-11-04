using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_Projeto_Integrador.Migrations
{
    /// <inheritdoc />
    public partial class PopulaUsuarios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Usuarios(Nome, Email, Senha)" +
                    "Values ('Admin', 'Admin@Teste.com.br', 'Admin123!')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Usuarios");
        }
    }
}
