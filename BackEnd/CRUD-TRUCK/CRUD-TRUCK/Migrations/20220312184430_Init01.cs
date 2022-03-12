using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUD_TRUCK.Migrations
{
    public partial class Init01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TruckModel",
                columns: table => new
                {
                    TruckModelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TruckModelType = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TruckModel", x => x.TruckModelId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Trucks",
                columns: table => new
                {
                    TruckId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NameTruck = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    YearOfManufacture = table.Column<int>(type: "int", nullable: false),
                    YearModel = table.Column<int>(type: "int", nullable: false),
                    TruckModelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trucks", x => x.TruckId);
                    table.ForeignKey(
                        name: "FK_Trucks_TruckModel_TruckModelId",
                        column: x => x.TruckModelId,
                        principalTable: "TruckModel",
                        principalColumn: "TruckModelId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Trucks_TruckModelId",
                table: "Trucks",
                column: "TruckModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trucks");

            migrationBuilder.DropTable(
                name: "TruckModel");
        }
    }
}
