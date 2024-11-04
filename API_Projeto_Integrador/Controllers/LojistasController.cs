using Microsoft.AspNetCore.Mvc;
using API_Projeto_Integrador.Models;
using API_Projeto_Integrador.Context;

namespace API_Projeto_Integrador.Controllers;

[ApiController]
[Route("[Controller]")]
public class LojistasController : ControllerBase
{
    private readonly API_Pojeto_IntegradorContext _context;
    public LojistasController(API_Pojeto_IntegradorContext context)
    { 
        _context = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Lojista>> Get()
    {
        var lojistas = _context.Lojistas.ToList();
        if (lojistas is null)
        {
            return NotFound();
        }
        return lojistas;
    }

    [HttpGet("{id:int}")]
    public ActionResult<Lojista> Get(int id)
    {
        var lojistas = _context.Lojistas.FirstOrDefault(p => p.LojistaId == id);
        if (lojistas is null)
        {
            return NotFound("Lojista não encontrado");
        }
        return lojistas;
    }
}
