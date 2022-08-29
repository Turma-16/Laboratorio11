using Microsoft.EntityFrameworkCore;
namespace Laboratorio11.Models;
public class BibliotecaContext : DbContext{

    public DbSet<Autor> Autores {get;set;} = null!;
    public DbSet<Livro> Livros {get;set;} = null!;
    public DbSet<Emprestimo> Emprestimos {get;set;} = null!;
    public BibliotecaContext(){}
    public BibliotecaContext(DbContextOptions<BibliotecaContext> opcoes) : base(opcoes){}
}