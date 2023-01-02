using System.ComponentModel.DataAnnotations;

namespace FichasAPI.Data.Dtos.Ficha;

public class UpdateFichaDto
{
    [Required(ErrorMessage = "O campo 'Nome' é obrigatório.")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "O campo 'Sobrenome' é obrigatório.")]
    public string Sobrenome { get; set; }

    [Required(ErrorMessage = "Insira uma data de nascimento para cadastro.")]
    public DateTime Nascimento { get; set; }

    [Required(ErrorMessage = "O CPF é obrigatório para o cadastro. Por favor, insira-o, e tente novamente.")]
    public string Cpf { get; set; }

    [Required(ErrorMessage = "O RG é obrigatório para o cadastro. Por favor, insira-o, e tente novamente.")]
    public string Rg { get; set; }

    [Required(ErrorMessage = "O campo 'Logradouro' é obrigatório.")]
    public string Logradouro { get; set; }

    [Required(ErrorMessage = "O campo 'Número' é obrigatório.")]
    public int Numero { get; set; }

    public string Complemento { get; set; }

    [Required(ErrorMessage = "O campo 'Bairro' é obrigatório.")]
    public string Bairro { get; set; }

    [Required(ErrorMessage = "O campo 'Cidade' é obrigatório.")]
    public string Cidade { get; set; }

    [Required(ErrorMessage = "O campo 'Estado' é obrigatório."), MaxLength(2, ErrorMessage = "O campo 'Estado' deve conter apenas 2 caracteres.")]
    public string Estado { get; set; }
}