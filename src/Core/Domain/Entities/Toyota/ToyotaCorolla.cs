using Domain.Constants;
using Domain.Enums;

namespace Domain.Entities.Toyota
{
    public class ToyotaCorolla : ToyotaVehicle
    {
        public ToyotaCorolla(int year, bool hasSpareTire, DriverSide driverSide = DriverSide.Left) : base(ToyotaModels.Corolla, year, hasSpareTire, driverSide, true, true)
        {
            int frontPressure = GetTargetPressure(true);
            int backPressure = GetTargetPressure(false);
            SetTargetPressure(frontPressure, backPressure);

            SetWheels(hasSpareTire);
            SetDoors();
        }

        public override int GetTargetPressure(bool isFront)
        {
            return 32;
        }

        public override void SetWheels(bool hasSpareTire)
        {
            Wheels = new List<Wheel> { 
                new Wheel(FrontTireTargetPressure, WheelPosition.FrontLeft),
                new Wheel(FrontTireTargetPressure, WheelPosition.FrontRight),
                new Wheel(BackTireTargetPressure, WheelPosition.BackLeft),
                new Wheel(BackTireTargetPressure, WheelPosition.BackRight),
            };

            if (hasSpareTire)
            {
                var spareTire = new Wheel(FrontTireTargetPressure, WheelPosition.Spare);
                Wheels.Add(spareTire);
            }
        }

        public override void SetDoors()
        {
            Doors = new List<Door>
            {
                new Door(DoorPosition.FrontLeft),
                new Door(DoorPosition.FrontRight),
                new Door(DoorPosition.BackLeft),
                new Door(DoorPosition.BackRight)
            };
        }
    }
}
