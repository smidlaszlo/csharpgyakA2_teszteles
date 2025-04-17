using System;
using Xunit;

namespace NegyzetNevter.Tests
{
    public class NegyzetTests
    {
        private Negyzet _negyzet;

        // A tesztek elõtt minden alkalommal inicializáljuk a Negyzet osztályt
        public NegyzetTests()
        {
            _negyzet = new Negyzet(4);
        }

        [Fact]
        public void Oldalhossz_InitialValue_ReturnsCorrectValue()
        {
            Assert.Equal(4, _negyzet.Oldalhossz);
        }

        [Fact]
        public void Oldalhossz_SetNewValue_ChangesValue()
        {
            _negyzet.Oldalhossz = 6;

            Assert.Equal(6, _negyzet.Oldalhossz);
        }

        [Fact]
        public void Atlo_CorrectCalculation_ReturnsCorrectValue()
        {
            double expectedAtlo = 4 * Math.Sqrt(2);
            Assert.Equal(expectedAtlo, _negyzet.Atlo, 0.0001); // Tûrési értékkel
        }

        [Fact]
        public void Kerulet_CorrectCalculation_ReturnsCorrectValue()
        {
            double expectedKerulet = 4 * 4;
            Assert.Equal(expectedKerulet, _negyzet.Kerulet());
        }

        [Fact]
        public void Terulet_CorrectCalculation_ReturnsCorrectValue()
        {
            double expectedTerulet = 4 * 4;
            Assert.Equal(expectedTerulet, _negyzet.Terulet());
        }

        [Fact]
        public void TeglatestTerfogata_CorrectCalculation_ReturnsCorrectValue()
        {
            double magassag = 10;
            double expectedTeglatestTerfogata = _negyzet.Terulet() * magassag;
            Assert.Equal(expectedTeglatestTerfogata, _negyzet.TeglatestTerfogata(magassag));
        }

        [Fact]
        public void TeglatestTerfogata_InvalidMagassag_ThrowsArgumentException()
        {
            // Ha a magasság 0 vagy kisebb, akkor ArgumentException kivételt kell dobni
            Assert.Throws<ArgumentException>(() => _negyzet.TeglatestTerfogata(0));
            Assert.Throws<ArgumentException>(() => _negyzet.TeglatestTerfogata(-5));
        }
    }
}
