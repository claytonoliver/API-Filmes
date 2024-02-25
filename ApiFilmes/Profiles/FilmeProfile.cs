using ApiFilmes.Data.DTOs;
using ApiFilmes.Models;
using AutoMapper;

namespace ApiFilmes.Profiles;

public class FilmeProfile : Profile
{
    public FilmeProfile()
    {
        CreateMap<CreateFilmeDto, Filme>();
        CreateMap<UpdateFilmeDto, Filme>();
        CreateMap<Filme, ReadFilmeDto > ();
    }
}