using Hehe.classlib;
using Microsoft.AspNetCore.Mvc;

namespace Hehe.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MathController : Controller
    {
        IService _service;
        public MathController(IService service)
        {
            _service = service;
        }

        [HttpGet("{b}")]
        public async Task<int> Get(int b)
        {
            return await _service.Add(b);
        }
    }
}