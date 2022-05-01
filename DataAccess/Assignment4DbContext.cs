using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assignment4.Models;

namespace Assignment4.DataAccess
{
    public class Assignment4DbContext : DbContext
    {
        public Assignment4DbContext(DbContextOptions<Assignment4DbContext> options) : base(options)
        {
        }
        
        // Need to change this 

        public DbSet<FoodForMeal> FoodForMeal { get; set; }
        public DbSet<FoodItem> FoodItem { get; set; }
        public DbSet<Meal> Meal { get; set; }

    }
}
