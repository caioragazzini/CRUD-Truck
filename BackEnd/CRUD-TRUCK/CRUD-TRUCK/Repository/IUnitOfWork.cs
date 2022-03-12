using CRUD_TRUCK.Repository.TruckModelRepository;
using CRUD_TRUCK.Repository.TruckRepository;

namespace CRUD_TRUCK.Repository
{
    public interface IUnitOfWork
    {
        ITruckModelRepository TruckModelRepository { get; }
        ITruckRepository TruckRepository  { get; }
        void Commit();
        void Dispose();


    }
}
