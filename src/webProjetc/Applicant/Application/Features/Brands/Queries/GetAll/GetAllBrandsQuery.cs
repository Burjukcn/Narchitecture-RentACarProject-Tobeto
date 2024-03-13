using Application.Features.Brands.Dtos;
using Application.Service.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Queries.GetAll
{
    public class GetAllBrandsQuery : IRequest<List<GetAllBrandsResponse>>
    {
        public class GetAllBrandsQueryHandler : IRequestHandler<GetAllBrandsQuery, List<GetAllBrandsResponse>>
        {
            private readonly IBrandRepository _brandRepository;
            private readonly IMapper _mapper;

            public GetAllBrandsQueryHandler(IBrandRepository brandRepository, IMapper mapper)
            {
                _brandRepository = brandRepository;
                _mapper = mapper;
            }

            public async Task<List<GetAllBrandsResponse>> Handle(GetAllBrandsQuery request, CancellationToken cancellationToken)
            {
                List<Brand> brands = await _brandRepository.GetAllAsync();
                List<GetAllBrandsResponse> responses = _mapper.Map<List<GetAllBrandsResponse>>(brands);
                return responses;
            }
        }
    }
}
