using NTierProject.DATAACCESS.Repositories.Context;
using NTierProject.ENTITIES.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NTierProject.DATAACCESS.Repositories.Concrate
{
   public class ProductRepository:Repository<Product>
    {
        private readonly ProjectContext _context;
        public ProductRepository(ProjectContext context) : base(context)
        {
             _context= context;
        }
    }
}
