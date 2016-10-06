using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using XAPI.Models;

namespace XAPI.Data
{
    public class DataContext: DbContext
    {
        private static readonly DataContext instance = new DataContext();
        public static DataContext Instance
        {
            get { return instance; }
        }

        public DbSet<Profile> AspNetUsers { get; set; }
        
        protected DataContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=xapi;Integrated Security=True;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
