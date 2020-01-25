using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeCrudRazor.Migrations
{
    public partial class emptable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phone2",
                table: "Employee");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Phone2",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
