using AutoMapper;
using FichasAPI.Data.Dtos.Ficha;
using FichasAPI.Models;

namespace FichasAPI.Profiles;

public class FichaProfile : Profile
{
	public FichaProfile()
	{
		CreateMap<CreateFichaDto, Ficha>();
		CreateMap<Ficha, ReadFichaDto>();
		CreateMap<UpdateFichaDto, Ficha>();
	}
}