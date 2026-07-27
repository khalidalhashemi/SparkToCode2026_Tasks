using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreProject.Migrations
{
    /// <inheritdoc />
    public partial class editNameColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "employeeName",
                table: "employees",
                newName: "empName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "empName",
                table: "employees",
                newName: "employeeName");
        }
    }
}
