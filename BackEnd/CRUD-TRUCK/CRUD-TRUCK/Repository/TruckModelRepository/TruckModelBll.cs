using CRUD_TRUCK.Context;
using CRUD_TRUCK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_TRUCK.Repository.TruckModelRepository
{
    public class TruckModelRepository :Repository<TruckModel>, ITruckModelRepository
    {

        public TruckModelRepository(AppDbContext context) : base(context)
        {

        }

    }
}
