using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_CommerceTask.Migrations
{
    /// <inheritdoc />
    public partial class SimulateRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_orderProducts",
                table: "orderProducts");

            migrationBuilder.DropColumn(
                name: "OrderProductID",
                table: "orderProducts");

            migrationBuilder.AddColumn<int>(
                name: "orderID",
                table: "reviews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "categoryID",
                table: "products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "userID",
                table: "orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_orderProducts",
                table: "orderProducts",
                columns: new[] { "productID", "orderID" });

            migrationBuilder.CreateTable(
                name: "OrderProduct",
                columns: table => new
                {
                    productsOFOrdersorderID = table.Column<int>(type: "int", nullable: false),
                    productsOrdersproductID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProduct", x => new { x.productsOFOrdersorderID, x.productsOrdersproductID });
                    table.ForeignKey(
                        name: "FK_OrderProduct_orders_productsOFOrdersorderID",
                        column: x => x.productsOFOrdersorderID,
                        principalTable: "orders",
                        principalColumn: "orderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProduct_products_productsOrdersproductID",
                        column: x => x.productsOrdersproductID,
                        principalTable: "products",
                        principalColumn: "productID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_reviews_orderID",
                table: "reviews",
                column: "orderID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_products_categoryID",
                table: "products",
                column: "categoryID");

            migrationBuilder.CreateIndex(
                name: "IX_orders_userID",
                table: "orders",
                column: "userID");

            migrationBuilder.CreateIndex(
                name: "IX_orderProducts_orderID",
                table: "orderProducts",
                column: "orderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_productsOrdersproductID",
                table: "OrderProduct",
                column: "productsOrdersproductID");

            migrationBuilder.AddForeignKey(
                name: "FK_orderProducts_orders_orderID",
                table: "orderProducts",
                column: "orderID",
                principalTable: "orders",
                principalColumn: "orderID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orderProducts_products_productID",
                table: "orderProducts",
                column: "productID",
                principalTable: "products",
                principalColumn: "productID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orders_users_userID",
                table: "orders",
                column: "userID",
                principalTable: "users",
                principalColumn: "userID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_products_categories_categoryID",
                table: "products",
                column: "categoryID",
                principalTable: "categories",
                principalColumn: "categoryID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_reviews_orders_orderID",
                table: "reviews",
                column: "orderID",
                principalTable: "orders",
                principalColumn: "orderID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orderProducts_orders_orderID",
                table: "orderProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_orderProducts_products_productID",
                table: "orderProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_orders_users_userID",
                table: "orders");

            migrationBuilder.DropForeignKey(
                name: "FK_products_categories_categoryID",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_reviews_orders_orderID",
                table: "reviews");

            migrationBuilder.DropTable(
                name: "OrderProduct");

            migrationBuilder.DropIndex(
                name: "IX_reviews_orderID",
                table: "reviews");

            migrationBuilder.DropIndex(
                name: "IX_products_categoryID",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_orders_userID",
                table: "orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_orderProducts",
                table: "orderProducts");

            migrationBuilder.DropIndex(
                name: "IX_orderProducts_orderID",
                table: "orderProducts");

            migrationBuilder.DropColumn(
                name: "orderID",
                table: "reviews");

            migrationBuilder.DropColumn(
                name: "categoryID",
                table: "products");

            migrationBuilder.DropColumn(
                name: "userID",
                table: "orders");

            migrationBuilder.AddColumn<int>(
                name: "OrderProductID",
                table: "orderProducts",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_orderProducts",
                table: "orderProducts",
                column: "OrderProductID");
        }
    }
}
