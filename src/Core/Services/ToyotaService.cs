using Services.Abstractions;
using Domain.Entities.Toyota;
using Domain.Repositories;
using Domain.Enums;

namespace Services
{
    public class ToyotaService: IVehicleService
    {
        private readonly IToyotaRepository _repo;
        public ToyotaService(IToyotaRepository repo) {
            _repo = repo;
        }

        public ToyotaCorolla CreateCorolla(int year, bool hasSpareTire, DriverSide driverSide = DriverSide.Left) {
            return new ToyotaCorolla(year, hasSpareTire, driverSide);
        }

        public ToyotaGr86 CreateGr86(int year, bool hasSpareTire, DriverSide driverSide = DriverSide.Left)
        {
            return new ToyotaGr86(year, hasSpareTire, driverSide);
        }

        public ToyotaTundra CreateTundra(int year, bool hasSpareTire, DriverSide driverSide = DriverSide.Left)
        {
            return new ToyotaTundra(year, hasSpareTire, driverSide);
        }

        public async Task<IEnumerable<ToyotaCorolla>> GetCorollas() {
            return await _repo.GetCorollas();
        }

        public async Task<IEnumerable<ToyotaGr86>> GetGr86s()
        {
            return await _repo.GetGr86s();
        }

        public async Task<IEnumerable<ToyotaTundra>> GetTundras()
        {
            return await _repo.GetTundras();
        }

        public async Task<IEnumerable<ToyotaVehicle>> GetByYear(int year)
        {
            return await _repo.GetByYearAsync(year);
        }
    }
}
