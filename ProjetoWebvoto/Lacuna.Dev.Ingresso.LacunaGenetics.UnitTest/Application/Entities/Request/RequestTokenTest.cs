using Lacuna.Dev.Ingresso.LacunaGenetics.Entities.Request;
using Lacuna.Dev.Ingresso.LacunaGenetics.Enum;

namespace Lacuna.Dev.Ingresso.LacunaGenetics.UnitTest.Application.Entities.Request
{
    public class RequestTokenTest
    {
        [Fact]
        public void GetAddress_ReturnAddress_True()
        {
            //Arrange
            string expected = "/api/users/login";
            RequestToken requestToken = new RequestToken();
            //Act
            string result = requestToken.GetAddress();
            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetAddress_ReturnAddress_False()
        {
            //Arrange
            string expected = "/api/users/login_";
            RequestToken requestToken = new RequestToken();
            //Act
            string result = requestToken.GetAddress();
            //Assert
            Assert.NotEqual(expected, result);
        }

        [Fact]
        public void GetTypeHttpRequest_ReturnHttpPost_True()
        {
            //Arrange
            TypeEnum expected = TypeEnum.HttpPost;
            RequestToken requestToken = new RequestToken();
            //Act
            TypeEnum result = requestToken.GetTypeHttpRequest();
            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetTypeHttpRequest_ReturnHttpPost_False()
        {
            //Arrange
            TypeEnum expected = TypeEnum.HttpGet;
            RequestToken requestToken = new RequestToken();
            //Act
            TypeEnum result = requestToken.GetTypeHttpRequest();
            //Assert
            Assert.NotEqual(expected, result);
        }
    }
}
