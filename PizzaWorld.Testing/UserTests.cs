using Xunit;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Testing
{
    public class UserTests
    {
        [Fact]
        private void Test_UserExists()
        {
            //arrange
            var sut = new User();  // inference (Using var instead of explicitly using Order)
            // Order sut = new Order(); ---- this is a statement and uses memory allocation. Writing like this is not optimal performance

           //act
            var actual = sut;

           //assert
            Assert.IsType<User>(actual);
            Assert.NotNull(actual);
        }
    }
}