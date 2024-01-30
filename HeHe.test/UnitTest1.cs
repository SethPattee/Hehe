using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http.Json;
namespace HeHe.test
{
    public class UnitTest1 : IClassFixture<AdditionFactory>
    {
        public UnitTest1(AdditionFactory _factory)
        {
            _client = _factory.CreateDefaultClient();
            
        }

        public HttpClient _client { get; set; }

        [Fact]
        public async void Test1()
        {
            //Arrange
            int b = 1;

            //Act

            var product = await _client.GetFromJsonAsync<int>($"Math/{b}");

            //Assert
            Assert.NotNull(product);
            Assert.Equal(2, product);
        }
    }
}