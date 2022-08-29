namespace Laboratorio11.Models;

public class Livro{

    public int Id {get;set;}
    public string Titulo{get;set;} = null!;

    public List<Autor> Autores {get;set;} = null!;

    public List<Emprestimo> Emprestimos{get;set;} = null!;
}