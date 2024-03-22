using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Security.Entities
{
    public class OperationClaim : BaseEntity<int>
    {
        public string Name { get; set; }

        public OperationClaim()
        {
        }

        public OperationClaim(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
