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
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(DersAPIDbContext context) : base(context)
        {
        }
    }
}
