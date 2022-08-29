using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace WebApplication.Models
{
    public class Repository 
    {
        public List<FootballLeague> GetAllLeageDetails()
        {
            return new LeagueDbContext().FootballLeagues.ToList();
        }
    }
}