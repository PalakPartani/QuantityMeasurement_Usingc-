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
        /// Test 1.1: To Check two feet values.
        /// </summary>
        [Test]
        public void GivenFeetValues_WhenSame_ShouldReturnEqual()
        {
            double value1 = this.quantityMeasurement.GetValue(0.0);
            double value2 = this.quantityMeasurement.GetValue(0.0);
            Assert.AreEqual(value1, value2);
        }

        /// <summary>
        /// Test 1.2: To Check equality for null.
        /// </summary>
        [Test]
        public void GivenNullFeetValue_ShouldReturnFalse()
        {
            Assert.IsFalse(this.quantityMeasurement.Equals(null));
        }

        /// <summary>
        /// Test 1.3: To Check equality for reference.
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
        /// Test 1.3: To Check equality for type.
        /// </summary>
        [Test]
        public void GivenTypeObject_WhenEqual_ShouldReturnTrue()
        {
            Assert.AreEqual(this.quantityMeasurement, this.quantityMeasurement2);
        }
    }
}