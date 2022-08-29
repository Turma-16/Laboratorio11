namespace Laboratorio11.Models;

public class Autor
{
    public int Id{get;set;}
    public string PrimeiroNome{get;set;} = null!;
    public string UltimoNome{get;set;} = null!;
    
    public List<Livro> Livros {get;set;} = null!;
}