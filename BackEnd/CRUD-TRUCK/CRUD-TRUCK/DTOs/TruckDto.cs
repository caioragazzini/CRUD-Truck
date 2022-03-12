using CRUD_TRUCK.Models;

namespace CRUD_TRUCK.DTOs
{
    public class TruckDto
    {
        public int TruckId { get; set; }
        public string NameTruck { get; set; }
        public int YearOfManufacture { get; set; }
        public int YearModel { get; set; }
        public TruckModel TruckModels { get; set; }
        public int TruckModelId { get; set; }
    }
}
