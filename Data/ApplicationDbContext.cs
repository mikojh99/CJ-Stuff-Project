using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CJSTUFF.Models;
using Microsoft.EntityFrameworkCore;

namespace CJSTUFF.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Register> Registers { get; set; }
    }
}
