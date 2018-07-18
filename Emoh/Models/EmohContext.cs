using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Emoh.Models
{
    public class EmohContext : DbContext
    {
        //My Code -> For web api and add service in startup
        public EmohContext(DbContextOptions<EmohContext> options)
            : base(options)
        {
        }

        //My Code -> For migration and its connection string
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Emoh.Helpers.Constants.LocalEmohConnectionString);
        }
        public DbSet<Student> Students { get; set; }
    }
}
