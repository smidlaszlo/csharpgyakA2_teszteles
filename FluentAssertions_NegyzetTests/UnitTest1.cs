using System;
using FluentAssertions;
using Xunit;

namespace NegyzetNevter.Tests
{
    public class NegyzetTests
    {
        private Negyzet _negyzet;

        public NegyzetTests()
        {
            _negyzet = new Negyzet(4);
        }

        [Fact]
        public void Oldalhossz_InitialValue_ReturnsCorrectValue()
        {
            _negyzet.Oldalhossz.Should().Be(4);
        }

        [Fact]
        public void Oldalhossz_SetNewValue_ChangesValue()
        {
            _negyzet.Oldalhossz = 6;

            _negyzet.Oldalhossz.Should().Be(6);
        }

        [Fact]
        public void Atlo_CorrectCalculation_ReturnsCorrectValue()
        {
            double expectedAtlo = 4 * Math.Sqrt(2);
            _negyzet.Atlo.Should().BeApproximately(expectedAtlo, 0.0001);
        }

        [Fact]
        public void Kerulet_CorrectCalculation_ReturnsCorrectValue()
        {
            double expectedKerulet = 4 * 4;
            _negyzet.Kerulet().Should().Be(expectedKerulet);
        }

        [Fact]
        public void Terulet_CorrectCalculation_ReturnsCorrectValue()
        {
            double expectedTerulet = 4 * 4;
            _negyzet.Terulet().Should().Be(expectedTerulet);
        }

        [Fact]
        public void TeglatestTerfogata_CorrectCalculation_ReturnsCorrectValue()
        {
            double magassag = 10;
            double expectedTeglatestTerfogata = _negyzet.Terulet() * magassag;
            _negyzet.TeglatestTerfogata(magassag).Should().Be(expectedTeglatestTerfogata);
        }

        [Fact]
        public void TeglatestTerfogata_InvalidMagassag_ThrowsArgumentException()
        {
            Action act = () => _negyzet.TeglatestTerfogata(0);
            act.Should().Throw<ArgumentException>().WithMessage("A magasságnak 0-nál nagyobbnak kell lennie!");

            act = () => _negyzet.TeglatestTerfogata(-5);
            act.Should().Throw<ArgumentException>().WithMessage("A magasságnak 0-nál nagyobbnak kell lennie!");
        }
    }
}
