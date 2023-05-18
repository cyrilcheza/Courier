using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierLibrary
{
    public class Parcel
    {
        private const double SmallParcelCost = 3;
        private const double MediumParcelCost = 8;
        private const double LargeParcelCost = 15;
        private const double XLParcelCost = 25;

        private double _length { set; get; }
        private double _width { set; get; }
        private double _height { set; get; }  

        public Parcel(double lenght, double width, double height)
        {
            _length = lenght;
            _width = width;
            _height = height;
        }

        /// <summary>
        /// Calculates a parcel cost
        /// </summary>
        /// <returns>Value of the parcel</returns>
        public double CalculateTotalCost()
        {
            if (_length < 10 && _width < 10 && _height < 10)
                return SmallParcelCost;

            if (_length < 50 && _width < 50 && _height < 50)
                return MediumParcelCost;
            

            if (_length < 100 && _width < 100 && _height < 100)
                return LargeParcelCost;
            
            
            return XLParcelCost;
        }
    }
}
