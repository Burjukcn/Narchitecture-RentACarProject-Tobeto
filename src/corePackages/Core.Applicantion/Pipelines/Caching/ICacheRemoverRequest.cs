using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Applicantion.Pipelines.Caching
{
    public interface ICacheRemoverRequest
    {
        bool BypassCache { get; }
        string CacheKey { get; }
    }
}
