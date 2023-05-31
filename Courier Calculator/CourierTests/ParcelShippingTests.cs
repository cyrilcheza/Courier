using CourierLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CourierTests
{
    [TestClass]
    public class ParcelShippingTests
    {
        [TestMethod]
        public void CalculateTotalCost_SmallParcel_CorrectCost()
        {
            // Arrange
            Parcel parcel = new Parcel(1, 1, 1, 1,false); 

            // Act
            double totalCost = parcel.CalculateTotalCost();

            // Assert
            Assert.AreEqual(3.0, totalCost);
        }

        [TestMethod]
        public void CalculateTotalCost_MediumParcel_CorrectCost()
        {
            // Arrange
            Parcel parcel = new Parcel(30, 30, 30,2,false);

            // Act
            double totalCost = parcel.CalculateTotalCost();

            // Assert
            Assert.AreEqual(8.0, totalCost);
        }

        [TestMethod]
        public void CalculateTotalCost_LargeParcel_CorrectCost()
        {
            // Arrange
            Parcel parcel = new Parcel(80, 80, 80,3, false);

            // Act
            double totalCost = parcel.CalculateTotalCost();

            // Assert
            Assert.AreEqual(15.0, totalCost);
        }

        [TestMethod]
        public void CalculateTotalCost_XLParcel_CorrectCost()
        {
            // Arrange
            Parcel parcel = new Parcel(120, 120, 120,4, false); 

            // Act
            double totalCost = parcel.CalculateTotalCost();

            // Assert
            Assert.AreEqual(25.0, totalCost);
        }







        [TestMethod]
        public void CalculateTotalCost_SmallParcel_CorrectCost_SpeedyShipping()
        {
            // Arrange
            Parcel parcel = new Parcel(1, 1, 1, 1, true);

            // Act
            double totalCost = parcel.CalculateTotalCost();
            double SpeedyShippingCost = parcel.CalculateTotalCostWithSpeedyDelivery();

            // Assert
            Assert.AreEqual(3.0, totalCost);
            Assert.AreEqual(6.0, SpeedyShippingCost);
        }

        [TestMethod]
        public void CalculateTotalCost_MediumParcel_CorrectCost_SpeedyShipping()
        {
            // Arrange
            Parcel parcel = new Parcel(30, 30, 30, 2, true);

            // Act
            double totalCost = parcel.CalculateTotalCost();
            double SpeedyShippingCost = parcel.CalculateTotalCostWithSpeedyDelivery();

            // Assert
            Assert.AreEqual(8.0, totalCost);
            Assert.AreEqual(16, SpeedyShippingCost);
        }

        [TestMethod]
        public void CalculateTotalCost_LargeParcel_CorrectCost_speedyShipping()
        {
            // Arrange
            Parcel parcel = new Parcel(80, 80, 80, 3, true);

            // Act
            double totalCost = parcel.CalculateTotalCost();
            double SpeedyShippingCost = parcel.CalculateTotalCostWithSpeedyDelivery();

            // Assert
            Assert.AreEqual(15.0, totalCost);
            Assert.AreEqual(30.0, SpeedyShippingCost);
        }

        [TestMethod]
        public void CalculateTotalCost_XLParcel_CorrectCost_SpeedyShipping()
        {
            // Arrange
            Parcel parcel = new Parcel(120, 120, 120, 4, true);

            // Act
            double totalCost = parcel.CalculateTotalCost();
            double SpeedyShippingCost = parcel.CalculateTotalCostWithSpeedyDelivery();

            // Assert
            Assert.AreEqual(25.0, totalCost);
            Assert.AreEqual(50.0, SpeedyShippingCost);
        }
    }

}



