using NUnit.Framework;
using System;

namespace NegyzetNevter.Tests
{
    [TestFixture]
    public class NegyzetTests
    {
        private Negyzet _negyzet;

        [SetUp]
        public void SetUp()
        {
            _negyzet = new Negyzet(4);
        }

        [Test]
        public void Oldalhossz_InitialValue_ReturnsCorrectValue()
        {
            //Összes AreEqual helyett Assert.That
            //Assert.AreEqual(4, _negyzet.Oldalhossz);
            Assert.That(_negyzet.Oldalhossz, Is.EqualTo(4));
        }

        [Test]
        public void Oldalhossz_SetNewValue_ChangesValue()
        {
            _negyzet.Oldalhossz = 6;

            Assert.That(_negyzet.Oldalhossz, Is.EqualTo(6));
        }

        [Test]
        public void Atlo_CorrectCalculation_ReturnsCorrectValue()
        {
            double expectedAtlo = 4 * Math.Sqrt(2);
            Assert.That(_negyzet.Atlo, Is.EqualTo(expectedAtlo).Within(0.0001)); // Tûrési érték
        }

        [Test]
        public void Kerulet_CorrectCalculation_ReturnsCorrectValue()
        {
            double expectedKerulet = 4 * 4;
            Assert.That(_negyzet.Kerulet(), Is.EqualTo(expectedKerulet));
        }

        [Test]
        public void Terulet_CorrectCalculation_ReturnsCorrectValue()
        {
            double expectedTerulet = 4 * 4;
            Assert.That(_negyzet.Terulet(), Is.EqualTo(expectedTerulet));
        }

        [Test]
        public void TeglatestTerfogata_CorrectCalculation_ReturnsCorrectValue()
        {
            double magassag = 10;
            double expectedTeglatestTerfogata = _negyzet.Terulet() * magassag;
            Assert.That(_negyzet.TeglatestTerfogata(magassag), Is.EqualTo(expectedTeglatestTerfogata));
        }

        [Test]
        public void TeglatestTerfogata_InvalidMagassag_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _negyzet.TeglatestTerfogata(0));
            Assert.Throws<ArgumentException>(() => _negyzet.TeglatestTerfogata(-5));
        }
    }
}
