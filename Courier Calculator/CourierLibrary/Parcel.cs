namespace CourierLibrary
{
    public class Parcel
    {
        private const double SmallParcelCost = 3;
        private const double MediumParcelCost = 8;
        private const double LargeParcelCost = 15;
        private const double XLParcelCost = 25;

        private const double SmallParcelWeightLimit = 1;
        private const double MediumParcelWeightLimit = 3;
        private const double LargeParcelWeightLimit = 6;
        private const double XLParcelWeightLimit = 10;

        private const double HeavyParcelWeightLimit = 50;
        private double HeavyExcessPlaceholder = 0;

        private double _weight { get; set; }
        private bool _isSpeedyDelivery { get; }
        private readonly double _length;
        private readonly double _width;
        private readonly double _height;

        public Parcel(double length, double width, double height, double weight, bool isSpeedyDelivery)
        {
            _length = length;
            _width = width;
            _height = height;
            _weight = weight;
            _isSpeedyDelivery = isSpeedyDelivery;
        }

        public double CalculateTotalCostWithSpeedyDelivery()
        {
            if (_isSpeedyDelivery)
            {
                return CalculateTotalCost() * 2;
            }
            return 0; //no speedy cost can be applied
        }

            /// <summary>
            /// Calculates the cost of the parcel
            /// </summary>
            /// <returns>The total cost of the parcel</returns>
            public double CalculateTotalCost()
            {
            double excessWeight = CalculateExcessWeight();

            if (_length < 10 && _width < 10 && _height < 10)
            {
                return CalculateCost(SmallParcelCost, SmallParcelWeightLimit, excessWeight);
            }

            if (_length < 50 && _width < 50 && _height < 50)
            {
                return CalculateCost(MediumParcelCost, MediumParcelWeightLimit, excessWeight);
            }

            if (_length < 100 && _width < 100 && _height < 100)
            {
                return CalculateCost(LargeParcelCost, LargeParcelWeightLimit, excessWeight);
            }

            return CalculateCost(XLParcelCost, XLParcelWeightLimit, excessWeight);
        }

        private double CalculateExcessWeight()
        {

            if (_weight > HeavyParcelWeightLimit)
            {
                //temp change the weight here
                HeavyExcessPlaceholder =  _weight - HeavyParcelWeightLimit;
                _weight = HeavyParcelWeightLimit; 
            }

            double excessWeight = _weight - GetWeightLimit();
            return excessWeight > 0 ? excessWeight : 0;
        }

        private double GetWeightLimit()
        {
            if (_length < 10 && _width < 10 && _height < 10)
            {
                return SmallParcelWeightLimit;
            }

            if (_length < 50 && _width < 50 && _height < 50)
            {
                return MediumParcelWeightLimit;
            }

            if (_length < 100 && _width < 100 && _height < 100)
            {
                return LargeParcelWeightLimit;
            }

            return XLParcelWeightLimit;
        }

        private double CalculateCost(double baseCost, double weightLimit, double excessWeight)
        {
            if (HeavyExcessPlaceholder != 0)
            {
                return baseCost + (excessWeight * 2) + HeavyExcessPlaceholder;
            }
            return baseCost + (excessWeight * 2);
        }
    }
}
