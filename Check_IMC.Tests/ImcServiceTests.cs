using Check_IMC.Models;
using Check_IMC.Services;
using Xunit;

namespace Check_IMC.Tests
{
    public class ImcServiceTests
    {
        private readonly ImcService _service;

        public ImcServiceTests()
        {
            _service = new ImcService();
        }

        [Theory]
        [InlineData(70, 1.75, 22.86)]
        [InlineData(90, 1.80, 27.78)]
        public void CalculatingIMC_ShouldReturnCorrectIMC(double peso, double altura, double expected)
        {
            var model = new ImcModel 
            { 
                Weight = peso, 
                Height = altura 
            };

            var result = _service.CalculatingIMC(model);
            Assert.Equal(expected, result, 2);
        }

        [Fact]
        public void CalculatingIMC_WithZeroValues_ShouldThrowException()
        {
            var model = new ImcModel 
            {
                Weight = 0, 
                Height = 1.75 
            };

            Assert.Throws<ArgumentException>(() => _service.CalculatingIMC(model));
        }

        [Theory]
        [InlineData(17.0, "Magreza")]
        [InlineData(22.0, "Normal")]
        [InlineData(27.0, "Sobrepeso")]
        [InlineData(31.0, "Obesidade")]
        public void ImcResult_ShouldReturnCorrectCategory(double imc, string expected)
        {
            var result = _service.ImcResult(imc);
            Assert.Equal(expected, result);
        }
    }
}
