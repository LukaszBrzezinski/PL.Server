using Microsoft.EntityFrameworkCore.Migrations;

namespace PL.Authorization.Infrastructure.Migrations
{
    public partial class ChangeUserAccountIsActiveType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                schema: "auth",
                table: "UserAccounts",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "IsActive",
                schema: "auth",
                table: "UserAccounts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "BIT");
        }
    }
}
