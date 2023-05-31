using CourierLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierTests
{
    [TestClass]
    public class DiscountParcelsTests
    {
        [TestMethod]
        public void CalculateCost_OneSmallParcel_ReturnsCorrectTotalCost()
        {

            var parcels = new List<Parcel>
            {
            new Parcel ( 1,1,1,1,false )
            };
            var system = new ParcelDeliverySystem(parcels);
            double totalCost = system.CalculateCost();

            Assert.AreEqual(3, totalCost);
        }

        [TestMethod]
        public void CalculateCost_SmallParcelMania_ReturnsCorrectTotalCost()
        {
   
            var parcels = new List<Parcel>
            {
            new Parcel ( 1,1,1,1,false ),
            new Parcel ( 1,1,1,1,false ),
            new Parcel ( 1,1,1,1,false ),
            new Parcel ( 1,1,1,1,false )
            };
            var system = new ParcelDeliverySystem(parcels);

            double totalCost = system.CalculateCost();
            double totalDiscount = system.CalculateDiscount();

            Assert.AreEqual(9, totalCost);
            Assert.AreEqual(3, totalDiscount);
        }

        [TestMethod]
        public void CalculateCost_OneMediumParcel_ReturnsCorrectTotalCost()
        {
     
            var parcels = new List<Parcel>
            {
            new Parcel ( 20,20,20,1,false )
            };
            var system = new ParcelDeliverySystem(parcels);
            double totalCost = system.CalculateCost();

            Assert.AreEqual(8, totalCost);
        }

        [TestMethod]
        public void CalculateCost_MediumParcelMania_ReturnsCorrectTotalCost()
        {
            
            var parcels = new List<Parcel>
            {
            new Parcel ( 20,20,20,1,false ), new Parcel ( 20,20,20,1,false ), new Parcel ( 20,20,20,1,false ),
            };
            var system = new ParcelDeliverySystem(parcels);
            double totalCost = system.CalculateCost();
            double totalDiscount = system.CalculateDiscount();

            Assert.AreEqual(16, totalCost);
            Assert.AreEqual(8, totalDiscount);
        }

        [TestMethod]
        public void CalculateCost_MixedParcels_ReturnsCorrectTotalCost()
        {
           
            var parcels = new List<Parcel>
            {
            new Parcel ( 20,20,20,1,false ), new Parcel ( 1,1,1,1,false ), new Parcel ( 60,20,20,1,false ),new Parcel ( 100,20,20,1,false )
            };
            var system = new ParcelDeliverySystem(parcels);

            double totalCost = system.CalculateCost();

            Assert.AreEqual(51, totalCost);
        }

        [TestMethod]
        public void CalculateCost_MixedParcelsMania_ReturnsCorrectTotalCost()
        {

            var parcels = new List<Parcel>
            {
            new Parcel ( 20,20,20,1,false ), new Parcel ( 1,1,1,1,false ), new Parcel ( 60,20,20,1,false ),new Parcel ( 100,20,20,1,false ), new Parcel ( 20,20,20,1,false )
            };
            var system = new ParcelDeliverySystem(parcels);

            double totalCost = system.CalculateCost();

            Assert.AreEqual(51, totalCost);
        }

    }
}
