using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model6.Data;
using Model6.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Model6.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TodoItemsController(TodoContext _context) : ControllerBase
{
    // GET: api/<TodoItemsController>
    [HttpGet]
    public async Task<IEnumerable<TodoItem>> Get()
    {
        return await _context.TodoItems.ToListAsync();
    }

    // GET api/<TodoItemsController>/5
    [HttpGet("{id}")]
    public async Task<ActionResult<TodoItem>> Get(int id)
    {
        var item = await _context.TodoItems.FindAsync(id);
        if (item == null) { 
            return NotFound();
        }
        return item;
    }

    // POST api/<TodoItemsController>
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] TodoItem todoItem)
    {
        _context.TodoItems.Add(todoItem);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(Get), new { id = todoItem.Id }, todoItem);
    }

    // PUT api/<TodoItemsController>/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, [FromBody] TodoItem todoItem)
    {
        if (id != todoItem.Id) { 
            return BadRequest();
        }
        _context.Update(todoItem);
        await _context.SaveChangesAsync();
        return NoContent();
    }

    // DELETE api/<TodoItemsController>/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var todoItem = await _context.TodoItems.FindAsync(id);
        if (todoItem == null) {
            return NotFound();
        }
        _context.TodoItems.Remove(todoItem);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
