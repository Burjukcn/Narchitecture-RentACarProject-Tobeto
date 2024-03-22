using Application.Service.Repositories;
using Core.Persistence.Repositories.EntityFramework;
using Core.Security.Entities;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class UserOperationClaimRepository : EfRepositoryBase<UserOperationClaim, int, BaseDbContext>, IUserOperationClaimRepository
    {
        public UserOperationClaimRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
