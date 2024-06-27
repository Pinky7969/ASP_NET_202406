using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Model5.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ValuesController : ControllerBase
{
    [HttpGet("throw")]
    public IActionResult Throw()
    { 
        throw new Exception("This is test exception");
    }
}
