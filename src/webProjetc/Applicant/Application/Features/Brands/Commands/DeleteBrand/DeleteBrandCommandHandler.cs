using Application.Features.Brands.Commands.DeleteBrand;
using Application.Features.Brands.Dtos;
using Application.Service.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Brands.Commands.DeleteBrand
{
    public class DeleteBrandCommandHandler : IRequestHandler<DeleteBrandCommand, DeletedBrandResponse>
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IMapper _mapper;

        public DeleteBrandCommandHandler(IBrandRepository brandRepository, IMapper mapper)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
        }

        public async Task<DeletedBrandResponse> Handle(DeleteBrandCommand request, CancellationToken cancellationToken)
        {
            Brand? brand = await _brandRepository.GetAsync(x => x.Id == request.Id);
            _mapper.Map(request, brand);
            Brand deletedBrand = await _brandRepository.DeleteAsync(brand);
            DeletedBrandResponse response = _mapper.Map<DeletedBrandResponse>(deletedBrand);
            return response;
        }
    }
}
