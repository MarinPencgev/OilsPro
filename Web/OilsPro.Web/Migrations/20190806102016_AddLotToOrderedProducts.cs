using Microsoft.EntityFrameworkCore.Migrations;

namespace OilsPro.Web.Migrations
{
    public partial class AddLotToOrderedProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LotId",
                table: "OrderedProducts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderedProducts_LotId",
                table: "OrderedProducts",
                column: "LotId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderedProducts_Lots_LotId",
                table: "OrderedProducts",
                column: "LotId",
                principalTable: "Lots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderedProducts_Lots_LotId",
                table: "OrderedProducts");

            migrationBuilder.DropIndex(
                name: "IX_OrderedProducts_LotId",
                table: "OrderedProducts");

            migrationBuilder.DropColumn(
                name: "LotId",
                table: "OrderedProducts");
        }
    }
}
