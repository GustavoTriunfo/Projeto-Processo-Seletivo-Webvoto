
using Lacuna.Dev.Ingresso.LacunaGenetics.Entities.Request;
using Lacuna.Dev.Ingresso.LacunaGenetics.Enum;

namespace Lacuna.Dev.Ingresso.LacunaGenetics.UnitTest.Application.Entities.Request
{
    public class RequestUserTest
    {
        [Fact]
        public void GetAddress_ReturnAddress_True()
        {
            //Arrange
            string expected = "/api/users/create";
            RequestUser requestUser = new RequestUser();
            //Act
            string result = requestUser.GetAddress();
            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetAddress_ReturnAddress_False()
        {
            //Arrange
            string expected = "/api/users/Create";
            RequestUser requestUser = new RequestUser();
            //Act
            string result = requestUser.GetAddress();
            //Assert
            Assert.NotEqual(expected, result);
        }

        [Fact]
        public void GetTypeHttpRequest_ReturnHttpPost_True()
        {
            //Arrange
            TypeEnum expected = TypeEnum.HttpPost;
            RequestUser requestUser = new RequestUser();
            //Act
            TypeEnum result = requestUser.GetTypeHttpRequest();
            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetTypeHttpRequest_ReturnHttpPost_False()
        {
            //Arrange
            TypeEnum expected = TypeEnum.HttpGet;
            RequestUser requestUser = new RequestUser();
            //Act
            TypeEnum result = requestUser.GetTypeHttpRequest();
            //Assert
            Assert.NotEqual(expected, result);
        }
    }
}
