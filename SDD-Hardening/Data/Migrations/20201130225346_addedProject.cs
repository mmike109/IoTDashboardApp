using Microsoft.EntityFrameworkCore.Migrations;

namespace SDD_Hardening.Data.Migrations
{
    public partial class addedProject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    project_name = table.Column<string>(unicode: false, maxLength: 80, nullable: true),
                    controller_name = table.Column<string>(unicode: false, maxLength: 80, nullable: true),
                    show_on_dashboard = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Project");
        }
    }
}
