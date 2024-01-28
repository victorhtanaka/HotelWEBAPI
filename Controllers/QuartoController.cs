using Microsoft.AspNetCore.Mvc;
using HotelWEBAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelWEBAPI.Controllers;

    [Route("api/[controller]")]
    [ApiController]
    public class QuartoController : Controller
    {
        [HttpPost]
        public void Post([FromBody] Quarto quarto)
        {
            using (var _context = new HotelContext())
            {
                _context.Quartos.Add(quarto);
                _context.SaveChanges();
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
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            using (var _context = new HotelContext())
            {
                var item = _context.Quartos.FirstOrDefault(t => t.NumQuarto == id);
                if(item == null)
                {
                    return NotFound();
                }
                return new ObjectResult(item);
            }
        }
        [HttpPut("{id}")]
        public void Put(int id,[FromBody] Quarto quarto)
        {
            using (var _context = new HotelContext())
            {
                var item = _context.Quartos.FirstOrDefault(t => t.NumQuarto == id);
                if(item == null)
                {
                    return; 
                }
                _context.Entry(item).CurrentValues.SetValues(quarto);
                _context.SaveChanges();
            }
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using (var _context = new HotelContext())
            {
                var item = _context.Quartos.FirstOrDefault(t => t.NumQuarto == id);
                if(item == null)
                {
                    return; 
                }
                _context.Quartos.Remove(item);
                _context.SaveChanges();
            }
        }
    }