using Application.Features.Brands.Dtos;
using Application.Features.Models.Dtos;
using Application.Service.Repositories;
using AutoMapper;
using Core.Applicantion.Pipelines.Caching;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Models.Queries.GetAll;

public partial class GetAllModelsQuery : IRequest<List<GetAllModelsResponse>>, ICachableRequest
{
    public bool BypassCache { get; }

    public string CacheKey => "model-list";

    public TimeSpan? SlidingExpiration { get; }
}