using CoreExperiment.Core;
using Moq;

namespace CoreExperiment.Test
{
    public class UnitTest1
    {
        private readonly Mock<ICustomLogger> _logger;

        public UnitTest1()
        {
            _logger = new Mock<ICustomLogger>();
        }

        [Fact]
        public void Test_EmailValidator_ShouldReturnTrue_WhenValidEmail()
        {
            // Arrange
            var validator = new EmailValidator(_logger.Object);
            string email = "joe@example.com";

            // Act
            bool result = validator.IsEmail(email);
            
            // Assert
            Assert.True(result);
            Assert.Single(_logger.Invocations);
            Assert.Equal(_logger.Invocations[0].Arguments[0], "IsEmail");
        }
    }
}
