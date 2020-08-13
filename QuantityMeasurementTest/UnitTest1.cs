using NUnit.Framework;
namespace QuantityMeasurementTest
{
    public class Tests
    {
        QuantityMeasurement.QuantityMeasurement quantityMeasurement;
        [SetUp]
        public void Setup()
        {
            quantityMeasurement = new QuantityMeasurement.QuantityMeasurement();
        }

        [Test]
        public void GivenFeetValues_WhenSame_ShouldReturnEqual()
        {
            double value1 = quantityMeasurement.GetValue(0.0);
            double value2 = quantityMeasurement.GetValue(0.0);
            Assert.AreEqual(value1, value2);
        }
        [Test]
        public void givenNullFeetValue_ShouldReturnFalse()
        {
            Assert.IsFalse(quantityMeasurement.Equals(null));
        }
    }
}