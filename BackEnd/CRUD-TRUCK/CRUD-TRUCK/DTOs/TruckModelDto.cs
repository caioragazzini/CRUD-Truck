using CRUD_TRUCK.Models;
using System.Collections.Generic;

namespace CRUD_TRUCK.DTOs
{
    public class TruckModelDto
    {
        public int TruckModelId { get; set; }               
        public string TruckModelType { get; set; }
        public ICollection<TruckDto> Trucks { get; set; }
    }
}
