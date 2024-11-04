using API_Projeto_Integrador.Context;
using API_Projeto_Integrador.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_Projeto_Integrador.Controllers;

[ApiController]
[Route("[Controller]")]
public class RegistrosController : ControllerBase
{
    private readonly API_Pojeto_IntegradorContext _context;
    public RegistrosController(API_Pojeto_IntegradorContext context)
    {
        _context = context;
    }

    [HttpGet]

    public ActionResult<IEnumerable<Registro>> Get()
    {
        var registros = _context.Registros.ToList();
        if (registros is null)
        {
            return NotFound();
        }
        return registros;
    }

    [HttpGet("{id:int}", Name = "ObterRegistro")]
    public ActionResult<Registro> Get(int id)
    {
        var registro = _context.Registros.FirstOrDefault(p => p.RegistroId == id);
        if (registro is null)
        {
            return NotFound("Usuário não encontrado");
        }
        return registro;
    }

    [HttpPost]
    public ActionResult Post(Registro registro)
    {
        if (registro is null)
            return BadRequest();

        _context.Registros.Add(registro);
        _context.SaveChanges();

        return new CreatedAtRouteResult("ObterRegistro",
            new { Id = registro.RegistroId }, registro);
    }

    [HttpPut("{id:int}")]
    public ActionResult Put(int id, Registro registro)
    {
        if (id != registro.RegistroId)
        {
            return BadRequest();
        }

        _context.Entry(registro).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        _context.SaveChanges();

        return Ok();
    }

    [HttpDelete("{id:int}")]
    public ActionResult Delete(int id)
    {
        var registro = _context.Registros.FirstOrDefault(p => p.RegistroId == id);

        if (registro is null)
        {
            return NotFound("Registro não localizado");
        }
        _context.Registros.Remove(registro);
        _context.SaveChanges();

        return Ok(registro);
    }
}
