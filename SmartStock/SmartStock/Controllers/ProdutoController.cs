using Microsoft.AspNetCore.Mvc;
using SmartStock.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartStock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly DataContext _context;

        public ProdutoController(DataContext context)
        {
            _context = context;
        }
        // GET: api/<Produto>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.ProdutoTable.ToList());
        }

        // GET api/<Produto>/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var produto = _context.ProdutoTable.FirstOrDefault(x => x.Id == id); // ✅ Correto

            if (produto == null)
            {
                return NotFound(new { Message = $"Produto com o Id={id} não encontrado" });
            }
            return Ok(produto);
        }

        // POST api/<Produto>
        [HttpPost]
        public IActionResult Post([FromBody] Produto newProduto)
        {
            if (newProduto == null)
                return BadRequest("O corpo da requisição é inválido.");

            if (_context.ProdutoTable.Any(p => p.Id == newProduto.Id))
                return Conflict(new { Messag = $"Já existe um produto com o mesmo Id={newProduto.Id}." });

            _context.ProdutoTable.Add(newProduto);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = newProduto.Id }, newProduto);
        }

        // PUT api/<Produto>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Produto updateProduto)
        {
            if (updateProduto == null)
                return BadRequest("O corpo da requisição é inválido.");

            var existing = _context.ProdutoTable.FirstOrDefault(x => x.Id == id); 
            if (existing == null)
                return NotFound(new { Message = $"Produto com o Id={id} não encontrado." });

            _context.Entry(existing).CurrentValues.SetValues(updateProduto);
            _context.SaveChanges();

            return Ok(new
            {
                Message = "Tarefa atualizada com sucesso.",
                Updated = updateProduto
            });
        }

        // DELETE api/<Produto>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var produto = _context.ProdutoTable.Find(id);
            if (produto == null)
            {
                return NotFound(new { Message = $"Produto com o Id={id} não encontrado." });
            }
            _context.ProdutoTable.Remove(produto);
            _context.SaveChanges();
            return Ok(new { Message = "Produto deletado com sucesso." });
        }
    }
}
