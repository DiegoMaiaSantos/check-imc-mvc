using Check_IMC.Controllers;
using Check_IMC.Interfaces;
using Check_IMC.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace Check_IMC.Tests
{
    public class ImcControllerTests
    {
        [Fact]
        public void ImcCalculator_ShouldReturnResultView_WithCorrectData()
        {
            // Arrange
            var mockService = new Mock<IImcService>();

            var model = new ImcModel 
            { 
                Weight = 70, 
                Height = 1.75 
            };

            mockService.Setup(s => s.CalculatingIMC(model)).Returns(22.86);
            mockService.Setup(s => s.ImcResult(22.86)).Returns("Normal");

            var controller = new ImcController(mockService.Object);

            // Act
            var result = controller.ImcCalculator(model) as ViewResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Result", result.ViewName);
            Assert.Equal("Normal", result.Model);
        }
    }
}
