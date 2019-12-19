using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessProvider
{
    public partial class SolutionModel : DbContext
    {
        public SolutionModel()
            : base("name=SolutionModel")
        {
        }

        public virtual DbSet<Models.Models.User> UsersTables { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
