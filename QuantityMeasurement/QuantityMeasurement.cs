// <copyright file="QuantityMeasurement.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace QuantityMeasurement
{
    /// <summary>
    /// Class To Perform Quantity Measurement.
    /// </summary>
    public class QuantityMeasurement
    {
        private double inch;
        private double feet;
        private BaseUnits units = new BaseUnits();
       
        /// <summary>
        /// Method to get double values.
        /// </summary>
        /// <param name="value">Perform operation.</param>
        /// <returns>value converted.</returns>
        public double GetValue(double value,BaseUnits.Units units)
        {
            return value * this.units.GetconvertedUnit(units);
        }

        /// <summary>
        /// Overrriding Equals Method.
        /// </summary>
        /// <param name="obj">Check object.</param>
        /// <returns>boolean value.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }

            if (obj is QuantityMeasurement)
            {
                return true;
            }

            return true;
        }

        /// <summary>
        /// Overriding GetHashCode Method.
        /// </summary>
        /// <returns>hascode.</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}