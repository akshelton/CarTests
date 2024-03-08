using Domain.Enums;

namespace Domain.Entities
{
    public class Wheel
    {
        public int CurrentPressure { get; set; }

        public int TargetPressure { get; }

        public WheelPosition Position { get; set; }

        public bool IsSpare { get; set; } = false;

        public Wheel(int targetPressure, WheelPosition position)
        {
            TargetPressure = targetPressure;
            CurrentPressure = targetPressure;
            Position = position;
            if(position == WheelPosition.Spare)
            {
                IsSpare = true;
            }
        }

        public TirePressureStatus GetTireStatus()
        {
            var delta = (int) Math.Ceiling((decimal)  TargetPressure / 10);

            if (CurrentPressure <= (TargetPressure - (2 * delta)))
            {
                return TirePressureStatus.VeryLowPressure;
            }
            else if (CurrentPressure <= (TargetPressure - delta))
            {
                return TirePressureStatus.LowPressure;
            }
            else if (CurrentPressure >= (TargetPressure + (2 * delta)))
            {
                return TirePressureStatus.VeryHighPressure;
            }
            else if (CurrentPressure >= (TargetPressure + delta))
            {
                return TirePressureStatus.HighPressure;
            }

            return TirePressureStatus.SafePressure;
        }
    }
}
