using CourierLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CourierTests
{
    [TestClass]
    public class ShippingServiceTests
    {
        //1,3,6,10
        [TestMethod]
        public void CalculateTotalCost_SmallParcel_WithinWeightLimit_ReturnsCorrectCost()
        {
            // Arrange
            Parcel parcel = new Parcel(5, 5, 5, 1); // Small parcel within weight limit
            ShippingService service = new ShippingService(parcel, false);

            // Act
            double totalCost = service.ShippingServiceTotalCost();

            // Assert
            Assert.AreEqual(3.0, totalCost);
        }

        [TestMethod]
        public void CalculateTotalCost_SmallParcel_ExceedsWeightLimit_ReturnsCorrectCost()
        {
            // Arrange
            Parcel parcel = new Parcel(5, 5, 5, 2); // Small parcel exceeds weight limit
            ShippingService service = new ShippingService(parcel, false);
            // Act
            double totalCost = service.ShippingServiceTotalCost();

            // Assert
            Assert.AreEqual(5.0, totalCost);
        }

        [TestMethod]
        public void CalculateTotalCost_MediumParcel_WithinWeightLimit_ReturnsCorrectCost()
        {
            // Arrange
            Parcel parcel = new Parcel(20, 20, 20, 2); // Medium parcel within weight limit
            ShippingService service = new ShippingService(parcel, false);
            // Act
            double totalCost = service.ShippingServiceTotalCost();

            // Assert
            Assert.AreEqual(8.0, totalCost);
        }

        [TestMethod]
        public void CalculateTotalCost_MediumParcel_ExceedsWeightLimit_ReturnsCorrectCost()
        {
            // Arrange
            Parcel parcel = new Parcel(20, 20, 20, 4.5); // Medium parcel exceeds weight limit
            ShippingService service = new ShippingService(parcel, false);
            // Act
            double totalCost = service.ShippingServiceTotalCost();

            // Assert
            Assert.AreEqual(11.0, totalCost);
        }

        [TestMethod]
        public void CalculateTotalCost_LargeParcel_WithinWeightLimit_ReturnsCorrectCost()
        {
            // Arrange
            Parcel parcel = new Parcel(80, 80, 80, 6); // Large parcel within weight limit
            ShippingService service = new ShippingService(parcel, false);

            // Act
            double totalCost = service.ShippingServiceTotalCost();

            // Assert
            Assert.AreEqual(15.0, totalCost);
        }

        [TestMethod]
        public void CalculateTotalCost_LargeParcel_ExceedsWeightLimit_ReturnsCorrectCost()
        {
            // Arrange
            Parcel parcel = new Parcel(80, 80, 80, 7); // Large parcel exceeds weight limit
            ShippingService service = new ShippingService(parcel, false);
            // Act
            double totalCost = service.ShippingServiceTotalCost();

            // Assert
            Assert.AreEqual(17.0, totalCost);
        }

        [TestMethod]
        public void CalculateTotalCost_XLParcel_WithinWeightLimit_ReturnsCorrectCost()
        {
            // Arrange
            Parcel parcel = new Parcel(120, 120, 120, 9); // XL parcel within weight limit
            ShippingService service = new ShippingService(parcel, false);

            // Act
            double totalCost = service.ShippingServiceTotalCost();

            // Assert
            Assert.AreEqual(25.0, totalCost);
        }

        [TestMethod]
        public void CalculateTotalCost_XLParcel_ExceedsWeightLimit_ReturnsCorrectCost()
        {
            // Arrange
            Parcel parcel = new Parcel(120, 120, 120, 11);
            ShippingService service = new ShippingService(parcel, false);

            // Act
            double totalCost = service.ShippingServiceTotalCost();

            // Assert
            Assert.AreEqual(27.0, totalCost);
        }
    }
}
