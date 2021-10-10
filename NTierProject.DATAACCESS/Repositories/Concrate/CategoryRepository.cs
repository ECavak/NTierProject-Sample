using NTierProject.DATAACCESS.Repositories.Context;
using NTierProject.ENTITIES.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NTierProject.DATAACCESS.Repositories.Concrate
{
    public class CategoryRepository:Repository<Category>
    {
        private readonly ProjectContext _context;
        public CategoryRepository(ProjectContext context):base(context)
        {
            _context = context;
        }
    }
}
