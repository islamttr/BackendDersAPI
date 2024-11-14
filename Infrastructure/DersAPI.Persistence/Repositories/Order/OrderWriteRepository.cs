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
    public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
    {
        public OrderWriteRepository(DersAPIDbContext context) : base(context)
        {
        }
    }
}
