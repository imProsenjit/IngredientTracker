using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IngredientTracker.Models;
using System.Data.Entity;

namespace IngredientTracker.DataContext
{
    public class DBIngredientTracker:DbContext
    {
        public DbSet<ManagerRegistration> ManagerRegistrations { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Chef> Chefs { get; set; }
    }
}