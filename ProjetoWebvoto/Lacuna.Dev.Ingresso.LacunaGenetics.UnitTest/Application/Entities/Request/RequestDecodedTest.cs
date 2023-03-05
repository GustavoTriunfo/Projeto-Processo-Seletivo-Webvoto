using Lacuna.Dev.Ingresso.LacunaGenetics.Entities.Request;
using Lacuna.Dev.Ingresso.LacunaGenetics.Enum;

namespace Lacuna.Dev.Ingresso.LacunaGenetics.UnitTest.Application.Entities.Request
{
    
    public class RequestDecodedTest
    {
        [Fact]
        public void GetAddress_ReturnAddress_True()
        {
            //Arrange
            string expected = "/api/dna/jobs/{id}/decode";
            RequestDecoded requestDecoded = new RequestDecoded();
            //Act
            string result = requestDecoded.GetAddress();
            //Assert
            Assert.Equal(expected,result);
        }

        [Fact]
        public void GetAddress_ReturnAddress_False()
        {
            //Arrange
            string expected = "/api/dna/jobs/{id}/decode/";
            RequestDecoded requestDecoded = new RequestDecoded();
            //Act
            string result = requestDecoded.GetAddress();
            //Assert
            Assert.NotEqual(expected, result);
        }

        [Fact]
        public void GetTypeHttpRequest_ReturnHttpPost_True()
        {
            //Arrange
            TypeEnum expected = TypeEnum.HttpPost;
            RequestDecoded requestDecoded = new RequestDecoded();
            //Act
            TypeEnum result = requestDecoded.GetTypeHttpRequest();
            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetTypeHttpRequest_ReturnHttpPost_False()
        {
            //Arrange
            TypeEnum expected = TypeEnum.HttpGet;
            RequestDecoded requestDecoded = new RequestDecoded();
            //Act
            TypeEnum result = requestDecoded.GetTypeHttpRequest();
            //Assert
            Assert.NotEqual(expected, result);
        }

    }
}
