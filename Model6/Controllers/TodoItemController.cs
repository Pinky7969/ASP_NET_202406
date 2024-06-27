using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model6.Models;

namespace Model6.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TodoItemController : ControllerBase
{
    [HttpGet]
    public TodoItem Get()
    {
        return new TodoItem{ Id = 999, Name = "Item 01", IsComplete = true };
    }
}
