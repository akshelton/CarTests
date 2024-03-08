using Domain.Entities.Toyota;
using Domain.Enums;
using Domain.Repositories;

namespace Persistence.Repositories
{
    public class ToyotaRepository : IToyotaRepository
    {
        public Task<IEnumerable<ToyotaVehicle>> GetByModelAsync(string model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ToyotaCorolla>> GetCorollas()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ToyotaGr86>> GetGr86s()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ToyotaTundra>> GetTundras()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ToyotaVehicle>> GetByYearAsync(int year)
        {
            throw new NotImplementedException();
        }
    }
}
