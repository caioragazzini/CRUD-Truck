using CRUD_TRUCK.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_TRUCK.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Truck> Trucks { get; set; }
        public DbSet<TruckModel> TruckModels { get; set; }
    }
}
