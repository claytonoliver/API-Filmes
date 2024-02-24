using ApiFilmes.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;


namespace ApiFilmes.Controllers;

// primeiro passo importar anotações, depois alt + enter para importar aspnetcore.Mvc
[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private static List<Filme> filmes = new List<Filme>();
    private static int id = 0;

    //trabalhar requisição POST, GET...
    [HttpPost()]
    //indicar pelo frombody que a informação como parametro vem do corpo da requisição
    public IActionResult AdicionarFilme([FromBody]Filme filme)
    {
        filme.Id = id++;
        filmes.Add(filme);
        //recebe primeiro parametro no caso o metodo que retorna o filme por ID... Elemento, objetos/parametros, objeto criado no sistema
        return CreatedAtAction(nameof(RecuperarFimePorId), new { id = filme.Id }, filme);
    }

    [HttpGet]
    public IEnumerable<Filme> RecuperarFilmes([FromQuery]int skip = 0, [FromQuery] int take = 20)
    {
        return filmes.Skip(skip).Take(take);
    }

    //para diferenciar precisa mudar o ID direto na URL /numero ID
    [HttpGet("{id}")]
    //? indica que pode ser ou não nulo

    //IActionresult resultado de uma ação
    public IActionResult RecuperarFimePorId(int id)
    {
        //filme => tem o filme.id == id do parametro
        var filme = filmes.FirstOrDefault(filme => filme.Id == id);
        if (filme == null) return NotFound();
        return Ok();
    }
}
