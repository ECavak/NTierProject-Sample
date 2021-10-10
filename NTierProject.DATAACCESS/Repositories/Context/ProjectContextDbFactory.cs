using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace NTierProject.DATAACCESS.Repositories.Context
{
    public class ProjectContextDbFactory:IDesignTimeDbContextFactory<ProjectContext>
    {

        public ProjectContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ProjectContext>();
            optionsBuilder.UseSqlServer(@"server =.; DataBase = BOOSTOnlineNTierDB; uid = sa; Password = 123;");
            return new ProjectContext(optionsBuilder.Options);

        }
    }
}
