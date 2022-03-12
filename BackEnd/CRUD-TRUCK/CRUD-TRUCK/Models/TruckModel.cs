using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_TRUCK.Models
{
    [Table("TruckModel")]
    public class TruckModel
    {
        public TruckModel()
        {
            Trucks = new Collection<Truck>();
        }

        [Key]
        public int TruckModelId { get; set; }

        [Required]
        [MaxLength(2)]
        public string TruckModelType { get; set; }

        public ICollection<Truck> Trucks { get; set; }

    }
}
