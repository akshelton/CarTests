using Domain.Enums;
using Domain.Structs;

namespace Domain.Entities
{
    public abstract class Vehicle
    {
        public List<Wheel> Wheels { get; set; } = new List<Wheel>();

        public List<Door> Doors { get; set; } = new List<Door>();

        public Window? FrontWindow { get; set; } = null;

        public Window? BackWindow { get; set; } = null;

        public VehicleMake Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public int FrontTireTargetPressure { get; set; }

        public int BackTireTargetPressure { get; set; }

        public DriverSide DriverSide { get; set; }

        public Vehicle(VehicleMake make, string model, int year, DriverSide driverSide, bool hasFrontWindow = true, bool hasBackWindow = true) {
            Make = make;
            Model = model;
            Year = year;
            DriverSide = driverSide;

            if (hasFrontWindow)
            {
                FrontWindow = new Window();
            }

            if (hasBackWindow)
            {
                BackWindow = new Window();
            }
        }

        public abstract void SetWheels(bool hasSpareTire);

        public abstract void SetDoors();

        public abstract int GetTargetPressure(bool isFront);
        
        public void SetTargetPressure(int front, int back)
        {
            FrontTireTargetPressure = front;
            BackTireTargetPressure = back;
        }

        public List<TireStatus> CheckTires()
        {
            var tires = new List<TireStatus>();

            foreach(var wheel in Wheels)
            {
                var tire = new TireStatus
                {
                    Position = wheel.Position,
                    PressureStatus = wheel.GetTireStatus()
                };
                tires.Add(tire);
            }

            return tires;
        }

        public List<TireStatus> CheckTireAlerts()
        {
            var tires = new List<TireStatus>();

            foreach (var wheel in Wheels)
            {
                var status = wheel.GetTireStatus();
                
                if(status != TirePressureStatus.SafePressure)
                {
                    var tire = new TireStatus
                    {
                        Position = wheel.Position,
                        PressureStatus = status
                    };
                    tires.Add(tire);
                }                
            }

            return tires;
        }
    }
}
