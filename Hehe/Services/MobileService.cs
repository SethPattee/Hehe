using System.Net.Http.Json;
using Hehe.classlib;

namespace Hehe.Services;

internal class MobileService : IService
{
    HttpClient httpClient = new();
    public async Task<int> Add(int b)
    {
        return await httpClient.GetFromJsonAsync<int>($"https://localhost:7042/Math?b={b}");
    }
}
