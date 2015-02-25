using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIWebApp.Data;
using BIWebApp.Repository.Models.Mapping;

namespace BIWebApp.Repository
{
    public class BIWebAppDBContext : DbContext
    {
        static BIWebAppDBContext()
        {
            Database.SetInitializer<BIWebAppDBContext>(null);
        }

        public BIWebAppDBContext()
            : base("Name=BIWebAppDBContext")
        {
        }

        public DbSet<BI_K3_Costs> Costs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BI_K3_CostsMap());
        }
    }
}
