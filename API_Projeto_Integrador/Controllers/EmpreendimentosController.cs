using API_Projeto_Integrador.Context;
using API_Projeto_Integrador.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Projeto_Integrador.Controllers;

[ApiController]
[Route("[Controller]")]
public class EmpreendimentosController : ControllerBase
{
    private readonly API_Pojeto_IntegradorContext _context;
    public EmpreendimentosController(API_Pojeto_IntegradorContext context)
    {
        _context = context;
    }

    [HttpGet("lojistas")]
    public ActionResult<IEnumerable<Empreendimento>> GetEmpreendimentosLojistas()
    {
        return _context.Empreendimentos.Include(p=> p.Lojistas).ToList();
    }
    
    [HttpGet]
    public ActionResult<IEnumerable<Empreendimento>> Get()
    {
        var empreendimentos = _context.Empreendimentos.ToList();
        if (empreendimentos is null)
        {
            return NotFound();
        }
        return empreendimentos;
    }

    [HttpGet("{id:int}")]
    public ActionResult<Empreendimento> Get(int id)
    {
        var empreendimentos = _context.Empreendimentos.FirstOrDefault(p => p.EmpreendimentoId == id);
        if (empreendimentos is null)
        {
            return NotFound("Empreendimento não encontrado");
        }
        return empreendimentos;
    }
}
