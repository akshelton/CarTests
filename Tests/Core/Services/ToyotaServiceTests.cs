using Domain.Repositories;
using Xunit;
using Moq;
using Services;
using Domain.Enums;

namespace Tests.Services
{
    public class ToyotaServiceTests
    {
        [Fact]
        public void CreateCorolla_Success()
        {
            // Arrange
            var mockRepo = new Mock<IToyotaRepository>();
            var service = new ToyotaService(mockRepo.Object);

            // Act
            var corolla = service.CreateCorolla(2022, false);
            var expectedWheelCount = 4;
            var expectedDoorCount = 4;

            // Assert
            Assert.Equal(expectedWheelCount, corolla.Wheels.Count);
            Assert.Equal(DriverSide.Left, corolla.DriverSide);

            corolla.LockDoors();
            Assert.Equal(expectedDoorCount, corolla.Doors.Count);
            foreach (var door in corolla.Doors)
            {
                Assert.True(door.IsLocked);
            }

            corolla.UnlockDriverDoor();
            foreach (var door in corolla.Doors)
            {
                if (corolla.DriverSide == DriverSide.Left && door.Position == DoorPosition.FrontLeft)
                {
                    Assert.False(door.IsLocked);
                }
                else if (corolla.DriverSide == DriverSide.Right && door.Position == DoorPosition.FrontRight)
                {
                    Assert.False(door.IsLocked);
                }
                else
                {
                    Assert.True(door.IsLocked);
                }
            }

            corolla.UnlockDoors();
            foreach (var door in corolla.Doors)
            {
                Assert.False(door.IsLocked);
            }

            var tireAlerts = corolla.CheckTireAlerts();
            Assert.Empty(tireAlerts);
        }

        [Fact]
        public void CreateCorolla_RightDrive_Success()
        {
            // Arrange
            var mockRepo = new Mock<IToyotaRepository>();
            var service = new ToyotaService(mockRepo.Object);

            // Act
            var corolla = service.CreateCorolla(2022, false, DriverSide.Right);
            var expectedWheelCount = 4;
            var expectedDoorCount = 4;

            // Assert
            Assert.Equal(expectedWheelCount, corolla.Wheels.Count);
            Assert.Equal(DriverSide.Right, corolla.DriverSide);

            corolla.LockDoors();
            Assert.Equal(expectedDoorCount, corolla.Doors.Count);
            foreach (var door in corolla.Doors)
            {
                Assert.True(door.IsLocked);
            }

            corolla.UnlockDriverDoor();
            foreach (var door in corolla.Doors)
            {
                if (corolla.DriverSide == DriverSide.Left && door.Position == DoorPosition.FrontLeft)
                {
                    Assert.False(door.IsLocked);
                }
                else if (corolla.DriverSide == DriverSide.Right && door.Position == DoorPosition.FrontRight)
                {
                    Assert.False(door.IsLocked);
                }
                else
                {
                    Assert.True(door.IsLocked);
                }
            }

            corolla.UnlockDoors();
            foreach (var door in corolla.Doors)
            {
                Assert.False(door.IsLocked);
            }

            var tireAlerts = corolla.CheckTireAlerts();
            Assert.Empty(tireAlerts);
        }

        [Fact]
        public void CreateGr86_Success()
        {
            // Arrange
            var mockRepo = new Mock<IToyotaRepository>();
            var service = new ToyotaService(mockRepo.Object);

            // Act
            var gr86 = service.CreateGr86(2022, false);
            var expectedWheelCount = 4;
            var expectedDoorCount = 2;

            // Assert
            Assert.Equal(expectedWheelCount, gr86.Wheels.Count);
            Assert.Equal(DriverSide.Left, gr86.DriverSide);

            gr86.LockDoors();
            Assert.Equal(expectedDoorCount, gr86.Doors.Count);
            foreach (var door in gr86.Doors)
            {
                Assert.True(door.IsLocked);
            }

            gr86.UnlockDriverDoor();
            foreach (var door in gr86.Doors)
            {
                if (gr86.DriverSide == DriverSide.Left && door.Position == DoorPosition.FrontLeft)
                {
                    Assert.False(door.IsLocked);
                }
                else if (gr86.DriverSide == DriverSide.Right && door.Position == DoorPosition.FrontRight)
                {
                    Assert.False(door.IsLocked);
                }
                else
                {
                    Assert.True(door.IsLocked);
                }
            }

            gr86.UnlockDoors();
            foreach (var door in gr86.Doors)
            {
                Assert.False(door.IsLocked);
            }

            var tireAlerts = gr86.CheckTireAlerts();
            Assert.Empty(tireAlerts);
        }

        [Fact]
        public void CreateGr86_RightDrive_Success()
        {
            // Arrange
            var mockRepo = new Mock<IToyotaRepository>();
            var service = new ToyotaService(mockRepo.Object);

            // Act
            var gr86 = service.CreateGr86(2022, false, DriverSide.Right);
            var expectedWheelCount = 4;
            var expectedDoorCount = 2;

            // Assert
            Assert.Equal(expectedWheelCount, gr86.Wheels.Count);
            Assert.Equal(DriverSide.Right, gr86.DriverSide);

            gr86.LockDoors();
            Assert.Equal(expectedDoorCount, gr86.Doors.Count);
            foreach (var door in gr86.Doors)
            {
                Assert.True(door.IsLocked);
            }

            gr86.UnlockDriverDoor();
            foreach (var door in gr86.Doors)
            {
                if (gr86.DriverSide == DriverSide.Left && door.Position == DoorPosition.FrontLeft)
                {
                    Assert.False(door.IsLocked);
                }
                else if (gr86.DriverSide == DriverSide.Right && door.Position == DoorPosition.FrontRight)
                {
                    Assert.False(door.IsLocked);
                }
                else
                {
                    Assert.True(door.IsLocked);
                }
            }

            gr86.UnlockDoors();
            foreach (var door in gr86.Doors)
            {
                Assert.False(door.IsLocked);
            }

            var tireAlerts = gr86.CheckTireAlerts();
            Assert.Empty(tireAlerts);
        }

        [Fact]
        public void CreateTundra_Success()
        {
            // Arrange
            var mockRepo = new Mock<IToyotaRepository>();
            var service = new ToyotaService(mockRepo.Object);

            // Act
            var tundra = service.CreateTundra(2022, false);
            var expectedWheelCount = 4;
            var expectedDoorCount = 4;

            // Assert
            Assert.Equal(expectedWheelCount, tundra.Wheels.Count);
            Assert.Equal(DriverSide.Left, tundra.DriverSide);

            tundra.LockDoors();
            Assert.Equal(expectedDoorCount, tundra.Doors.Count);
            foreach (var door in tundra.Doors)
            {
                Assert.True(door.IsLocked);
            }

            tundra.UnlockDriverDoor();
            foreach (var door in tundra.Doors)
            {
                if (tundra.DriverSide == DriverSide.Left && door.Position == DoorPosition.FrontLeft)
                {
                    Assert.False(door.IsLocked);
                }
                else if (tundra.DriverSide == DriverSide.Right && door.Position == DoorPosition.FrontRight)
                {
                    Assert.False(door.IsLocked);
                }
                else
                {
                    Assert.True(door.IsLocked);
                }
            }

            tundra.UnlockDoors();
            foreach (var door in tundra.Doors)
            {
                Assert.False(door.IsLocked);
            }

            var tireAlerts = tundra.CheckTireAlerts();
            Assert.Empty(tireAlerts);
        }

        [Fact]
        public void CreateTundra_RightDrive_Success()
        {
            // Arrange
            var mockRepo = new Mock<IToyotaRepository>();
            var service = new ToyotaService(mockRepo.Object);

            // Act
            var tundra = service.CreateTundra(2022, false, DriverSide.Right);
            var expectedWheelCount = 4;
            var expectedDoorCount = 4;

            // Assert
            Assert.Equal(expectedWheelCount, tundra.Wheels.Count);
            Assert.Equal(DriverSide.Right, tundra.DriverSide);

            tundra.LockDoors();
            Assert.Equal(expectedDoorCount, tundra.Doors.Count);
            foreach (var door in tundra.Doors)
            {
                Assert.True(door.IsLocked);
            }

            tundra.UnlockDriverDoor();
            foreach (var door in tundra.Doors)
            {
                if (tundra.DriverSide == DriverSide.Left && door.Position == DoorPosition.FrontLeft)
                {
                    Assert.False(door.IsLocked);
                }
                else if (tundra.DriverSide == DriverSide.Right && door.Position == DoorPosition.FrontRight)
                {
                    Assert.False(door.IsLocked);
                }
                else
                {
                    Assert.True(door.IsLocked);
                }
            }

            tundra.UnlockDoors();
            foreach (var door in tundra.Doors)
            {
                Assert.False(door.IsLocked);
            }

            var tireAlerts = tundra.CheckTireAlerts();
            Assert.Empty(tireAlerts);
        }
    }
}