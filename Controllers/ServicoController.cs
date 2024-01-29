using Microsoft.AspNetCore.Mvc;
using HotelWEBAPI.Models;

namespace HotelWEBAPI.Controllers;

    [Route("api/[controller]")]
    [ApiController]
    public class ServicoController : Controller
    {
        [HttpPost]
        public IActionResult Post([FromBody] Servico Servico)
        {
            using (var _context = new HotelContext())
            {
                Servico.CodServico = 0;
                _context.Servicos.Add(Servico);
                _context.SaveChanges();
                return Ok(Servico);
            }
        }

        [HttpGet]
        public List<Servico> Get()
        {
            using (var _context = new HotelContext())
            {
                return _context.Servicos.ToList();
            }
        }
        [HttpGet("{CodServico}")]
        public IActionResult Get(int CodServico)
        {
            using (var _context = new HotelContext())
            {
                var item = _context.Servicos.FirstOrDefault(t => t.CodServico == CodServico);
                if(item == null)
                {
                    return NotFound("Servico não encontrado");
                }
                return new ObjectResult(item);
            }
        }
        [HttpPut("{CodServico}")]
        public IActionResult Put(int CodServico,[FromBody] Servico Servico)
        {
            using (var _context = new HotelContext())
            {
                var item = _context.Servicos.FirstOrDefault(t => t.CodServico == CodServico);
                if(item == null)
                {
                    return NotFound("Servico não encontrado"); 
                }
                Servico.CodServico = item.CodServico;
                _context.Entry(item).CurrentValues.SetValues(Servico);
                _context.SaveChanges();
                return Ok(Servico);
            }
        }
        [HttpDelete("{CodServico}")]
        public IActionResult Delete(int CodServico)
        {
            using (var _context = new HotelContext())
            {
                var item = _context.Servicos.FirstOrDefault(t => t.CodServico == CodServico);
                if(item == null)
                {
                    return NotFound("Servico não encontrado"); 
                }
                _context.Servicos.Remove(item);
                _context.SaveChanges();
                return Ok(item);
            }
        }
    }