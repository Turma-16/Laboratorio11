
using Laboratorio11.Models;
public interface IAutorRepo
{
    public Task<Autor> CadastrarAutor(Autor autor);


    public Task<List<Autor>> BuscaAutores();

}