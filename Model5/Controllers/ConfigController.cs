using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model5.Models;

namespace Model5.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ConfigController(IConfiguration _configuration) : ControllerBase
{
    [HttpGet]
    public string? Get() => _configuration["themecolor"];

    [HttpGet("Default")]
    public string? Default() => _configuration["logging:loglevel:default"];

    [HttpGet("Bind")]
    public WebsiteProfileOptions? Bind() {
        WebsiteProfileOptions options = new();
        _configuration.Bind(options);
        return options;
    }

    [HttpGet("Section")]
    public WebsiteProfileOptions? Section()
    {
        WebsiteProfileOptions options = new();
        _configuration.GetSection("SectionA:SectionB").Bind(options);
        return options;
    }
}
