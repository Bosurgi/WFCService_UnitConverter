using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServiceConverter
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Converter" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Converter.svc or Converter.svc.cs at the Solution Explorer and start debugging.
    public class Converter : IConverter
    {
        /// <summary>
        /// Converts feet to meters using the appropriate range of conversion.
        /// </summary>
        /// <param name="feet">the value in feet</param>
        /// <returns>the correspondent value in meters</returns>
        public double ConvertFeetToMeters(double feet)
        {
            // 1 foot = 0.304 meter
            return feet * 0.304;
        }
        /// <summary>
        /// Converts inches to centimeters using the appropriate range of conversion.
        /// </summary>
        /// <param name="inches">the value in inches</param>
        /// <returns>the correspondent value in centimeters</returns>
        public double ConvertInchesToCentimeters(double inches)
        {
            // 1 inch = 2.54 cm
            return inches * 2.54;
        }
        /// <summary>
        /// Converts miles to kilometers using the appropriate range of conversion.
        /// </summary>
        /// <param name="miles">the value in miles</param>
        /// <returns>the correspondent value in kilometers</returns>
        public double ConvertMilesToKm(double miles)
        {
            // 1 mile = 1.609 km
            return miles * 1.609;
        }
        /// <summary>
        /// Converts pounds to kilograms using the appropriate range of conversion.
        /// </summary>
        /// <param name="pounds">the value in pounds</param>
        /// <returns>the correspondent value in kilograms</returns>
        public double ConvertPoundsToKilograms(double pounds)
        {
            // 1 pound = 0.453 kg
            return pounds * 0.453;
        }
    }
}
