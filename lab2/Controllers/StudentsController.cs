using Microsoft.AspNetCore.Mvc;

namespace lab2.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentsController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<StudentsController> _logger;

    public StudentsController(ILogger<StudentsController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetStudents")]
    public IEnumerable<Student> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Student
        {
            Id = Random.Shared.Next(-20, 55),
            Name = "Cristi"
        })
        .ToArray();
    }
}
