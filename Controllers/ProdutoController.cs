using Microsoft.AspNetCore.Mvc;
using HotelWEBAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelWEBAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProdutoController : Controller
{

    // GET: api/Produto
    [HttpGet]
    public IActionResult GetProdutos()
    {
        using (var _context = new HotelContext())
        {
            return Ok(_context.Produtos.ToList());
        }
        
    }

    // GET: api/Produto/5
    [HttpGet("{id}")]
    public IActionResult GetProduto(int id)
    {
        using (var _context = new HotelContext())
        {
            var produto = _context.Produtos.FirstOrDefault(e => e.CodProduto == id);

            if (produto == null)
            {
                return NotFound();
            }

            return Ok(produto);
        }
    }

    // POST: api/Produto
    [HttpPost]
    public IActionResult PostProduto(Produto produto)
    {
        using (var _context = new HotelContext())
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();

            return Ok($"O produto de nome '{produto.NomeProduto}' foi criado com sucesso");
        }
    }

    // PUT: api/Produto/5
    [HttpPut("{id}")]
    public IActionResult PutProduto(int id, [FromBody] Produto produto)
    {
        using (var _context = new HotelContext())
        {
            var item = _context.Produtos.FirstOrDefault(e => e.CodProduto == id);
            if (item == null)
            {
                return BadRequest("Produto não encontrado");
            }
            _context.Entry(item).CurrentValues.SetValues(produto);
            _context.SaveChanges();
            return Ok($"Produto de id '{id}' editado com sucesso");
        }
    }

    // DELETE: api/Produto/5
    [HttpDelete("{id}")]
    public IActionResult DeleteProduto(int id)
    {
        using var _context = new HotelContext();
        var produto = _context.Produtos.FirstOrDefault(e => e.CodProduto == id);
        if (produto == null)
        {
            return NotFound($"Produto com id '{id}' não encontrado");
        }

        string nome = produto.NomeProduto;
        _context.Produtos.Remove(produto);
        _context.SaveChanges();

        return Ok($"O produto com nome '{nome}' foi deletado");
    }

}