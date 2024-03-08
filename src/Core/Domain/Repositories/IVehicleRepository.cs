using Domain.Entities;

namespace Domain.Repositories
{
    public interface IVehicleRepository<T> where T : Vehicle
    {
        public Task<IEnumerable<T>> GetByYearAsync(int year);

    }
}
