using Microsoft.EntityFrameworkCore.Migrations;

namespace KonBase.Data.Migrations
{
    public partial class _3stMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CondominiumType",
                table: "Condominium",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CondominiumType",
                table: "Condominium",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
