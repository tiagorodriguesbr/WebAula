using System.ComponentModel.DataAnnotations;

public class Usuario
{
    [Key]
    public string CPF { get; set; }

    // outras propriedades da classe
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
}
