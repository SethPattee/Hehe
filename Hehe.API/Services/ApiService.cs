using Hehe.classlib;
namespace Hehe.API.Services
{
    public class ApiService : IService
    {
        public int number { get; set; } = 1;
        public Task<int> Add(int b) => Task.FromResult(number + b);
    }
}
