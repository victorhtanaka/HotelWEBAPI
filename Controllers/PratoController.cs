using Microsoft.AspNetCore.Mvc;
using HotelWEBAPI.Models;

namespace HotelWEBAPI.Controllers;

    [Route("api/[controller]")]
    [ApiController]
    public class PratoController : Controller
    {
        [HttpPost]
        public IActionResult Post([FromBody] Prato prato)
        {
            using (var _context = new HotelContext())
            {
                prato.CodPrato = 0;
                _context.Pratos.Add(prato);
                _context.SaveChanges();
                return Ok(prato);
            }
        }

        [HttpGet]
        public List<Prato> Get()
        {
            using (var _context = new HotelContext())
            {
                return _context.Pratos.ToList();
            }
        }
        [HttpGet("{CodPrato}")]
        public IActionResult Get(int CodPrato)
        {
            using (var _context = new HotelContext())
            {
                var item = _context.Pratos.FirstOrDefault(t => t.CodPrato == CodPrato);
                if(item == null)
                {
                    return NotFound("Quarto não encontrado");
                }
                return new ObjectResult(item);
            }
        }
        [HttpPut("{CodPrato}")]
        public IActionResult Put(int CodPrato,[FromBody] Prato prato)
        {
            using (var _context = new HotelContext())
            {
                var item = _context.Pratos.FirstOrDefault(t => t.CodPrato == CodPrato);
                if(item == null)
                {
                    return NotFound("Prato não encontrado"); 
                }
                prato.CodPrato = item.CodPrato;
                _context.Entry(item).CurrentValues.SetValues(prato);
                _context.SaveChanges();
                return Ok(prato);
            }
        }
        [HttpDelete("{CodPrato}")]
        public IActionResult Delete(int CodPrato)
        {
            using (var _context = new HotelContext())
            {
                var item = _context.Pratos.FirstOrDefault(t => t.CodPrato == CodPrato);
                if(item == null)
                {
                    return NotFound("Prato não encontrado"); 
                }
                _context.Pratos.Remove(item);
                _context.SaveChanges();
                return Ok(item);
            }
        }
    }