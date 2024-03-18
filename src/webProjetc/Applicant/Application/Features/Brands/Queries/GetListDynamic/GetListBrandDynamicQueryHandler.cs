using Application.Features.Brands.Models;
using Application.Service.Repositories;
using AutoMapper;
using Core.Persistence.Paging;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Queries.GetListDynamic
{
    public class GetListBrandDynamicQueryHandler : IRequestHandler<GetListBrandDynamicQuery, BrandListModel>
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IMapper _mapper;

        public GetListBrandDynamicQueryHandler(IBrandRepository brandRepository, IMapper mapper)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
        }

        public async Task<BrandListModel> Handle(GetListBrandDynamicQuery request, CancellationToken cancellationToken)
        {
            IPaginate<Brand> brands = await _brandRepository.GetListByDynamicAsync(request.Dynamic, index: request.PageRequest.Page,
                size: request.PageRequest.PageSize);
            BrandListModel brandListModel = _mapper.Map<BrandListModel>(brands);
            return brandListModel;
        }
    }
}
