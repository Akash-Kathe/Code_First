using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First.Models
{
    internal class StudentsContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectModels;Initial Catalog=kathe;Integrated Security=True"); 
          
        }
        public DbSet<Students> Students { get; set; }
        public DbSet<Grade> Grade { get; set; }
    }
}
