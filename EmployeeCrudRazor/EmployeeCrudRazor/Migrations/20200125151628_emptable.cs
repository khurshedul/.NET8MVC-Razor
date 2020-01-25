using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeCrudRazor.Migrations
{
    public partial class emptable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Phone2",
                table: "Employee",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phone2",
                table: "Employee");
        }
    }
}
