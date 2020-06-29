using Microsoft.EntityFrameworkCore.Migrations;

namespace Authentication.Migrations.SqlServerMigration
{
    public partial class TableNewRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Desc",
                table: "Roles",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "RoleNews",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleNews", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoleNews");

            migrationBuilder.DropColumn(
                name: "Desc",
                table: "Roles");
        }
    }
}
