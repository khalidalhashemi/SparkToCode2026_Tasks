using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreProject.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "departments",
                columns: table => new
                {
                    departmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    departmentNumber = table.Column<int>(type: "int", nullable: false),
                    departmentName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departments", x => x.departmentID);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    employeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    employeesSSN = table.Column<int>(type: "int", nullable: false),
                    employeeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    employeeAge = table.Column<int>(type: "int", nullable: false),
                    employeeSalary = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.employeeID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "departments");

            migrationBuilder.DropTable(
                name: "employees");
        }
    }
}
