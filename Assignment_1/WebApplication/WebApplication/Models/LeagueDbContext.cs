using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace WebApplication.Models
{

    public partial class LeagueDbContext : DbContext
    {
        public LeagueDbContext()
            : base("name=LeagueDBContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<FootballLeague> FootballLeagues { get; set; }
    }
}