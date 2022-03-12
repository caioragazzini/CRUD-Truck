using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_TRUCK.Models
{
    [Table("Trucks")]
    public class Truck
    {
        [Key]
        public int TruckId { get; set; }
        public string NameTruck { get; set; }
        public int YearOfManufacture { get; set; }
        public int YearModel { get; set; }
        public TruckModel TruckModels { get; set; }
        public int TruckModelId { get; set; }

    }
}
