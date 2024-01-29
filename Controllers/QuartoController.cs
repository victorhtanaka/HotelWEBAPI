using Microsoft.AspNetCore.Mvc;
using HotelWEBAPI.Models;

namespace HotelWEBAPI.Controllers;

    [Route("api/[controller]")]
    [ApiController]
    public class QuartoController : Controller
    {
        [HttpPost]
        public IActionResult Post([FromBody] Quarto quarto)
        {
            using (var _context = new HotelContext())
            {
                quarto.CodQuarto = 0;
                _context.Quartos.Add(quarto);
                _context.SaveChanges();
                return Ok(quarto);
            }
        }

        [HttpGet]
        public List<Quarto> Get()
        {
            using (var _context = new HotelContext())
            {
                return _context.Quartos.ToList();
            }
        }
        [HttpGet("{CodQuarto}")]
        public IActionResult Get(int CodQuarto)
        {
            using (var _context = new HotelContext())
            {
                var item = _context.Quartos.FirstOrDefault(t => t.CodQuarto == CodQuarto);
                if(item == null)
                {
                    return NotFound("Quarto não encontrado");
                }
                return new ObjectResult(item);
            }
        }
        [HttpPut("{CodQuarto}")]
        public IActionResult Put(int CodQuarto,[FromBody] Quarto quarto)
        {
            using (var _context = new HotelContext())
            {
                var item = _context.Quartos.FirstOrDefault(t => t.CodQuarto == CodQuarto);
                if(item == null)
                {
                    return NotFound("Quarto não encontrado"); 
                }
                quarto.CodQuarto = item.CodQuarto;
                _context.Entry(item).CurrentValues.SetValues(quarto);
                _context.SaveChanges();
                return Ok(quarto);
            }
        }
        [HttpDelete("{CodQuarto}")]
        public IActionResult Delete(int CodQuarto)
        {
            using (var _context = new HotelContext())
            {
                var item = _context.Quartos.FirstOrDefault(t => t.CodQuarto == CodQuarto);
                if(item == null)
                {
                    return NotFound("Quarto não encontrado"); 
                }
                _context.Quartos.Remove(item);
                _context.SaveChanges();
                return Ok(item);
            }
        }
    }