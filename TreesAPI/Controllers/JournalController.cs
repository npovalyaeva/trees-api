using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TreesAPI.Models;
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

    [HttpGet("{id}")]
    [ProducesResponseType(typeof(JournalException), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(CustomException), StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<JournalException>> GetSingle(long id)
    {
        var entity = await _context.JournalExceptions.FindAsync(id);

        if (entity == null)
            throw new CustomException("The record with such ID does not exist.");

        return entity;
    }

    [HttpGet]
    [ProducesResponseType(typeof(IReadOnlyCollection<JournalException>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(CustomException), StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<IReadOnlyCollection<JournalException>>> GetRange()
    {
        var entities = await _context.JournalExceptions.ToListAsync();
        return entities;
    }
}

