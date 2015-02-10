using RestaurantReview.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RestaurantReview.Models
{
    public class RestaurantContext : DbContext
    {
        public RestaurantContext()
            : base("name=DefaultConnection")
        {
        }
        
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Review> Reviews { get; set; }
 
    }
}