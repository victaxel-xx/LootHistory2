using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using LootHistory2.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace LootHistory2.Data
{
    public class LootContext : DbContext
    {
        public LootContext() : base("LootContext")
        {
        }

        public DbSet<Character> Characters { get; set; }
        public DbSet<LootEvent> LootEvents { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}