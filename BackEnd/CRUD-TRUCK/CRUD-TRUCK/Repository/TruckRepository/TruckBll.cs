using CRUD_TRUCK.Context;
using CRUD_TRUCK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_TRUCK.Repository.TruckRepository
{
    public class TruckBll :Repository<Truck> , ITruckBll
    {
        public TruckBll(AppDbContext context) : base(context)
        {

        }
    }
}
