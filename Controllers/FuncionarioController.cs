using Microsoft.AspNetCore.Mvc;
using HotelWEBAPI.Models;

namespace HotelWEBAPI.Controllers;

    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : Controller
    {
        [HttpPost]
        public IActionResult Post([FromBody] Funcionario Funcionario)
        {
            using (var _context = new HotelContext())
            {
                Funcionario.CodFuncionario = 0;
                _context.Funcionarios.Add(Funcionario);
                _context.SaveChanges();
                return Ok(Funcionario);
            }
        }

        [HttpGet]
        public List<Funcionario> Get()
        {
            using (var _context = new HotelContext())
            {
                return _context.Funcionarios.ToList();
            }
        }
        [HttpGet("{CodFuncionario}")]
        public IActionResult Get(int CodFuncionario)
        {
            using (var _context = new HotelContext())
            {
                var item = _context.Funcionarios.FirstOrDefault(t => t.CodFuncionario == CodFuncionario);
                if(item == null)
                {
                    return NotFound("Funcionario não encontrado");
                }
                return new ObjectResult(item);
            }
        }
        [HttpPut("{CodFuncionario}")]
        public IActionResult Put(int CodFuncionario,[FromBody] Funcionario Funcionario)
        {
            using (var _context = new HotelContext())
            {
                var item = _context.Funcionarios.FirstOrDefault(t => t.CodFuncionario == CodFuncionario);
                if(item == null)
                {
                    return NotFound("Funcionario não encontrado"); 
                }
                Funcionario.CodFuncionario = item.CodFuncionario;
                _context.Entry(item).CurrentValues.SetValues(Funcionario);
                _context.SaveChanges();
                return Ok(Funcionario);
            }
        }
        [HttpDelete("{CodFuncionario}")]
        public IActionResult Delete(int CodFuncionario)
        {
            using (var _context = new HotelContext())
            {
                var item = _context.Funcionarios.FirstOrDefault(t => t.CodFuncionario == CodFuncionario);
                if(item == null)
                {
                    return NotFound("Funcionario não encontrado"); 
                }
                _context.Funcionarios.Remove(item);
                _context.SaveChanges();
                return Ok(item);
            }
        }
    }