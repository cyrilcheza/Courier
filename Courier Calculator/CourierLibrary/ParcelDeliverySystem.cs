using CourierLibrary;
using System.Collections.Generic;
using System.Linq;

namespace CourierLibrary
{
    public class ParcelDeliverySystem
    {
        private List<Parcel> _parcels;

        public ParcelDeliverySystem(List<Parcel> parcels)
        {
           _parcels = parcels;
        }

        public double CalculateCost()
        {
            double totalCost = 0;

            // Calculate the total cost of individual parcels
            foreach (var parcel in _parcels)
            {
                totalCost += parcel.CalculateTotalCost();
            }

            // Apply discounts
            totalCost -= CalculateDiscount();

            return totalCost;
        }

        public double CalculateDiscount()
        {
            int smallParcelCount = 0;
            int mediumParcelCount = 0;
            int totalParcelCount = _parcels.Count;
            double discount = 0;

            List<Parcel> parcelTempSmall = new List<Parcel>();
            List<Parcel> parcelTempMedium = new List<Parcel>();

            for (int i = 0; i < totalParcelCount; i++)
            {
                if (_parcels[i].GetParcelType() == ParcelType.Small)
                {
                    smallParcelCount++;
                    parcelTempSmall.Add(_parcels[i]);
                    if (smallParcelCount % 4 == 0)
                    {
                        double cheapestParcelCost = parcelTempSmall.Min(p => p.CalculateTotalCost());
                        discount += cheapestParcelCost;
                        parcelTempSmall.Clear();
                    }
                }
                else if (_parcels[i].GetParcelType() == ParcelType.Medium)
                {
                    mediumParcelCount++;
                    parcelTempMedium.Add(_parcels[i]);
                    if (mediumParcelCount % 3 == 0)
                    {
                        double cheapestParcelCost = parcelTempMedium.Min(p => p.CalculateTotalCost());
                        discount += cheapestParcelCost;
                        parcelTempMedium.Clear();
                    }
                }

                if ((i + 1) % 5 == 0)
                {
                    double cheapestParcelCost = _parcels.Min(p => p.CalculateTotalCost());
                    discount += _parcels[i].CalculateTotalCost();

                }
            }

            return discount;
        }
    }
}