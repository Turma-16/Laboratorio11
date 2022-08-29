using Laboratorio11.Models;
using Microsoft.EntityFrameworkCore;

public class AutorRepo: IAutorRepo
{
    private readonly BibliotecaContext _context;

    public AutorRepo (BibliotecaContext context)
    {
        _context = context;
    }

    public async Task<Autor> CadastrarAutor(Autor autor)
    {
        await _context.Autores.AddAsync(autor);
        await _context.SaveChangesAsync();
        return autor;
    }
    
    public async Task<List<Autor>> BuscaAutores()
    {
        return await _context.Autores.ToListAsync();

    }
}