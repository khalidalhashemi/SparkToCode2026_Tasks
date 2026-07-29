using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreProject.Migrations
{
    /// <inheritdoc />
    public partial class addTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "departmentID",
                table: "employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "superviseID",
                table: "employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "employeeID",
                table: "departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "dependents",
                columns: table => new
                {
                    dependentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dependentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    relationship = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    employeeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dependents", x => x.dependentId);
                    table.ForeignKey(
                        name: "FK_dependents_employees_employeeID",
                        column: x => x.employeeID,
                        principalTable: "employees",
                        principalColumn: "employeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "deplocations",
                columns: table => new
                {
                    departmentID = table.Column<int>(type: "int", nullable: false),
                    departmentLocation = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_deplocations", x => new { x.departmentID, x.departmentLocation });
                    table.ForeignKey(
                        name: "FK_deplocations_departments_departmentID",
                        column: x => x.departmentID,
                        principalTable: "departments",
                        principalColumn: "departmentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "projects",
                columns: table => new
                {
                    projectID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    projName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    projectLocation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projects", x => x.projectID);
                });

            migrationBuilder.CreateTable(
                name: "empProjs",
                columns: table => new
                {
                    employeeID = table.Column<int>(type: "int", nullable: false),
                    projectID = table.Column<int>(type: "int", nullable: false),
                    Hours = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empProjs", x => new { x.employeeID, x.projectID });
                    table.ForeignKey(
                        name: "FK_empProjs_employees_employeeID",
                        column: x => x.employeeID,
                        principalTable: "employees",
                        principalColumn: "employeeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_empProjs_projects_projectID",
                        column: x => x.projectID,
                        principalTable: "projects",
                        principalColumn: "projectID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_employees_departmentID",
                table: "employees",
                column: "departmentID");

            migrationBuilder.CreateIndex(
                name: "IX_employees_superviseID",
                table: "employees",
                column: "superviseID");

            migrationBuilder.CreateIndex(
                name: "IX_departments_employeeID",
                table: "departments",
                column: "employeeID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_dependents_employeeID",
                table: "dependents",
                column: "employeeID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_empProjs_projectID",
                table: "empProjs",
                column: "projectID");

            migrationBuilder.AddForeignKey(
                name: "FK_departments_employees_employeeID",
                table: "departments",
                column: "employeeID",
                principalTable: "employees",
                principalColumn: "employeeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_employeess_departments_departmentID",
                table: "employees",
                column: "departmentID",
                principalTable: "departments",
                principalColumn: "departmentID",
                onDelete: ReferentialAction.NoAction, onUpdate: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_employees_employees_superviseID",
                table: "employees",
                column: "superviseID",
                principalTable: "employees",
                principalColumn: "employeeID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_departments_employees_employeeID",
                table: "departments");

            migrationBuilder.DropForeignKey(
                name: "FK_employeess_departments_departmentID",
                table: "employees");

            migrationBuilder.DropForeignKey(
                name: "FK_employees_employees_superviseID",
                table: "employees");

            migrationBuilder.DropTable(
                name: "dependents");

            migrationBuilder.DropTable(
                name: "deplocations");

            migrationBuilder.DropTable(
                name: "empProjs");

            migrationBuilder.DropTable(
                name: "projects");

            migrationBuilder.DropIndex(
                name: "IX_employees_departmentID",
                table: "employees");

            migrationBuilder.DropIndex(
                name: "IX_employees_superviseID",
                table: "employees");

            migrationBuilder.DropIndex(
                name: "IX_departments_employeeID",
                table: "departments");

            migrationBuilder.DropColumn(
                name: "departmentID",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "superviseID",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "employeeID",
                table: "departments");
        }
    }
}
