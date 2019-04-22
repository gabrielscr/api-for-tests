using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations
{
    public partial class AdicionaUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Salary",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "isMarried",
                table: "Person");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Person",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Person",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Person");

            migrationBuilder.AddColumn<double>(
                name: "Salary",
                table: "Person",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<bool>(
                name: "isMarried",
                table: "Person",
                nullable: true);
        }
    }
}
