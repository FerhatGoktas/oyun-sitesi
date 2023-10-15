using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace oyun_sitesi.Models
{
    public class EFCodeEntities : DbContext
    {
        public DbSet<Games> Games { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbQuery<Games_Categories> Games_Categories { get; set;}
        public DbSet<Users> Users { get; set; }
        public DbQuery<Score_Games_Users> Score_Games_Users { get; set; }
    }
}