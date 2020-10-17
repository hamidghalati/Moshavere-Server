using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Moshavere.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moshavere.Data.DataBaseContext
{
    public class MoshavereDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder OptionsBuilder)
        {
            OptionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=Moshavere;Integrated Security=True;MultipleActiveResultSets=true;");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<User_Type> User_Type { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Type_advice> type_Advices { get; set; }
        public DbSet<Cost_advice> cost_Advices { get; set; }

    }
}
