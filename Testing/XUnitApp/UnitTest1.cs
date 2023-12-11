using Xunit; 

namespace XUnitApp
{
    public class UnitTest1
    {
        [Fact]
        [Trait("Category A", "Group 1")]
        public void Test_Add()
        {
            //Arrange
            int a = 100;
            int b = 200;
            //Act
            var result = Add(a, b);
            //Assert
            Assert.Equal(300, result);
        }
        [Theory]
        [InlineData(100,200,300)]
        [InlineData(200,-200,0)]

        public void Test_Add_With_Multiple_Inputs(int a, int b, int expected)
        {
            //Act
            var actual = Add(a, b);
            //Assert
            Assert.Equal(expected, actual);
        }

        public int Add(int n1, int n2)
        {
            return n1 + n2;
        }
    }
}