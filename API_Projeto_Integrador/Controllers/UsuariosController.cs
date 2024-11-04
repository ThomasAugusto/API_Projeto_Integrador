using Microsoft.AspNetCore.Mvc;

namespace API_Projeto_Integrador.Controllers;
using API_Projeto_Integrador.Context;
using API_Projeto_Integrador.Models;

[ApiController]
[Route("[Controller]")]
public class UsuariosController : ControllerBase
{
    private readonly API_Pojeto_IntegradorContext _context;
    public UsuariosController(API_Pojeto_IntegradorContext context) 
    { 
        _context = context;
    }

    [HttpGet]

    public ActionResult<IEnumerable<Usuario>> Get()
    {
        var usuarios = _context.Usuarios.ToList();
        if (usuarios is null) 
        { 
            return NotFound();
        }
        return usuarios;
    }

    [HttpGet("{id:int}", Name="ObterUsuario")]
    public ActionResult<Usuario> Get(int id)
    {
        var usuario = _context.Usuarios.FirstOrDefault(p=> p.UsuarioId == id);
        if (usuario is null)
        {
            return NotFound("Usuário não encontrado");
        }
        return usuario;
    }

    [HttpPost]
    public ActionResult Post (Usuario usuario)
    {
        if (usuario is null)
            return BadRequest();

        _context.Usuarios.Add(usuario);
        _context.SaveChanges();

        return new CreatedAtRouteResult("ObterUsuario", 
            new { Id = usuario.UsuarioId }, usuario);
    }

    [HttpPut("{id:int}")]
    public ActionResult Put(int id, Usuario usuario)
    {
        if (id != usuario.UsuarioId)
        { 
            return BadRequest();
        }

        _context.Entry(usuario).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        _context.SaveChanges();

        return Ok();
    }

    [HttpDelete("{id:int}")]
    public ActionResult Delete(int id)
    { 
        var usuario = _context.Usuarios.FirstOrDefault(p => p.UsuarioId==id);

        if (usuario is null)
        {
            return NotFound("Usuário não localizado");
        }
        _context.Usuarios.Remove(usuario);
        _context.SaveChanges();

        return Ok(usuario);
    }
}
