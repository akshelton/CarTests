using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Toyota
{
    public class ToyotaGr86 : ToyotaVehicle
    {
        public const string Name = "GR86";

        public ToyotaGr86(int year, bool hasSpareTire, DriverSide driverSide = DriverSide.Left) : base(Name, year, hasSpareTire, driverSide, true, true)
        {
            int frontPressure = GetTargetPressure(true);
            int backPressure = GetTargetPressure(false);
            SetTargetPressure(frontPressure, backPressure);

            SetWheels(hasSpareTire);
            SetDoors();
        }

        public override int GetTargetPressure(bool isFront)
        {
            return isFront ? 32 : 35;
        }

        public override void SetDoors()
        {
            Doors = new List<Door>
            {
                new Door(DoorPosition.FrontLeft),
                new Door(DoorPosition.FrontRight)
            };
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
    }
}
