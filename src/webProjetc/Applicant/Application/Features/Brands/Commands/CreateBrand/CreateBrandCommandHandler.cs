using Application.Features.Brands.Commands.CreateBrand;
using Application.Features.Brands.Dtos;
using Application.Service.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Brands.Commands.CreateBrand;

public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommand, CreatedBrandResponse>
{
    private readonly IBrandRepository _brandRepository;
    private readonly IMapper _mapper;

    public CreateBrandCommandHandler(IBrandRepository brandRepository, IMapper mapper)
    {
        _brandRepository = brandRepository;
        _mapper = mapper;
    }

    public async Task<CreatedBrandResponse> Handle(CreateBrandCommand request, CancellationToken cancellationToken)
    {
        Brand mappedBrand = _mapper.Map<Brand>(request);
        Brand createdBrand = await _brandRepository.AddAsync(mappedBrand);
        CreatedBrandResponse createdBrandResponse = _mapper.Map<CreatedBrandResponse>(createdBrand);
        return createdBrandResponse;
    }
}