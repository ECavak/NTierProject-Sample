using NTierProject.DATAACCESS.Repositories.Context;
using NTierProject.ENTITIES.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NTierProject.DATAACCESS.Repositories.Concrate
{
    public class UserRepository : Repository<User>
    {
        private readonly ProjectContext _context;
        public UserRepository(ProjectContext context) : base(context)
        {
            _context = context;
        }

        public User FindByUserName(string userName)
        {
            return GetByDefault(x => x.Name == userName);
        }
        public bool CheckCredential(string userName,string password)
        {
            return Any(x => x.Username == userName && x.Password == password);
        }

    }
}

