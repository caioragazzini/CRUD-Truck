using CRUD_TRUCK.Context;
using CRUD_TRUCK.Repository.TruckModelRepository;
using CRUD_TRUCK.Repository.TruckRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_TRUCK.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private TruckModelBll _truckModelBll;
        private TruckBll _truckBll;

        public AppDbContext _appDbContext;

        public ITruckModelBll TruckModelBll { get { return _truckModelBll = _truckModelBll ?? new TruckModelBll(_appDbContext); } }

        public ITruckBll TruckBll { get { return _truckBll = _truckBll ?? new TruckBll(_appDbContext); } }

        public void Commit()
        {
            _appDbContext.SaveChanges();
        }

        public void Dispose()
        {
            _appDbContext.Dispose();
        }
    }
}
