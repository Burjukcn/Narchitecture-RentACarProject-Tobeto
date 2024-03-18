

using Domain.Entities;
using NarchitectureCorePersistence.Repositories;

namespace Application.Service.Repositories
{
    public interface IBrandRepository : IAsyncRepository<Brand, int>// brand özel operasyonların olursa buraya yazın diye yazdık 
    {

    }
}
