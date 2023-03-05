using Lacuna.Dev.Ingresso.LacunaGenetics.Entities.Request;
using Lacuna.Dev.Ingresso.LacunaGenetics.Enum;

namespace Lacuna.Dev.Ingresso.LacunaGenetics.UnitTest.Application.Entities.Request
{
    public class RequestOperationTest
    {
        [Fact]
        public void GetAddress_ReturnAddress_True()
        {
            //Arrange
            string expected = "/api/dna/jobs";
            RequestOperation requestOp = new RequestOperation();
            //Act
            string result = requestOp.GetAddress();
            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetAddress_ReturnAddress_False()
        {
            //Arrange
            string expected = "/api/dna/jobs_";
            RequestOperation requestOp = new RequestOperation();
            //Act
            string result = requestOp.GetAddress();
            //Assert
            Assert.NotEqual(expected, result);
        }

        [Fact]
        public void GetTypeHttpRequest_ReturnHttpPost_True()
        {
            //Arrange
            TypeEnum expected = TypeEnum.HttpGet;
            RequestOperation requestOp = new RequestOperation();
            //Act
            TypeEnum result = requestOp.GetTypeHttpRequest();
            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetTypeHttpRequest_ReturnHttpPost_False()
        {
            //Arrange
            TypeEnum expected = TypeEnum.HttpPost;
            RequestOperation requestOp = new RequestOperation();
            //Act
            TypeEnum result = requestOp.GetTypeHttpRequest();
            //Assert
            Assert.NotEqual(expected, result);
        }
    }
}
