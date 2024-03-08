using Domain.Enums;

namespace Domain.Structs
{
    public struct TireStatus
    {
        public WheelPosition Position { get; set; }

        public TirePressureStatus PressureStatus { get; set; }
    }
}
