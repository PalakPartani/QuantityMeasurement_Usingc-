// <copyright file="QuantityMeasurementTest.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace QuantityMeasurementTest
{
    using NUnit.Framework;

    /// <summary>
    /// Class to Test QuantityMeasurementTest.
    /// </summary>
    public class QuantityMeasurementTest
    {
        /// <summary>
        /// Calling Main Class.
        /// </summary>
        private QuantityMeasurement.QuantityMeasurement quantityMeasurement;
        private QuantityMeasurement.QuantityMeasurement quantityMeasurement2;

        /// <summary>
        /// Setup Method.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.quantityMeasurement = new QuantityMeasurement.QuantityMeasurement();
            this.quantityMeasurement2 = new QuantityMeasurement.QuantityMeasurement();
        }

        /// <summary>
        /// Test 1.1: check two feet 0 values.
        /// </summary>
        [Test]
        public void Given0FeetAnd0Feet_WhenSame_ShouldReturnEqual()
        {
            double value1 = this.quantityMeasurement.GetValue(0.0, QuantityMeasurement.BaseUnits.Units.FEET);
            double value2 = this.quantityMeasurement.GetValue(0.0, QuantityMeasurement.BaseUnits.Units.FEET);
            Assert.AreEqual(value1, value2);
        }

        /// <summary>
        /// Test 1.2: check equality for null.
        /// </summary>
        [Test]
        public void GivenNullFeetValue_ShouldReturnFalse()
        {
            Assert.IsFalse(this.quantityMeasurement.Equals(null));
        }

        /// <summary>
        /// Test 1.3: check equality for reference.
        /// </summary>
        [Test]
        public void GivenReferenceObject_WhenEqual_ShouldReturnTrue()
        {
            double value1 = this.quantityMeasurement.GetValue(0.0, QuantityMeasurement.BaseUnits.Units.FEET);
            double value2 = this.quantityMeasurement2.GetValue(0.0, QuantityMeasurement.BaseUnits.Units.FEET);
            bool data = value1.Equals(value2);
            Assert.IsTrue(data);
        }

        /// <summary>
        /// Test 1.4: check equality for type.
        /// </summary>
        [Test]
        public void GivenTypeObject_WhenEqual_ShouldReturnEqual()
        {
            Assert.AreEqual(this.quantityMeasurement, this.quantityMeasurement2);
        }

        /// <summary>
        /// Test 1.5: check equality for Feet value check.
        /// </summary>
        [Test]
        public void GivenValueCheck_WhenEqual_ShouldReturnEqual()
        {
            double value1 = this.quantityMeasurement.GetValue(5.0, QuantityMeasurement.BaseUnits.Units.FEET);
            double value2 = this.quantityMeasurement2.GetValue(5.0, QuantityMeasurement.BaseUnits.Units.FEET);
            Assert.AreEqual(value1, value2);
        }

        /// <summary>
        /// Test 1.6: check two 0 inch values.
        /// </summary>
        [Test]
        public void Given0InchAnd0Inch_WhenSame_ShouldReturnEqual()
        {
            double inchValue1 = this.quantityMeasurement.GetValue(0.0, QuantityMeasurement.BaseUnits.Units.FEET);
            double inchValue2 = this.quantityMeasurement.GetValue(0.0, QuantityMeasurement.BaseUnits.Units.FEET);
            Assert.AreEqual(inchValue1, inchValue2);
        }

        /// <summary>
        /// Test 1.7: check equality for null.
        /// </summary>
        [Test]
        public void GivenNullInchValue_ShouldReturnFalse()
        {
            Assert.IsFalse(this.quantityMeasurement.Equals(null));
        }

        /// <summary>
        /// Test 1.8: check equality for reference in Inch.
        /// </summary>
        [Test]
        public void GivenReferenceObjectForInch_WhenEqual_ShouldReturnTrue()
        {
            double value1 = this.quantityMeasurement.GetValue(0.0, QuantityMeasurement.BaseUnits.Units.FEET);
            double value2 = this.quantityMeasurement2.GetValue(0.0, QuantityMeasurement.BaseUnits.Units.FEET);
            bool data = value1.Equals(value2);
            Assert.IsTrue(data);
        }

        /// <summary>
        /// Test 1.9: check equality for type in inch.
        /// </summary>
        [Test]
        public void GivenTypeObjectInInch_WhenEqual_ShouldReturnEqual()
        {
            Assert.AreEqual(this.quantityMeasurement, this.quantityMeasurement2);
        }

        /// <summary>
        /// Test 1.10: check equality for value check in Inch.
        /// </summary>
        [Test]
        public void GivenInchValueCheck_WhenEqual_ShouldReturnEqual()
        {
            double value1 = this.quantityMeasurement.GetValue(5.0, QuantityMeasurement.BaseUnits.Units.FEET);
            double value2 = this.quantityMeasurement2.GetValue(5.0, QuantityMeasurement.BaseUnits.Units.FEET);
            Assert.AreEqual(value1, value2);
        }

        /// <summary>
        /// Test 1.11: check equality for values of Feet & Inch.
        /// </summary>
        [Test]
        public void GivenInchandFeetValueCheck_WhenEqual_ShouldReturnEqual()
        {
            double value1 = this.quantityMeasurement.GetValue(0.0, QuantityMeasurement.BaseUnits.Units.FEET);
            double value2 = this.quantityMeasurement2.GetValue(0.0, QuantityMeasurement.BaseUnits.Units.INCH);
            Assert.AreEqual(value1, value2);
        }

        /// <summary>
        /// Test 1.13: check equality for values of Feet & Inch.
        /// </summary>
        [Test]
        public void GivenOneInchandOneFeetValueCheck_WhenNitEqual_ShouldReturnNotEqual()
        {
            double value1 = this.quantityMeasurement.GetValue(1.0, QuantityMeasurement.BaseUnits.Units.FEET);
            double value2 = this.quantityMeasurement2.GetValue(1.0, QuantityMeasurement.BaseUnits.Units.INCH);
            Assert.AreNotEqual(value1, value2);
        }

        /// <summary>
        /// Test 1.14: check equality for values of 1 Feet & 1 Inch.
        /// </summary>
        [Test]
        public void GivenOneFeetandOneInchValueCheck_WhenNotEqual_ShouldReturnNotEqual()
        {
            double value1 = this.quantityMeasurement.GetValue(1.0, QuantityMeasurement.BaseUnits.Units.INCH);
            double value2 = this.quantityMeasurement2.GetValue(1.0, QuantityMeasurement.BaseUnits.Units.FEET);
            Assert.AreNotEqual(value1, value2);
        }

        /// <summary>
        /// Test 1.15: check equality for values of 12 Feet & 1 Inch.
        /// </summary>
        [Test]
        public void GivenOneFeetandTwelveInchValueCheck_WhenEqual_ShouldReturnNotEqual()
        {
            double value1 = this.quantityMeasurement.GetValue(1.0, QuantityMeasurement.BaseUnits.Units.FEET);
            double value2 = this.quantityMeasurement2.GetValue(12.0, QuantityMeasurement.BaseUnits.Units.INCH);
            Assert.AreEqual(value1, value2);
        }

        /// <summary>
        /// Test 1.16: check equality for values of 1Feet & 12Inch.
        /// </summary>
        [Test]
        public void GivenTwelveFeetandOneInchValueCheck_WhenEqual_ShouldReturnNotEqual()
        {
            double value1 = this.quantityMeasurement.GetValue(12.0, QuantityMeasurement.BaseUnits.Units.INCH);
            double value2 = this.quantityMeasurement2.GetValue(1.0, QuantityMeasurement.BaseUnits.Units.FEET);
            Assert.AreEqual(value1, value2);
        }
    }
}