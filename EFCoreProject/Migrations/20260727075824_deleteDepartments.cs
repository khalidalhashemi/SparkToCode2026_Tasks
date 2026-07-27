using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreProject.Migrations
{
    /// <inheritdoc />
    public partial class deleteDepartments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "departments");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "departments",
                columns: table => new
                {
                    departmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    departmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    departmentNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departments", x => x.departmentID);
                });
        }
    }
}
