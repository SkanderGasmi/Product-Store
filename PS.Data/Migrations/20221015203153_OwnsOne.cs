using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PS.Data.Migrations
{
    public partial class OwnsOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address_LabName",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Address_StreetAdress",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    ChemicalProductId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    LabName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetAdress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.ChemicalProductId);
                    table.ForeignKey(
                        name: "FK_Addresses_Products_ChemicalProductId",
                        column: x => x.ChemicalProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.AddColumn<string>(
                name: "Address_LabName",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address_StreetAdress",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
