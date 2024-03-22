﻿using Core.Security.Entities;
using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service.Repositories
{
    public interface IOperationClaimRepository : IAsyncRepository<OperationClaim, int>
    {

    }
}
