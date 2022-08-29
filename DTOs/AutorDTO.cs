using Laboratorio11.Models;

public class AutorDTO
{
    public int Id {get;set;}

    public string PrimeiroNome{get;set;} = null!;
    public string UltimoNome{get;set;}  = null!;

    public static AutorDTO DeEntidadeParaDTO (Autor autor)
    {
        AutorDTO dto = new AutorDTO();
        dto.Id = autor.Id;
        dto.PrimeiroNome = autor.PrimeiroNome;
        dto.UltimoNome = autor.UltimoNome;

        return dto;

    }

}