using Xunit;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Testing
{
    public class StoreTests
    {
        [Fact]
        private void Test_StoreExists()
        {
            //arrange
            var sut = new Store();  // inference (Using var instead of explicitly using Order)
            // Order sut = new Order(); ---- this is a statement and uses memory allocation. Writing like this is not optimal performance

           //act
            var actual = sut;

           //assert
            Assert.IsType<Store>(actual);
            Assert.NotNull(actual);
        }
    }
}