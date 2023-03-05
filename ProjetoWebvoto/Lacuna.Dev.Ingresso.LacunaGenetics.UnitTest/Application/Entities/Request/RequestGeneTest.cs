using Lacuna.Dev.Ingresso.LacunaGenetics.Entities.Request;
using Lacuna.Dev.Ingresso.LacunaGenetics.Enum;

namespace Lacuna.Dev.Ingresso.LacunaGenetics.UnitTest.Application.Entities.Request
{
    public class RequestGeneTest
    {
        [Fact]
        public void GetAddress_ReturnAddress_True()
        {
            //Arrange
            string expected = "/api/dna/jobs/{id}/gene";
            RequestGene requestGene = new RequestGene();
            //Act
            string result = requestGene.GetAddress();
            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetAddress_ReturnAddress_False()
        {
            //Arrange
            string expected = "/api/dna/jobs/{id}/gene_";
            RequestGene requestGene = new RequestGene();
            //Act
            string result = requestGene.GetAddress();
            //Assert
            Assert.NotEqual(expected, result);
        }

        [Fact]
        public void GetTypeHttpRequest_ReturnHttpPost_True()
        {
            //Arrange
            TypeEnum expected = TypeEnum.HttpPost;
            RequestGene requestGene = new RequestGene();
            //Act
            TypeEnum result = requestGene.GetTypeHttpRequest();
            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetTypeHttpRequest_ReturnHttpPost_False()
        {
            //Arrange
            TypeEnum expected = TypeEnum.HttpGet;
            RequestGene requestGene = new RequestGene();
            //Act
            TypeEnum result = requestGene.GetTypeHttpRequest();
            //Assert
            Assert.NotEqual(expected, result);
        }
    }
}
