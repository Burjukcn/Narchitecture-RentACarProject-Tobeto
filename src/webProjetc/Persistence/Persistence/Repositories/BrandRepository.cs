using Application.Service.Repositories;
using Core.Persistence.Repositories.EntityFramework;
using Domain.Entities;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class BrandRepository : EfRepositoryBase<Brand, int, BaseDbContext>, IBrandRepository
    {
        public BrandRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
