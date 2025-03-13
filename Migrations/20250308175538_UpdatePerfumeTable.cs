using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ecommercestore.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePerfumeTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_orderid",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Perfumes_perfumeid",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_userid",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Perfumes_Categories_categoryid",
                table: "Perfumes");

            migrationBuilder.DropIndex(
                name: "IX_Perfumes_categoryid",
                table: "Perfumes");

            migrationBuilder.DropIndex(
                name: "IX_Orders_userid",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_orderid",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_perfumeid",
                table: "OrderItems");

            migrationBuilder.AddColumn<string>(
                name: "categoryname",
                table: "Perfumes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "categoryname",
                table: "Perfumes");

            migrationBuilder.CreateIndex(
                name: "IX_Perfumes_categoryid",
                table: "Perfumes",
                column: "categoryid");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_userid",
                table: "Orders",
                column: "userid");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_orderid",
                table: "OrderItems",
                column: "orderid");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_perfumeid",
                table: "OrderItems",
                column: "perfumeid");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_orderid",
                table: "OrderItems",
                column: "orderid",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Perfumes_perfumeid",
                table: "OrderItems",
                column: "perfumeid",
                principalTable: "Perfumes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_userid",
                table: "Orders",
                column: "userid",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Perfumes_Categories_categoryid",
                table: "Perfumes",
                column: "categoryid",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
