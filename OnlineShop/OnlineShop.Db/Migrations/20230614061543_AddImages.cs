using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineShop.Db.Migrations
{
    public partial class AddImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("28236799-1ded-45a8-a495-36e2b5821d11"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6f45b6de-c65f-4211-9538-db6941723879"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8a0de9e5-ad59-4484-8e38-057a98cbc982"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d66b2726-1dc5-43e8-95f3-41450133c719"));

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Image_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Cost", "Description", "Name" },
                values: new object[] { new Guid("c1ec07ab-6733-46e2-9cbc-6518cb0ca98e"), 3600m, "ИБП 50 кВт/ 50 кВа, 380В", "Алмаз5033" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Cost", "Description", "Name" },
                values: new object[] { new Guid("72165b8c-2ae5-4836-9a94-771b7cb32a38"), 1800m, "ИБП 10 кВт/ 10 кВа, 380В", "Топаз1033" });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "ProductId", "Url" },
                values: new object[] { new Guid("25ce7845-5b1f-41cc-9ff7-6ed56cbce7b7"), new Guid("c1ec07ab-6733-46e2-9cbc-6518cb0ca98e"), "/images/Products/image1.jpg" });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "ProductId", "Url" },
                values: new object[] { new Guid("25f334e6-9e67-4c3f-a562-91a5000f383e"), new Guid("72165b8c-2ae5-4836-9a94-771b7cb32a38"), "/images/Products/image2.jpg" });

            migrationBuilder.CreateIndex(
                name: "IX_Image_ProductId",
                table: "Image",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("72165b8c-2ae5-4836-9a94-771b7cb32a38"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c1ec07ab-6733-46e2-9cbc-6518cb0ca98e"));

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Cost", "Description", "ImagePath", "Name" },
                values: new object[,]
                {
                    { new Guid("6f45b6de-c65f-4211-9538-db6941723879"), 3600m, "ИБП 50 кВт/ 50 кВа, 380В", null, "Алмаз5033" },
                    { new Guid("28236799-1ded-45a8-a495-36e2b5821d11"), 1800m, "ИБП 10 кВт/ 10 кВа, 380В", null, "Топаз1033" },
                    { new Guid("d66b2726-1dc5-43e8-95f3-41450133c719"), 2500m, "ИБП 10 кВт/ 10 кВа, 220В", null, "Рубин1011" },
                    { new Guid("8a0de9e5-ad59-4484-8e38-057a98cbc982"), 7800m, "ИБП 30 кВт/ 28 кВа, 380В", null, "Гранит3033" }
                });
        }
    }
}
