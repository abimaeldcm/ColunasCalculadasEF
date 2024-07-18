using ColunasCalculadasEF.Models;
using Microsoft.AspNetCore.Mvc;

namespace ColunasCalculadasEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult BuscarTodos()
        {
            var produtos = _context.Produtos.ToList();
            return Ok(produtos);
        }

        [HttpPost]
        public IActionResult Criar(Produto produtoCriar)
        {
            _context.Produtos.Add(produtoCriar);
            _context.SaveChanges();
            return Ok(produtoCriar);
        }
    }
}
