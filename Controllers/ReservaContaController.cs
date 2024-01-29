using Microsoft.AspNetCore.Mvc;
using HotelWEBAPI.Models;

namespace HotelWEBAPI.Controllers;

    [Route("api/[controller]")]
    [ApiController]
    public class ReservaContaController : Controller
    {
        [HttpPost]
        public IActionResult Post([FromBody] ReservaConta ReservaConta)
        {
            using (var _context = new HotelContext())
            {
                ReservaConta.CodReserva = 0;
                _context.ReservasContas.Add(ReservaConta);
                _context.SaveChanges();
                return Ok(ReservaConta);
            }
        }

        [HttpGet]
        public List<ReservaConta> Get()
        {
            using (var _context = new HotelContext())
            {
                return _context.ReservasContas.ToList();
            }
        }
        [HttpGet("{CodReserva}")]
        public IActionResult Get(int CodReserva)
        {
            using (var _context = new HotelContext())
            {
                var item = _context.ReservasContas.FirstOrDefault(t => t.CodReserva == CodReserva);
                if(item == null)
                {
                    return NotFound("ReservaConta não encontrado");
                }
                return new ObjectResult(item);
            }
        }
        [HttpPut("{CodReserva}")]
        public IActionResult Put(int CodReserva,[FromBody] ReservaConta ReservaConta)
        {
            using (var _context = new HotelContext())
            {
                var item = _context.ReservasContas.FirstOrDefault(t => t.CodReserva == CodReserva);
                if(item == null)
                {
                    return NotFound("ReservaConta não encontrado"); 
                }
                ReservaConta.CodReserva = item.CodReserva;
                _context.Entry(item).CurrentValues.SetValues(ReservaConta);
                _context.SaveChanges();
                return Ok(ReservaConta);
            }
        }
        [HttpDelete("{CodReserva}")]
        public IActionResult Delete(int CodReserva)
        {
            using (var _context = new HotelContext())
            {
                var item = _context.ReservasContas.FirstOrDefault(t => t.CodReserva == CodReserva);
                if(item == null)
                {
                    return NotFound("ReservaConta não encontrado"); 
                }
                _context.ReservasContas.Remove(item);
                _context.SaveChanges();
                return Ok(item);
            }
        }
    }