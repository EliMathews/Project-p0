using Xunit;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Testing
{
    public class PizzaTests
    {
        [Fact]
        private void Test_PizzaExists()
        {
            //arrange
            var sut = new Pizza();  // inference (Using var instead of explicitly using Order)
            // Order sut = new Order(); ---- this is a statement and uses memory allocation. Writing like this is not optimal performance

           //act
            var actual = sut;

           //assert
            Assert.IsType<Pizza>(actual);
            Assert.NotNull(actual);
        }
    }
}