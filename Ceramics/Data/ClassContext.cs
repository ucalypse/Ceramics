using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ceramics.Models.DataModels;
using Microsoft.EntityFrameworkCore;

namespace Ceramics.Data
{
    public class ClassContext : DbContext
    {
        public ClassContext(DbContextOptions<ClassContext> options) : base(options)
        {
            
        }
       public DbSet<ClassModel> Classes { get; set; }
       public DbSet<StudentModel> Students { get; set; }
    }
}
