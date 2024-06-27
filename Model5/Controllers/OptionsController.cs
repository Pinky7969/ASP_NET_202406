using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Model5.Models;

namespace Model5.Controllers;
[Route("api/[controller]")]
[ApiController]
public class OptionsController(IOptionsSnapshot<WebsiteProfileOptions> _options) : ControllerBase
{ 
    [HttpGet]
    public WebsiteProfileOptions Get()
    { 
       return _options.Value;
    }
}
