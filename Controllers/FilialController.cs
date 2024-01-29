using Microsoft.AspNetCore.Mvc;
using HotelWEBAPI.Models;

namespace HotelWEBAPI.Controllers;

    [Route("api/[controller]")]
    [ApiController]
    public class FilialController : Controller
    {
        [HttpPost]
        public IActionResult Post([FromBody] Filial Filial)
        {
            using (var _context = new HotelContext())
            {
                Filial.CodFilial = 0;
                _context.Filiais.Add(Filial);
                _context.SaveChanges();
                return Ok(Filial);
            }
        }

        [HttpGet]
        public List<Filial> Get()
        {
            using (var _context = new HotelContext())
            {
                return _context.Filiais.ToList();
            }
        }
        [HttpGet("{CodFilial}")]
        public IActionResult Get(int CodFilial)
        {
            using (var _context = new HotelContext())
            {
                var item = _context.Filiais.FirstOrDefault(t => t.CodFilial == CodFilial);
                if(item == null)
                {
                    return NotFound("Filial não encontrado");
                }
                return new ObjectResult(item);
            }
        }
        [HttpPut("{CodFilial}")]
        public IActionResult Put(int CodFilial,[FromBody] Filial Filial)
        {
            using (var _context = new HotelContext())
            {
                var item = _context.Filiais.FirstOrDefault(t => t.CodFilial == CodFilial);
                if(item == null)
                {
                    return NotFound("Filial não encontrado"); 
                }
                Filial.CodFilial = item.CodFilial;
                _context.Entry(item).CurrentValues.SetValues(Filial);
                _context.SaveChanges();
                return Ok(Filial);
            }
        }
        [HttpDelete("{CodFilial}")]
        public IActionResult Delete(int CodFilial)
        {
            using (var _context = new HotelContext())
            {
                var item = _context.Filiais.FirstOrDefault(t => t.CodFilial == CodFilial);
                if(item == null)
                {
                    return NotFound("Filial não encontrado"); 
                }
                _context.Filiais.Remove(item);
                _context.SaveChanges();
                return Ok(item);
            }
        }
    }