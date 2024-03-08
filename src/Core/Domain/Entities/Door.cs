using Domain.Enums;

namespace Domain.Entities
{
    public class Door
    {
        public bool HasWindow { get; set; }

        public Window? Window { get; set; } = null;
        
        public bool HasLock { get; set; }

        public bool IsLocked { get; set; } = false;

        public DoorPosition Position { get; set; }

        public Door(DoorPosition position, bool hasWindow = true, bool hasLock = true, bool isLocked = false) {
            Position = position;
            HasWindow = hasWindow;
            Window = hasWindow ? new Window() : null;
            HasLock = hasLock;
            IsLocked = hasLock && isLocked;
        }
    }
}
