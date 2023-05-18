using CourierLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CourierTests
{
    [TestClass]
    public class ShippingServiceTests
    {
        [TestMethod]
        public void ShippingServiceTotalCost_Small_ParcelWithoutSpeedyShipping_CorrectCost()
        {
            // Arrange
            Parcel parcel = new Parcel(1, 1, 1);
            ShippingService service = new ShippingService(parcel, false);

            // Act
            double totalCost = service.ShippingServiceTotalCost();

            // Assert
            Assert.AreEqual(3.0, totalCost);
        }

        [TestMethod]
        public void ShippingServiceTotalCost_Small_ParcelWithSpeedyShipping_CorrectCost()
        {
            // Arrange
            Parcel parcel = new Parcel(1, 1, 1);
            ShippingService service = new ShippingService(parcel, true);

            // Act
            double totalCost = service.ShippingServiceTotalCost();
            double parcelBaseCost = service.BaseCost();

            // Assert
            Assert.AreEqual(6.0, totalCost);
            Assert.AreEqual(3.0, parcelBaseCost);
        }

        [TestMethod]
        public void ShippingServiceTotalCost_Medium_ParcelWithoutSpeedyShipping_CorrectCost()
        {
            // Arrange
            Parcel parcel = new Parcel(30, 30, 30);
            ShippingService service = new ShippingService(parcel, false);

            // Act
            double totalCost = service.ShippingServiceTotalCost();

            // Assert
            Assert.AreEqual(8.0, totalCost);
        }

        [TestMethod]
        public void ShippingServiceTotalCost_Medium_ParcelWithSpeedyShipping_CorrectCost()
        {
            // Arrange
            Parcel parcel = new Parcel(30, 30, 30);
            ShippingService service = new ShippingService(parcel, true);

            // Act
            double totalCost = service.ShippingServiceTotalCost();
            double parcelBaseCost = service.BaseCost();

            // Assert
            Assert.AreEqual(16.0, totalCost);
            Assert.AreEqual(8.0, parcelBaseCost);
        }

        [TestMethod]
        public void ShippingServiceTotalCost_Large_ParcelWithoutSpeedyShipping_CorrectCost()
        {
            // Arrange
            Parcel parcel = new Parcel(80, 80, 80);
            ShippingService service = new ShippingService(parcel, false);

            // Act
            double totalCost = service.ShippingServiceTotalCost();

            // Assert
            Assert.AreEqual(15.0, totalCost);
        }

        [TestMethod]
        public void ShippingServiceTotalCost_Large_ParcelWithSpeedyShipping_CorrectCost()
        {
            // Arrange
            Parcel parcel = new Parcel(80, 80, 80);
            ShippingService service = new ShippingService(parcel, true);

            // Act
            double totalCost = service.ShippingServiceTotalCost();
            double parcelBaseCost = service.BaseCost();
            // Assert
            Assert.AreEqual(30.0, totalCost);
            Assert.AreEqual(15.0, parcelBaseCost);
        }

        [TestMethod]
        public void ShippingServiceTotalCost_XL_ParcelWithoutSpeedyShipping_CorrectCost()
        {
            // Arrange
            Parcel parcel = new Parcel(120, 120, 120);
            ShippingService service = new ShippingService(parcel, false);

            // Act
            double totalCost = service.ShippingServiceTotalCost();

            // Assert
            Assert.AreEqual(25.0, totalCost);
        }

        [TestMethod]
        public void ShippingServiceTotalCost_XL_ParcelWithSpeedyShipping_CorrectCost()
        {
            // Arrange
            Parcel parcel = new Parcel(120, 120, 120);
            ShippingService service = new ShippingService(parcel, true);

            // Act
            double totalCost = service.ShippingServiceTotalCost();
            double parcelBaseCost = service.BaseCost();

            // Assert
            Assert.AreEqual(50.0, totalCost);
            Assert.AreEqual(25.0, parcelBaseCost);
        }
    }
}
