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
            YARD,
            CM,
            GALLON,
            LITRE,
            GRAMS,
            KG,
            ML,
            TONNE,
            FAHRENHEIT,
            CELCIUS,
        }

        /// <summary>
        /// Method to perform conversion.
        /// </summary>
        /// <param name="units">unit as input.</param>
        /// <returns>double value.</returns>
        public double GetconvertedUnit(Units units)
        {
            switch (units)
            {
                case Units.INCH:
                    return 1.0;
                case Units.FEET:
                    return 12.0;
                case Units.YARD:
                    return 36.0;
                case Units.CM:
                    return 1 / 2.5;
                case Units.LITRE:
                    return 1.0;
                case Units.GALLON:
                    return 1 * 3.78;
                case Units.ML:
                    return 1.0 / 1000.0;
                case Units.KG:
                    return 1.0;
                case Units.TONNE:
                    return 1000.0;
                case Units.GRAMS:
                    return 1.0 / 1000.0;
                case Units.CELCIUS:
                    return 1.8;
                case Units.FAHRENHEIT:
                    return 1.0;
                default: throw new QuantityMeasurementException("Cannot convert!", QuantityMeasurementException.ExceptionType.NOT_FOUND);
            }
        }
   }
}