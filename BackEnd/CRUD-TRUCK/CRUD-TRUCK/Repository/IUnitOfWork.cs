using CRUD_TRUCK.Repository.TruckModelRepository;
using CRUD_TRUCK.Repository.TruckRepository;

namespace CRUD_TRUCK.Repository
{
    public interface IUnitOfWork
    {
        ITruckModelBll TruckModelBll { get; }
        ITruckBll TruckBll { get; }
        void Commit();
        void Dispose();


    }
}
