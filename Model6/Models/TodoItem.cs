using System.ComponentModel.DataAnnotations;

namespace Model6.Models;

public class TodoItem
{
    public int Id { get; set; }
    [StringLength(100)]
    public required string Name { get; set; }
    public bool IsComplete { get; set; }

}

