using CRUD_TRUCK.Context;
using CRUD_TRUCK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_TRUCK.Repository.TruckRepository
{
    public class TruckRepository :Repository<Truck> , ITruckRepository
    {
        public TruckRepository(AppDbContext context) : base(context)
        {

        }
    }
}
