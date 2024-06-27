using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Model5.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ErrorController : ControllerBase
{
    //[HttpGet]
    //public IActionResult Get() => Problem();

    [HttpGet]
    public IActionResult Get()
    {
        var feature = HttpContext.Features.Get<IExceptionHandlerFeature>();
        if (feature == null)
            return Problem();
        return Problem(title: feature.Error.Message);
    }
}
