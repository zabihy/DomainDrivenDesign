using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Session01.Data.EF.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Goods",
                columns: table => new
                {
                    GoodId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goods", x => x.GoodId);
                });

            migrationBuilder.CreateTable(
                name: "SalesMen",
                columns: table => new
                {
                    SalesmanId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesMen", x => x.SalesmanId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GoodId1 = table.Column<int>(nullable: true),
                    SalesmanId1 = table.Column<int>(nullable: true),
                    CustomerId1 = table.Column<int>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    TotalPrice = table.Column<int>(nullable: false),
                    GoodId = table.Column<long>(nullable: false),
                    CustomerId = table.Column<long>(nullable: false),
                    SalesmanId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId1",
                        column: x => x.CustomerId1,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Goods_GoodId1",
                        column: x => x.GoodId1,
                        principalTable: "Goods",
                        principalColumn: "GoodId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_SalesMen_SalesmanId1",
                        column: x => x.SalesmanId1,
                        principalTable: "SalesMen",
                        principalColumn: "SalesmanId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId1",
                table: "Orders",
                column: "CustomerId1");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_GoodId1",
                table: "Orders",
                column: "GoodId1");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_SalesmanId1",
                table: "Orders",
                column: "SalesmanId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Goods");

            migrationBuilder.DropTable(
                name: "SalesMen");
        }
    }
}
