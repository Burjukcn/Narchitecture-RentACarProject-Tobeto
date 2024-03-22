using Application.Features.Brands.Commands.CreateBrand;
using Application.Features.Brands.Commands.DeleteBrand;
using Application.Features.Brands.Commands.UpdateBrand;
using Application.Features.Brands.Dtos;
using Application.Features.Brands.Models;
using AutoMapper;
using Core.Persistence.Paging;
using Domain.Entities;


namespace Application.Features.Brands.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Brand, CreateBrandCommand>().ReverseMap(); //Brandi   CreateBrandCommand   çevir anlamına gelir
        CreateMap<Brand, CreatedBrandResponse>().ReverseMap();//  çevir anlamına gelir

        CreateMap<Brand, DeleteBrandCommand>().ReverseMap();//  çevir anlamına gelir
        CreateMap<Brand, DeletedBrandResponse>().ReverseMap();//  çevir anlamına gelir

        CreateMap<Brand, UpdateBrandCommand>().ReverseMap();//  çevir anlamına gelir
        CreateMap<Brand, UpdatedBrandResponse>().ReverseMap();//  çevir anlamına gelir

        CreateMap<Brand, GetAllBrandsResponse>().ReverseMap();//  çevir anlamına gelir
        CreateMap<Brand, GetByIdBrandResponse>().ReverseMap();//  çevir anlamına gelir

        CreateMap<Brand, GetListBrandResponse>().ReverseMap();
        CreateMap<IPaginate<Brand>, BrandListModel>().ReverseMap();
    }
}