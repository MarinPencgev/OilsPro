using Microsoft.EntityFrameworkCore.Migrations;

namespace OilsPro.Web.Migrations
{
    public partial class fixProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProductCode",
                table: "Products",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProductCode",
                table: "Products",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 8);
        }
    }
}
