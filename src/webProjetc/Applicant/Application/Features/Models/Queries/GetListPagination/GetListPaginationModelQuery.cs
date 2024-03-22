using Application.Features.Models.Models;
using Application.Request;
using Core.Applicantion.Pipelines.Caching;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Models.Queries.GetListPagination
{
    public class GetListPaginationModelQuery : IRequest<ModelListModel>, ICachableRequest
    {
        public PageRequest PageRequest { get; set; }

        public bool BypassCache { get; }
        public string CacheKey => "model-list";

        public TimeSpan? SlidingExpiration { get; }
    }
}
