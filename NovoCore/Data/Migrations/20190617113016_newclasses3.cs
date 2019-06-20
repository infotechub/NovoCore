using Microsoft.EntityFrameworkCore.Migrations;

namespace NovoCore.Data.Migrations
{
    public partial class newclasses3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Policynumber",
                table: "Enrollee",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Policynumber",
                table: "Enrollee",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 450,
                oldNullable: true);
        }
    }
}
