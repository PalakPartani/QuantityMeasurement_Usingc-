// <copyright file="BaseUnits.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace QuantityMeasurement
{
    /// <summary>
    /// Provides units and its values.
    /// </summary>
   public class BaseUnits
    {
        /// <summary>
        /// Enum that is set with value.
        /// </summary>
        public enum Units
        {
            FEET,
            INCH,
        }

        /// <summary>
        /// Method to perform conversion.
        /// </summary>
        /// <param name="units">unit as input.</param>
        /// <returns>double value.</returns>
        public double GetconvertedUnit(Units units)
        {
            if (units == Units.FEET)
            {
                return 12.0;
            }

            if (units == Units.INCH)
            {
                return 1.0;
            }

            return 0.0;
        }
   }
}