using CRUD_TRUCK.Context;
using CRUD_TRUCK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_TRUCK.Repository.TruckModelRepository
{
    public class TruckModelBll :Repository<TruckModel>, ITruckModelBll
    {

        public TruckModelBll(AppDbContext context) : base(context)
        {

        }

    }
}
