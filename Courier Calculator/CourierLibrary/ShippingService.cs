using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierLibrary
{
    public class ShippingService
    {
        private readonly Parcel _parcel;
        private readonly bool _isSpeedService;

        public ShippingService(Parcel parcel, bool isSpeedService)
        {
            _parcel = parcel;
            _isSpeedService = isSpeedService;
        }

        public double BaseCost()
        {
            return _parcel.CalculateTotalCost();
        }

        public double ShippingServiceTotalCost()
        {
            double totalCost = BaseCost();
            if (_isSpeedService)
            {
                return totalCost * 2;
            }
            return totalCost;
        }
    }
}
