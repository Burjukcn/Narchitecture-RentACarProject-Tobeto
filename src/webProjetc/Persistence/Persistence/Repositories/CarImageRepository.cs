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
    public class CarImageRepository : EfRepositoryBase<CarImage, int, BaseDbContext>, ICarImageRepository
    {
        public CarImageRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
