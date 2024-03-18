using Application.Features.Brands.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Commands.DeleteBrand
{
    public class DeleteBrandCommand : IRequest<DeletedBrandResponse>
    {
        public int Id { get; set; }
        public int Interval => 1;

        public bool BypassCache { get; }
        public string CacheKey => "brand-list";
    }
}

