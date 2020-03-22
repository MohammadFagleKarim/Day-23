using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WebApp.Model.Model;

namespace WebApp.DatabaseContext.DatabaseContext
{
    public class ProjectDbContext : DbContext
    {
        public DbSet<Student> Students { set; get; }
    }
}
