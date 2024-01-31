using System.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserTestAPI.Data;
using UserTestAPI.Models;

namespace UserTestAPI.Controllers;

[ApiController]
[Route("api/journal")]
public class JournalController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly ILogger<JournalController> _logger;

    public JournalController(ApplicationDbContext context, ILogger<JournalController> logger)
    {
        _context = context;
        _logger = logger;
    }

    [HttpGet]
    public async Task<IActionResult> GetRange()
    {
        var entities = await _context.JournalExceptions.ToListAsync();
        return Ok(entities);
    }
}

