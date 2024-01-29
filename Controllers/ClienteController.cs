using Microsoft.AspNetCore.Mvc;
using HotelWEBAPI.Models;


namespace HotelWEBAPI.Controllers;

    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : Controller
    {
        [HttpPost]
        public IActionResult Post([FromBody] Cliente Cliente)
        {
            using (var _context = new HotelContext())
            {
                Cliente.CodCliente = 0;
                _context.Clientes.Add(Cliente);
                _context.SaveChanges();
                return Ok(Cliente);
            }
        }

        [HttpGet]
        public List<Cliente> Get()
        {
            using (var _context = new HotelContext())
            {
                return _context.Clientes.ToList();
            }
        }
        [HttpGet("{CodCliente}")]
        public IActionResult Get(int CodCliente)
        {
            using (var _context = new HotelContext())
            {
                var item = _context.Clientes.FirstOrDefault(t => t.CodCliente == CodCliente);
                if(item == null)
                {
                    return NotFound("Cliente não encontrado");
                }
                return new ObjectResult(item);
            }
        }
        [HttpPut("{CodCliente}")]
        public IActionResult Put(int CodCliente,[FromBody] Cliente Cliente)
        {
            using (var _context = new HotelContext())
            {
                var item = _context.Clientes.FirstOrDefault(t => t.CodCliente == CodCliente);
                if(item == null)
                {
                    return NotFound("Cliente não encontrado"); 
                }
                Cliente.CodCliente = item.CodCliente;
                _context.Entry(item).CurrentValues.SetValues(Cliente);
                _context.SaveChanges();
                return Ok(Cliente);
            }
        }
        [HttpDelete("{CodCliente}")]
        public IActionResult Delete(int CodCliente)
        {
            using (var _context = new HotelContext())
            {
                var item = _context.Clientes.FirstOrDefault(t => t.CodCliente == CodCliente);
                if(item == null)
                {
                    return NotFound("Cliente não encontrado"); 
                }
                _context.Clientes.Remove(item);
                _context.SaveChanges();
                return Ok(item);
            }
        }
    }