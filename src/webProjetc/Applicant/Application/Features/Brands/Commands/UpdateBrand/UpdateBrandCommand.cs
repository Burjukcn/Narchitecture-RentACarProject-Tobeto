

using Application.Features.Brands.Dtos;
using Core.Applicantion.Pipelines.Caching;
using MediatR;

namespace Application.Features.Brands.Commands.UpdateBrand
{

    public class UpdateBrandCommand : IRequest<UpdatedBrandResponse>, ICacheRemoverRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool BypassCache { get; }
        public string CacheKey => "brand-list";
    }
}
