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
        /// Test 1.1: check two zero feet values.
        /// </summary>
        [Test]
        public void Given0FeetAnd0Feet_WhenSame_ShouldReturnEqual()
        {
            double valueOne = this.quantityMeasurement.GetValue(0.0, QuantityMeasurement.BaseUnits.Units.FEET);
            double valueTwo = this.quantityMeasurement.GetValue(0.0, QuantityMeasurement.BaseUnits.Units.FEET);
            Assert.AreEqual(valueOne, valueTwo);
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
            double valueOne = this.quantityMeasurement.GetValue(0.0, QuantityMeasurement.BaseUnits.Units.FEET);
            double valueTwo = this.quantityMeasurement2.GetValue(0.0, QuantityMeasurement.BaseUnits.Units.FEET);
            bool data = valueOne.Equals(valueTwo);
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
            double valueOne = this.quantityMeasurement.GetValue(5.0, QuantityMeasurement.BaseUnits.Units.FEET);
            double valueTwo = this.quantityMeasurement2.GetValue(5.0, QuantityMeasurement.BaseUnits.Units.FEET);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test 1.6: check two zero inch values.
        /// </summary>
        [Test]
        public void Given0InchAnd0Inch_WhenSame_ShouldReturnEqual()
        {
            double inchValueOne = this.quantityMeasurement.GetValue(0.0, QuantityMeasurement.BaseUnits.Units.FEET);
            double inchValueTwo = this.quantityMeasurement.GetValue(0.0, QuantityMeasurement.BaseUnits.Units.FEET);
            Assert.AreEqual(inchValueOne, inchValueTwo);
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
            double valueOne = this.quantityMeasurement.GetValue(0.0, QuantityMeasurement.BaseUnits.Units.FEET);
            double valueTwo = this.quantityMeasurement2.GetValue(0.0, QuantityMeasurement.BaseUnits.Units.FEET);
            bool data = valueOne.Equals(valueTwo);
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
            double valueOne = this.quantityMeasurement.GetValue(5.0, QuantityMeasurement.BaseUnits.Units.FEET);
            double valueTwo = this.quantityMeasurement2.GetValue(5.0, QuantityMeasurement.BaseUnits.Units.FEET);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test 1.11: check equality for values of Feet & Inch.
        /// </summary>
        [Test]
        public void GivenInchandFeetValueCheck_WhenEqual_ShouldReturnEqual()
        {
            double valueOne = this.quantityMeasurement.GetValue(0.0, QuantityMeasurement.BaseUnits.Units.FEET);
            double valueTwo = this.quantityMeasurement2.GetValue(0.0, QuantityMeasurement.BaseUnits.Units.INCH);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test 1.13: check equality for values of Feet & Inch.
        /// </summary>
        [Test]
        public void GivenOneInchandOneFeetValueCheck_WhenNitEqual_ShouldReturnNotEqual()
        {
            double valueOne = this.quantityMeasurement.GetValue(1.0, QuantityMeasurement.BaseUnits.Units.FEET);
            double valueTwo = this.quantityMeasurement2.GetValue(1.0, QuantityMeasurement.BaseUnits.Units.INCH);
            Assert.AreNotEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test 1.14: check equality for values of one Feet & one Inch.
        /// </summary>
        [Test]
        public void GivenOneFeetandOneInchValueCheck_WhenNotEqual_ShouldReturnNotEqual()
        {
            double valueOne = this.quantityMeasurement.GetValue(1.0, QuantityMeasurement.BaseUnits.Units.INCH);
            double valueTwo = this.quantityMeasurement2.GetValue(1.0, QuantityMeasurement.BaseUnits.Units.FEET);
            Assert.AreNotEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test 1.15: check equality for values of twelve Feet & one Inch.
        /// </summary>
        [Test]
        public void GivenOneFeetandTwelveInchValueCheck_WhenEqual_ShouldReturnNotEqual()
        {
            double valueOne = this.quantityMeasurement.GetValue(1.0, QuantityMeasurement.BaseUnits.Units.FEET);
            double valueTwo = this.quantityMeasurement2.GetValue(12.0, QuantityMeasurement.BaseUnits.Units.INCH);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test 1.16: check equality for values of one Feet & twelve Inch.
        /// </summary>
        [Test]
        public void GivenTwelveFeetandOneInchValueCheck_WhenEqual_ShouldReturnNotEqual()
        {
            double valueOne = this.quantityMeasurement.GetValue(12.0, QuantityMeasurement.BaseUnits.Units.INCH);
            double valueTwo = this.quantityMeasurement2.GetValue(1.0, QuantityMeasurement.BaseUnits.Units.FEET);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test 1.11: check equality for values of one Feet & twelve Inch.
        /// </summary>
        [Test]
        public void GivenThreeFeetandOneYardValueCheck_WhenEqual_ShouldReturnEqual()
        {
            double valueOne = this.quantityMeasurement.GetValue(3.0, QuantityMeasurement.BaseUnits.Units.FEET);
            double valueTwo = this.quantityMeasurement2.GetValue(1.0, QuantityMeasurement.BaseUnits.Units.YARD);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test 1.12: check equality for values of one Feet & one Yard.
        /// </summary>
        [Test]
        public void GivenOneFeetandOneYardValueCheck_WhenNotEqual_ShouldReturnNotEqual()
        {
            double valueOne = this.quantityMeasurement.GetValue(1.0, QuantityMeasurement.BaseUnits.Units.FEET);
            double valueTwo = this.quantityMeasurement2.GetValue(1.0, QuantityMeasurement.BaseUnits.Units.YARD);
            Assert.AreNotEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test 1.13: check equality for values of one Feet & one Yard.
        /// </summary>
        [Test]
        public void GivenOneInchandOneYardValueCheck_WhenNotEqual_ShouldReturnNotEqual()
        {
            double valueOne = this.quantityMeasurement.GetValue(1.0, QuantityMeasurement.BaseUnits.Units.INCH);
            double valueTwo = this.quantityMeasurement2.GetValue(1.0, QuantityMeasurement.BaseUnits.Units.YARD);
            Assert.AreNotEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test 1.14: check equality for values of one Feet & twelve Inch.
        /// </summary>
        [Test]
        public void GivenOneYardAndThirtySixInchValueCheck_WhenEqual_ShouldReturnEqual()
        {
            double valueOne = this.quantityMeasurement.GetValue(1.0, QuantityMeasurement.BaseUnits.Units.YARD);
            double valueTwo = this.quantityMeasurement2.GetValue(36.0, QuantityMeasurement.BaseUnits.Units.INCH);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test 1.15: check equality for values of one Feet & twelve Inch.
        /// </summary>
        [Test]
        public void GivenThirtySixInchAndOneYardValueCheck_WhenEqual_ShouldReturnEqual()
        {
            double valueTwo = this.quantityMeasurement2.GetValue(36.0, QuantityMeasurement.BaseUnits.Units.INCH);
            double valueOne = this.quantityMeasurement.GetValue(1.0, QuantityMeasurement.BaseUnits.Units.YARD);
            Assert.AreEqual(valueTwo, valueOne);
        }

        /// <summary>
        /// Test 1.16: check equality for values of one Feet & twelve Inch.
        /// </summary>
        [Test]
        public void GivenOneYardAndThreeFeetValueCheck_WhenEqual_ShouldReturnEqual()
        {
            double valueOne = this.quantityMeasurement.GetValue(1.0, QuantityMeasurement.BaseUnits.Units.YARD);
            double valueTwo = this.quantityMeasurement2.GetValue(3.0, QuantityMeasurement.BaseUnits.Units.FEET);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test 1.17: check equality for values of Two inch to five cm.
        /// </summary>
        [Test]
        public void GivenTwoInchAndFiveCMValueCheck_WhenEqual_ShouldReturnEqual()
        {
            double valueOne = this.quantityMeasurement.GetValue(2.0, QuantityMeasurement.BaseUnits.Units.INCH);
            double valueTwo = this.quantityMeasurement2.GetValue(5.0, QuantityMeasurement.BaseUnits.Units.CM);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test 1.1: check two cm zero values.
        /// </summary>
        [Test]
        public void Given0InchAnd0CM_WhenSame_ShouldReturnEqual()
        {
            double valueOne = this.quantityMeasurement.GetValue(0.0, QuantityMeasurement.BaseUnits.Units.INCH);
            double valueTwo = this.quantityMeasurement.GetValue(0.0, QuantityMeasurement.BaseUnits.Units.CM);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test 1.1: add values.
        /// </summary>
        [Test]
        public void GivenTwoInchAndTwoInch_WhenAdded_ShouldReturnCorrectResult()
        {
            double valueOne = this.quantityMeasurement.GetValue(2.0, QuantityMeasurement.BaseUnits.Units.INCH);
            double valueTwo = this.quantityMeasurement.GetValue(2.0, QuantityMeasurement.BaseUnits.Units.INCH);
            Assert.AreEqual(valueOne + valueTwo, 4);
        }

        /// <summary>
        /// Test 1.1: add values.
        /// </summary>
        [Test]
        public void GivenOneFeetAndTwoInch_WhenAdded_ShouldReturnCorrectResult()
        {
            double valueOne = this.quantityMeasurement.GetValue(1.0, QuantityMeasurement.BaseUnits.Units.FEET);
            double valueTwo = this.quantityMeasurement.GetValue(2.0, QuantityMeasurement.BaseUnits.Units.INCH);
            Assert.AreEqual(valueOne + valueTwo, 14);
        }

        /// <summary>
        /// Test 1.1: add values.
        /// </summary>
        [Test]
        public void GivenOneFeetAndOneFeet_WhenAdded_ShouldReturnCorrectResult()
        {
            double valueOne = this.quantityMeasurement.GetValue(1.0, QuantityMeasurement.BaseUnits.Units.FEET);
            double valueTwo = this.quantityMeasurement.GetValue(1.0, QuantityMeasurement.BaseUnits.Units.FEET);
            Assert.AreEqual(valueOne + valueTwo, 24);
        }

        /// <summary>
        /// Test 1.1: add values.
        /// </summary>
        [Test]
        public void GivenTwoInchAndTwoptFiveCm_WhenAdded_ShouldReturnCorrectResult()
        {
            double valueOne = this.quantityMeasurement.GetValue(2.0, QuantityMeasurement.BaseUnits.Units.INCH);
            double valueTwo = this.quantityMeasurement.GetValue(2.5, QuantityMeasurement.BaseUnits.Units.CM);
            Assert.AreEqual(valueOne + valueTwo, 3);
        }

        /// <summary>
        /// Test 1.1: add values.
        /// </summary>
        [Test]
        public void GivenOneGallonAndThreeptSevenEightLiters_WhenSame_ShouldReturnEqual()
        {
            double valueOne = this.quantityMeasurement.GetValue(1.0, QuantityMeasurement.BaseUnits.Units.GALLON);
            double valueTwo = this.quantityMeasurement.GetValue(3.78, QuantityMeasurement.BaseUnits.Units.LITRE);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test 1.1: add values.
        /// </summary>
        [Test]
        public void GivenOneLitreAndThousandMiliLitre_WhenAdded_ShouldReturnEqual()
        {
            double valueOne = this.quantityMeasurement.GetValue(1.0, QuantityMeasurement.BaseUnits.Units.LITRE);
            double valueTwo = this.quantityMeasurement.GetValue(1000.0, QuantityMeasurement.BaseUnits.Units.GRAMS);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test 1.1: add values.
        /// </summary>
        [Test]
        public void GivenOneGallonAndThreeptSevenEightLiters_WhenAdded_ShouldReturnCorrectResult()
        {
            double valueOne = this.quantityMeasurement.GetValue(1.0, QuantityMeasurement.BaseUnits.Units.GALLON);
            double valueTwo = this.quantityMeasurement.GetValue(3.78, QuantityMeasurement.BaseUnits.Units.LITRE);
            Assert.AreEqual(valueOne + valueTwo, 7.56);
        }

        /// <summary>
        /// Test 1.1: add values.
        /// </summary>
        [Test]
        public void GivenOneLiterandThousandML_WhenAdded_ShouldReturnCorrectResult()
        {
            double valueOne = this.quantityMeasurement.GetValue(1.0, QuantityMeasurement.BaseUnits.Units.LITRE);
            double valueTwo = this.quantityMeasurement.GetValue(1000.0, QuantityMeasurement.BaseUnits.Units.GRAMS);
            Assert.AreEqual(2, valueOne + valueTwo);
        }

        /// <summary>
        /// Test 1.1: check one kg is thousand grams.
        /// </summary>
        [Test]
        public void GivenOneKGandThousandGrams_WhenAdded_ShouldReturnCorrectResult()
        {
            double valueOne = this.quantityMeasurement.GetValue(1.0, QuantityMeasurement.BaseUnits.Units.KG);
            double valueTwo = this.quantityMeasurement.GetValue(1000.0, QuantityMeasurement.BaseUnits.Units.GRAMS);
            Assert.AreEqual( valueOne , valueTwo);
        }

        /// <summary>
        /// Test 1.1: check one kg is thousand grams.
        /// </summary>
        [Test]
        public void GivenOneTonneandThousandKgs_WhenAdded_ShouldReturnCorrectResult()
        {
            double valueOne = this.quantityMeasurement.GetValue(1.0, QuantityMeasurement.BaseUnits.Units.TONNE);
            double valueTwo = this.quantityMeasurement.GetValue(1000.0, QuantityMeasurement.BaseUnits.Units.KG);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Test 1.1: check one kg is thousand grams.
        /// </summary>
        [Test]
        public void GivenOneTonneandThousandGrams_WhenAdded_ShouldReturnCorrectResult()
        {
            double valueOne = this.quantityMeasurement.GetValue(1.0, QuantityMeasurement.BaseUnits.Units.TONNE);
            double valueTwo = this.quantityMeasurement.GetValue(1000.0, QuantityMeasurement.BaseUnits.Units.GRAMS);
            Assert.AreEqual(1001, valueOne + valueTwo);
        }
    }
}