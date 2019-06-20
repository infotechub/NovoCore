using Microsoft.EntityFrameworkCore.Migrations;

namespace NovoCore.Data.Migrations
{
    public partial class addmoreclasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Notification",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProviderId",
                table: "Notification",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "status",
                table: "Notification",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "status",
                table: "AuthorizationCode",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProviderId",
                table: "Notification");

            migrationBuilder.DropColumn(
                name: "status",
                table: "Notification");

            migrationBuilder.DropColumn(
                name: "status",
                table: "AuthorizationCode");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Notification",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
