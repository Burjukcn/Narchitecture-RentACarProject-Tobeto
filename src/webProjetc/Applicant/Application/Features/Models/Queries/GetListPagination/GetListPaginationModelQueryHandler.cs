using Application.Features.Models.Models;
using Application.Service.Repositories;
using AutoMapper;
using Core.Persistence.Paging;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Models.Queries.GetListPagination
{
    public class GetListPaginationModelQueryHandler : IRequestHandler<GetListPaginationModelQuery, ModelListModel>
    {
        private readonly IModelRepository _modelRepository;
        private readonly IMapper _mapper;

        public GetListPaginationModelQueryHandler(IModelRepository modelRepository, IMapper mapper)
        {
            _modelRepository = modelRepository;
            _mapper = mapper;
        }

        public async Task<ModelListModel> Handle(GetListPaginationModelQuery request, CancellationToken cancellationToken)
        {
            IPaginate<Model> models = await _modelRepository.GetListPaginateAsync
                 (index: request.PageRequest.Page, size: request.PageRequest.PageSize, include: x => x.Include(x => x.Brand));
            ModelListModel modelListModel = _mapper.Map<ModelListModel>(models);
            return modelListModel;
        }
    }
}
