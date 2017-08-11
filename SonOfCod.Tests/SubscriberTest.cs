using SonOfCod.Models;
using Xunit;


namespace SonOfCod.Tests
{
    public class SubscriberTest
    {
        [Fact]
        public void GetDescriptionTest()
        {
            //Arrange
            var subscriber = new Subscriber();

            //Act
            var firstNameResult = subscriber.FirstName = "Indrid";
            var lastNameResult = subscriber.LastName = "Cold";
            var companyNameResult = subscriber.CompanyName = "Company Inc.";

            //Assert
            Assert.Equal("Indrid", firstNameResult);
            Assert.Equal("Cold", lastNameResult);
            Assert.Equal("Company Inc.", companyNameResult);
        }
    }
}
