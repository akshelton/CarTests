using Domain.Enums;

namespace Domain.Entities.Toyota
{
    public abstract class ToyotaVehicle : Vehicle
    {
        protected ToyotaVehicle(string model, int year, bool hasSpareTire, DriverSide driverSide, bool hasFrontWindow = true, bool hasBackWindow = true) : base(VehicleMake.Toyota, model, year, driverSide, hasFrontWindow, hasBackWindow)
        {
        }

        public void LockDoors()
        {
            foreach (var door in Doors)
            {
                door.IsLocked = true;
            }
        }

        public void UnlockDoors()
        {
            foreach (var door in Doors)
            {
                door.IsLocked = false;
            }
        }

        public void UnlockDriverDoor()
        {
            Door driverDoor;

            if(DriverSide == DriverSide.Left)
            {
                driverDoor = Doors.Where(x => x.Position == DoorPosition.FrontLeft).First();
            } 
            else
            {
                driverDoor = Doors.Where(x => x.Position == DoorPosition.FrontRight).First();
            }

            driverDoor.IsLocked = false;
        }
    }
}
