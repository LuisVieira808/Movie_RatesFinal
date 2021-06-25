using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieRates.Migrations
{
    public partial class AdicaoUserFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Icon",
                table: "Utilizadores");

            migrationBuilder.RenameColumn(
                name: "NickName",
                table: "Utilizadores",
                newName: "UserNameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserNameId",
                table: "Utilizadores",
                newName: "NickName");

            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "Utilizadores",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
