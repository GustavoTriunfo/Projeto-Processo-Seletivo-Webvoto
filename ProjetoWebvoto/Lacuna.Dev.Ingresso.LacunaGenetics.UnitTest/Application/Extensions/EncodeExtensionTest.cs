using Lacuna.Dev.Ingresso.LacunaGenetics.Application.Extensions;
using Lacuna.Dev.Ingresso.LacunaGenetics.Entities.Request;

namespace Lacuna.Dev.Ingresso.LacunaGenetics.UnitTest.Application.Extensions
{
    public class EncodeExtensionTest
    {
        [Fact]
        public void ExecuteEncode_ReturnString_True()
        {
            //Arrange
            string expected = "VGV4dEV4YW1wbGU=";
            string text = "TextExample";
            string result;
            //Act
            result = text.ExecuteEncode();
            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ExecuteEncode_ReturnString_False()
        {
            //Arrange
            string expected = "VGV4dEV4YW1wbGU==";
            string text = "TextExample";
            string result;
            //Act
            result = text.ExecuteEncode();
            //Assert
            Assert.NotEqual(expected, result);
        }
    }
}
