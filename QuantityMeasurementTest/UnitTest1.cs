using NUnit.Framework;
using System;

namespace QuantityMeasurementTest
{
    public class Tests
    {
        QuantityMeasurement.QuantityMeasurement quantityMeasurement;
        QuantityMeasurement.QuantityMeasurement quantityMeasurement2;


        [SetUp]
        public void Setup()
        {
            quantityMeasurement = new QuantityMeasurement.QuantityMeasurement();
            quantityMeasurement2 = new QuantityMeasurement.QuantityMeasurement();

        }

        [Test]
        public void GivenFeetValues_WhenSame_ShouldReturnEqual()
        {
            double value1 = quantityMeasurement.GetValue(0.0);
            double value2 = quantityMeasurement.GetValue(0.0);
            Assert.AreEqual(value1, value2);
        }

        [Test]
        public void GivenNullFeetValue_ShouldReturnFalse()
        {
            Assert.IsFalse(quantityMeasurement.Equals(null));
        }

        [Test]
        public void givenReferenceObject_WhenEqual_ShouldReturnTrue()
        {
            double value1 = quantityMeasurement.GetValue(0.0);
            double result=quantityMeasurement2.GetValue(0.0);
            Boolean data= (value1.Equals(result));
            Assert.IsTrue(data);
        }

    }
}