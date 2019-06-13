using Microsoft.EntityFrameworkCore.Migrations;

namespace KonBase.Data.Migrations
{
    public partial class _2stMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Condominium",
                newName: "FantasyName");

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "Condominium",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "Condominium");

            migrationBuilder.RenameColumn(
                name: "FantasyName",
                table: "Condominium",
                newName: "Name");
        }
    }
}
