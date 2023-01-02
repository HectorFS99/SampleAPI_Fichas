using AutoMapper;
using FichasAPI.Data;
using FichasAPI.Data.Dtos.Ficha;
using FichasAPI.Models;
using FluentResults;

namespace FichasAPI.Services;

public class FichaService
{
    private AppDbContext _context;
    private IMapper _mapper;

    public FichaService(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;   
    }

    public ReadFichaDto AdicionaFicha(CreateFichaDto fichaDto)
    { 
        Ficha ficha = _mapper.Map<Ficha>(fichaDto);

        _context.Fichas.Add(ficha);
        _context.SaveChanges();

        ReadFichaDto readDto = _mapper.Map<ReadFichaDto>(ficha);
        return readDto;
    }

    public List<ReadFichaDto> RecuperaFichas()
    {
        List<Ficha> fichas = _context.Fichas.ToList();;

        if (fichas != null)
        {
            List<ReadFichaDto> readDtos = _mapper.Map<List<ReadFichaDto>>(fichas);
            return readDtos;
        }

        return null;
    }

    public ReadFichaDto RecuperaFichaPorId(int id)
    {
        Ficha ficha = _context.Fichas.FirstOrDefault(ficha => ficha.Id == id);

        if (ficha != null) 
        {
            ReadFichaDto readDto = _mapper.Map<ReadFichaDto>(ficha);
            return readDto;
        }

        return null;
    }

    public Result AtualizaFicha(int id, UpdateFichaDto fichaDto)
    {
        Ficha ficha = _context.Fichas.FirstOrDefault(ficha => ficha.Id == id);

        if (ficha != null)
        {
            _mapper.Map(fichaDto, ficha);
            _context.SaveChanges();

            return Result.Ok();
        }

        return Result.Fail("Ficha não localizada. Por favor, informe um ID válido/existente para atualizar.");
    }

    public Result DeletaFicha(int id)
    {
        Ficha ficha = _context.Fichas.FirstOrDefault(ficha => ficha.Id == id);

        if (ficha != null)
        {
            _context.Remove(ficha);
            _context.SaveChanges();

            return Result.Ok();
        }

        return Result.Fail("Ficha não localizada para exclusão. Por favor, informe um ID válido/existente para excluir.");
    }
}