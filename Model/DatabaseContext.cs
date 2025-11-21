using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entities;
using technova_ecom.Model.Entities;

namespace Model
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<Customer> customers{ get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Category> categories { get; set; }
       
    }
}
