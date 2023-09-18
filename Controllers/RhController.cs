using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/[controller]")]
public class RhController : ControllerBase
{
    private readonly MongoDBContext _context;

    public RhController(MongoDBContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IEnumerable<Rh>> Get()
    {
        return await _context.Pessoas.Find(_ => true).ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Rh>> GetById(string id)
    {
        var pessoa = await _context.Pessoas.Find(p => p.Id == id).FirstOrDefaultAsync();

        if (pessoa == null)
        {
            return NotFound();
        }

        return pessoa;
    }

    [HttpGet("data")]
    public async Task<ActionResult<List<Estoque>>> GetByDate(string Mes, int Ano)
    {
        var product = await _context.Products.Find(p => p.Mes == Mes && p.Ano == Ano).ToListAsync();

        if (product == null)
        {
            return NotFound();
        }

        return product;
    }

    [HttpPost]
    public async Task<ActionResult<Rh>> Create(Rh pessoa)
    {
        await _context.Pessoas.InsertOneAsync(pessoa);
        return CreatedAtRoute(new { id = pessoa.Id }, pessoa);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(string id, Rh pessoaIn)
    {
        var pessoa = await _context.Pessoas.Find(p => p.Id == id).FirstOrDefaultAsync();

        if (pessoa == null)
        {
            return NotFound();
        }

        await _context.Pessoas.ReplaceOneAsync(p => p.Id == id, pessoaIn);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        var pessoa = await _context.Pessoas.Find(p => p.Id == id).FirstOrDefaultAsync();

        if (pessoa == null)
        {
            return NotFound();
        }

        await _context.Pessoas.DeleteOneAsync(p => p.Id == id);

        return NoContent();
    }
}