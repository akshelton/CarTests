using Domain.Enums;
using Domain.Entities;
using Xunit;

namespace EntityTests
{
    public class WheelTests
    {
        [Fact]
        public void CreateWheel_GetTireStatus_SafePressure()
        {
            // Arrange
            var wheel = new Wheel(50, WheelPosition.Front);
            var expectedStatus = TirePressureStatus.SafePressure;

            // Act
            var actualStatus = wheel.GetTireStatus();

            // Assert
            Assert.False(wheel.IsSpare);
            Assert.Equal(expectedStatus, actualStatus);
        }

        [Fact]
        public void CreateWheel_GetTireStatus_VeryLowPressure()
        {
            // Arrange
            var wheel = new Wheel(50, WheelPosition.Front);
            var expectedStatus = TirePressureStatus.VeryLowPressure;

            // Act
            wheel.CurrentPressure -= 11;

            var actualStatus = wheel.GetTireStatus();

            // Assert
            Assert.Equal(expectedStatus, actualStatus);
        }

        [Fact]
        public void CreateWheel_GetTireStatus_LowPressure()
        {
            // Arrange
            var wheel = new Wheel(50, WheelPosition.Front);
            var expectedStatus = TirePressureStatus.LowPressure;

            // Act
            wheel.CurrentPressure -= 6;

            var actualStatus = wheel.GetTireStatus();

            // Assert
            Assert.Equal(expectedStatus, actualStatus);
        }

        [Fact]
        public void CreateWheel_GetTireStatus_VeryHighPressure()
        {
            // Arrange
            var wheel = new Wheel(50, WheelPosition.Front);
            var expectedStatus = TirePressureStatus.VeryHighPressure;

            // Act
            wheel.CurrentPressure += 11;

            var actualStatus = wheel.GetTireStatus();

            // Assert
            Assert.Equal(expectedStatus, actualStatus);
        }

        [Fact]
        public void CreateWheel_GetTireStatus_HighPressure()
        {
            // Arrange
            var wheel = new Wheel(50, WheelPosition.Front);
            var expectedStatus = TirePressureStatus.HighPressure;

            // Act
            wheel.CurrentPressure += 6;

            var actualStatus = wheel.GetTireStatus();

            // Assert
            Assert.Equal(expectedStatus, actualStatus);
        }
    }
}