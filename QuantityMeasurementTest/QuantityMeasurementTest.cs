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
            double value1 = this.quantityMeasurement.GetValue(0.0);
            double value2 = this.quantityMeasurement.GetValue(0.0);
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
            double value1 = this.quantityMeasurement.GetValue(0.0);
            double value2 = this.quantityMeasurement2.GetValue(0.0);
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
        /// Test 1.5: check equality for value check.
        /// </summary>
        [Test]
        public void GivenValueCheck_WhenEqual_ShouldReturnEqual()
        {
            double value1 = this.quantityMeasurement.GetValue(5.0);
            double value2 = this.quantityMeasurement2.GetValue(5.0);
            Assert.AreEqual(value1, value2);
        }

        /// <summary>
        /// Test 1.6: check two 0 inch values.
        /// </summary>
        [Test]
        public void Given0InchAnd0Inch_WhenSame_ShouldReturnEqual()
        {
            double inchValue1 = this.quantityMeasurement.GetValue(0.0);
            double inchValue2 = this.quantityMeasurement.GetValue(0.0);
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
            double value1 = this.quantityMeasurement.GetValue(0.0);
            double value2 = this.quantityMeasurement2.GetValue(0.0);
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
    }
}