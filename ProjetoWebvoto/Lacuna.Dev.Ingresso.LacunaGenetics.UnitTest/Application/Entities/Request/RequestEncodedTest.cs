using Lacuna.Dev.Ingresso.LacunaGenetics.Entities.Request;
using Lacuna.Dev.Ingresso.LacunaGenetics.Enum;

namespace Lacuna.Dev.Ingresso.LacunaGenetics.UnitTest.Application.Entities.Request
{
    public class RequestEncodedTest
    {
        [Fact]
        public void GetAddress_ReturnAddress_True()
        {
            //Arrange
            string expected = "/api/dna/jobs/{id}/encode";
            RequestEncoded requestEncoded = new RequestEncoded();
            //Act
            string result = requestEncoded.GetAddress();
            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetAddress_ReturnAddress_False()
        {
            //Arrange
            string expected = "/api/dna/jobs/{id}/encode/";
            RequestEncoded requestEncoded = new RequestEncoded();
            //Act
            string result = requestEncoded.GetAddress();
            //Assert
            Assert.NotEqual(expected, result);
        }

        [Fact]
        public void GetTypeHttpRequest_ReturnHttpPost_True()
        {
            //Arrange
            TypeEnum expected = TypeEnum.HttpPost;
            RequestEncoded requestEncoded = new RequestEncoded();
            //Act
            TypeEnum result = requestEncoded.GetTypeHttpRequest();
            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetTypeHttpRequest_ReturnHttpPost_False()
        {
            //Arrange
            TypeEnum expected = TypeEnum.HttpGet;
            RequestEncoded requestEncoded = new RequestEncoded();
            //Act
            TypeEnum result = requestEncoded.GetTypeHttpRequest();
            //Assert
            Assert.NotEqual(expected, result);
        }
    }
}
