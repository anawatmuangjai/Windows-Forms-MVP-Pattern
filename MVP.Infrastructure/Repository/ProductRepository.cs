using MVP.Core.Dtos;
using MVP.Core.Interfaces;
using MVP.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Infrastructure.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly MvpDbContext _context;

        public ProductRepository(MvpDbContext context)
        {
            _context = context;
        }

        public ProductDto GetProduct()
        {
            throw new NotImplementedException();
        }
    }
}
