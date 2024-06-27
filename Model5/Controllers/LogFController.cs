using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Model5.Controllers;
[Route("api/[controller]")]
[ApiController]
public class LogFController(ILoggerFactory factory) : ControllerBase
{
    readonly ILogger _logger = factory.CreateLogger("MyLog");

    [HttpGet]
    public IActionResult Get()
    {
        _logger.LogInformation("Informtion log.");
        return Ok("LogFController Get() calleds");
    }

    [HttpGet("level")]
    public IActionResult Level()
    {
        _logger.LogCritical("Log Message - Critical");
        _logger.LogError("Log Message - Error");
        _logger.LogWarning("Log Message - Warning");
        _logger.LogInformation("Log Message - Information");
        _logger.LogDebug("Log Message - Debug");
        _logger.LogTrace("Log Message - Trace");

        return Ok("Level method called");
    }

    [HttpGet("level2")]
    public IActionResult Level2()
    {
        _logger.LogCritical("Log Message - Critical:{path}, {scheme}, {Protocol}", Request.Path, Request.Scheme, Request.Protocol);
        _logger.LogError("Log Message - Error:{path}", Request.Path);
        _logger.LogWarning("Log Message - Warning:{path}", Request.Path);
        _logger.LogInformation("Log Message - Information:{path}", Request.Path);
        _logger.LogDebug("Log Message - Debug:{path}", Request.Path);
        _logger.LogTrace("Log Message - Trace:{path}", Request.Path);
        return Ok("Level method called");
    }
}
