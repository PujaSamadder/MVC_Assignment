using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace CustomerManagementSystem.Models
{
    public partial class CMS_DbContext : DbContext 
    {
        public CMS_DbContext()
            : base("name=CMS_DBContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CUSTOMER> CUSTOMERs { get; set; }
    }
}