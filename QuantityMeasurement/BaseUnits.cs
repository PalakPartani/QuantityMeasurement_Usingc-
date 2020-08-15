// <copyright file="BaseUnits.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;

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
            YARD,
            CM,
            GALLON,
            LITRE,
            ML,
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

            if (units == Units.YARD)
            {
                return 36.0;
            }

            if (units == Units.CM)
            {
                return 1 / 2.5;
            }

            if (units == Units.LITRE)
            {
                return 1.0;
            }

            if (units == Units.ML)
            {
                Console.WriteLine("Hello");
                return 1.0 / 1000.0;
                
            }

            if (units == Units.GALLON)
            {
                return 1 * 3.78;
            }
            
            return 0.0;
        }
   }
}