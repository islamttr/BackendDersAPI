using DersAPI.Application.Repositories;
using DersAPI.Domain.Entitities;
using DersAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersAPI.Persistence.Repositories
{
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
    {
        public ProductReadRepository(DersAPIDbContext context) : base(context)
        {
        }
    }
}
