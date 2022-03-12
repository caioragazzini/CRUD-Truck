using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUD_TRUCK.Migrations
{
    public partial class Populadb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into truckmodel(TruckModelType) Values('FH')");
            migrationBuilder.Sql("Insert into truckmodel(TruckModelType) Values('FM')");

            migrationBuilder.Sql("Insert into trucks(NameTruck, YearOfManufacture, YearModel, TruckModelId) " +
                    "Values('Volvo', Year(now()),Year(now()),(Select TruckModelId from truckmodel where TruckModelType='FH'))");

            migrationBuilder.Sql("Insert into trucks(NameTruck, YearOfManufacture, YearModel, TruckModelId) " +
                   "Values('Volvo', Year(now()),Year(now()),(Select TruckModelId from truckmodel where TruckModelType='FM'))");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from truckmodel");
            migrationBuilder.Sql("Delete from trucks");
        }
    }
}
