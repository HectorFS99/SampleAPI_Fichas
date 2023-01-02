using FichasAPI.Data.Dtos.Ficha;
using FichasAPI.Services;
using FluentResults;
using Microsoft.AspNetCore.Mvc;

namespace FichasAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class FichaController : ControllerBase
{
    private FichaService _fichaService;

    public FichaController(FichaService fichaService)
    {
        _fichaService = fichaService;
    }

    [HttpPost]
    public IActionResult AdicionaFicha([FromBody] CreateFichaDto fichaDto) 
    {
        ReadFichaDto readDto = _fichaService.AdicionaFicha(fichaDto);

        return CreatedAtAction(nameof(RecuperaFichaPorId), new { Id = readDto.Id }, readDto);
    }

    [HttpGet]
    public IActionResult RecuperaFichas() 
    {
        List<ReadFichaDto> readDtos = _fichaService.RecuperaFichas();

        if (readDtos != null) return Ok(readDtos);
        return NotFound();
    }

    [HttpGet("{id}")]
    public IActionResult RecuperaFichaPorId(int id)
    {
        ReadFichaDto readDto = _fichaService.RecuperaFichaPorId(id);

        if (readDto != null) return Ok(readDto);
        return NotFound();
    }

    [HttpPut]
    public IActionResult AtualizaFicha(int id, [FromBody] UpdateFichaDto updateDto) 
    {
        Result resultado = _fichaService.AtualizaFicha(id, updateDto);

        if (resultado.IsSuccess) return NoContent();
        return NotFound();
    }

    [HttpDelete]
    public IActionResult DeletaFicha(int id) 
    {
        Result resultado = _fichaService.DeletaFicha(id);

        if (resultado.IsSuccess) return NoContent();
        return NotFound();
    }
}