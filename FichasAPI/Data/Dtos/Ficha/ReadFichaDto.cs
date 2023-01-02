﻿namespace FichasAPI.Data.Dtos.Ficha;

public class ReadFichaDto
{
    public int Id { get; set; }

    public string Nome { get; set; }

    public string Sobrenome { get; set; }

    public DateTime Nascimento { get; set; }

    public string Cpf { get; set; }

    public string Rg { get; set; }

    public string Logradouro { get; set; }

    public int Numero { get; set; }

    public string Complemento { get; set; }

    public string Bairro { get; set; }

    public string Cidade { get; set; }

    public string Estado { get; set; }
}