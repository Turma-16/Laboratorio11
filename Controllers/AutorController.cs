using Laboratorio11.Models;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class AutorController : ControllerBase
{
 
    private readonly ILogger<AutorController> _logger;
    private readonly IAutorRepo _IAutorRepo;

    public AutorController(ILogger<AutorController> logger, IAutorRepo IAutorRepo)
    {
        _logger = logger;
        _IAutorRepo = IAutorRepo;
    }

    [HttpPost("CadastraAutor")]  //POST  .../Autor/CadastraAutor
    public async Task<ActionResult<AutorDTO>> CadastraAutor(AutorDTO autorParaCadastro)
    {
        Autor autor = new Autor();
        autor.PrimeiroNome = autorParaCadastro.PrimeiroNome;
        autor.UltimoNome = autorParaCadastro.UltimoNome;

        var NovoAutor = await _IAutorRepo.CadastrarAutor(autor);
        return AutorDTO.DeEntidadeParaDTO(NovoAutor);
    }

    [HttpGet("ListarAutores")] // GET
    public async Task<ActionResult<List<AutorDTO>>> ListarAutores()
    {
        var autores = await _IAutorRepo.BuscaAutores();
        
        return autores.Select( autor => AutorDTO.DeEntidadeParaDTO(autor)).ToList();
    }
}