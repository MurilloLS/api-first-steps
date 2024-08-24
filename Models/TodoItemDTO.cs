using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models;

public class TodoItemDto
{
    public Guid Id { get; set;}

    [Required(ErrorMessage = "The Name field is required.")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "The Name must be between 3 and 100 characters long.")]
    public string? Name { get; set; }
    public bool IsComplete { get; set; }
}