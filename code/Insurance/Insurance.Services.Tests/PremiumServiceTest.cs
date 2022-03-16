using Insurance.Services;
using Moq;
using NUnit.Framework;
using System;

namespace Insurance.Services.Tests
{
    [TestFixture]
    public class PremiumServiceTest
    {
        Mock<IRatingService> _mockRatingSerivce;

        [SetUp]
        public void SetUp()
        {
            _mockRatingSerivce = new Mock<IRatingService>(MockBehavior.Strict);

        }

        [Test]
        public void UT_Validate_MontlyPremium_HappyPath()
        {
            //Arrange
            int age = 38;
            string occupation = "Professional";
            double premium = 1000;
            _mockRatingSerivce.Setup(p => p.GetRating(occupation)).Returns(100);
            var premiumService = new PremiumService(_mockRatingSerivce.Object);
            //Act
            var totalPremium = premiumService.Calculate(age, occupation, premium);
            //Assert
            Assert.NotZero(totalPremium.TotalMonthlyPremium);
        }
        [Test]
        public void UT_Validate_MontlyPremium_Check_ArgumetException()
        {
            //Arrange
            int age = 0;
            string occupation = "Professional";
            double premium = 1000;
            _mockRatingSerivce.Setup(p => p.GetRating(occupation)).Returns(1000);
            var premiumService = new PremiumService(_mockRatingSerivce.Object);
            //Act Assert
            Assert.That(() => premiumService.Calculate(age, occupation, premium), Throws.TypeOf<ArgumentException>());

        }
        [Test]
        public void UT_Validate_MontlyPremium_Check_ArgumetOutOfRangeException()
        {
            //Arrange
            int age = 38;
            string occupation = "Test";
            double premium = 1000;
            _mockRatingSerivce.Setup(p => p.GetRating(occupation)).Returns(0);
            var premiumService = new PremiumService(_mockRatingSerivce.Object);
            //Act Assert
            Assert.That(() => premiumService.Calculate(age, occupation, premium), Throws.TypeOf<ArgumentOutOfRangeException>());

        }
    }
}
