using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class MyTableController : ControllerBase
{
    private readonly AppDbContext _context;

    public MyTableController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var items = _context.MyTables.ToList();
        return Ok(items);
    }

    [HttpGet("title")]
    public IActionResult SearchByTitle(string title)
    {
        var results = _context.MyTables
            .Where(x => x.Title == title)
            .ToList();
        return Ok(results);
    }

    [HttpGet("director")]
    public IActionResult SearchByDirector(string director)
    {
        var results = _context.MyTables
            .Where(x => x.Director == director)
            .ToList();
        return Ok(results);
    }

    [HttpGet("cast")]
    public IActionResult SearchByCast(string cast)
    {
        var results = _context.MyTables
            .Where(x => x.Cast.Contains(cast))
            .ToList();
        return Ok(results);
    }
}