using API_Projeto_Integrador.Context;
using API_Projeto_Integrador.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_Projeto_Integrador.Controllers;

[ApiController]
[Route("[Controller]")]
public class TipoRegistroController : ControllerBase
{
    private readonly API_Pojeto_IntegradorContext _context;
    public TipoRegistroController(API_Pojeto_IntegradorContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Tipo_Registro>> Get()
    {
        var tipoRegistro = _context.tipo_Registros.ToList();
        if (tipoRegistro is null)
        {
            return NotFound();
        }
        return tipoRegistro;
    }

    [HttpGet("{id:int}")]
    public ActionResult<Tipo_Registro> Get(int id)
    {
        var tipoRegistro = _context.tipo_Registros.FirstOrDefault(p => p.Tipo_RegistroId == id);
        if (tipoRegistro is null)
        {
            return NotFound("Tipo não encontrado");
        }
        return tipoRegistro;
    }
}
