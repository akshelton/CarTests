using Domain.Entities.Toyota;
using Domain.Enums;

namespace Domain.Repositories
{
    public interface IToyotaRepository : IVehicleRepository<ToyotaVehicle>
    {
        public Task<IEnumerable<ToyotaVehicle>> GetByModelAsync(string model);

        public Task<IEnumerable<ToyotaCorolla>> GetCorollas();

        public Task<IEnumerable<ToyotaGr86>> GetGr86s();

        public Task<IEnumerable<ToyotaTundra>> GetTundras();
    }
}
