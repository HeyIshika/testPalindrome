using System;
using PalinDromeApp;
using Xunit;

namespace PalinTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            Palindrom objPalindrom=new Palindrom();
            
            //Act
            bool result = objPalindrom.IsPalindrom("redivider");

            //Assert
            Assert.IsType<bool>(result);
            Assert.True(result);

            bool resultNegative = objPalindrom.IsPalindrom("test");
            Assert.False(resultNegative);


        }
    }
}
