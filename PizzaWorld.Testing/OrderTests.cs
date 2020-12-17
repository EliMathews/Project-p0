using Xunit;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Testing
{
    public class OrderTests
    {
        [Fact]
        private void Test_OrderExists()
        {
            //arrange
            var sut = new Order();  // inference (Using var instead of explicitly using Order)
            // Order sut = new Order(); ---- this is a statement and uses memory allocation. Writing like this is not optimal performance

           //act
            var actual = sut;

           //assert
            Assert.IsType<Order>(actual);
            Assert.NotNull(actual);
        }
    }
}