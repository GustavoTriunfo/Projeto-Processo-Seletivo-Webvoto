using Lacuna.Dev.Ingresso.LacunaGenetics.Application.Extensions;
using Lacuna.Dev.Ingresso.LacunaGenetics.Entities.Request;

namespace Lacuna.Dev.Ingresso.LacunaGenetics.UnitTest.Application.Extensions
{
    public class DecodeExtensionTest
    {
        [Fact]
        public void ExecuteDecode_ReturnString_True()
        {
            //Arrange
            string expected = "TextExample";
            string code = "VGV4dEV4YW1wbGU=";
            string result;
            //Act
            result = code.ExecuteDecode();
            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ExecuteDecode_ReturnString_False()
        {
            //Arrange
            string expected = "TextExamples";
            string code = "VGV4dEV4YW1wbGU=";
            string result;
            //Act
            result = code.ExecuteDecode();
            //Assert
            Assert.NotEqual(expected, result);
        }
    }
}
