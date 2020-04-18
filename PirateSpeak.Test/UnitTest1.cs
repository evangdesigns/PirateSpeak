using System;
using Xunit;

namespace PirateSpeak.Test
{
    public class UnitTest1
    {
        [Fact]
        public void GiverishOne()
        {
            //Arrange
            var giberish = "ortsp";
            var expectedResult = "sport";
            var translator = new Translator();

            //Act
            var actualResult = translator.Translate(giberish);

            //Assert
            Assert.Equal(expectedResult, actualResult);

        }
    }
}
