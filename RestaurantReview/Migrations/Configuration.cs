namespace RestaurantReview.Migrations
{
    using RestaurantReview.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RestaurantReview.Models.RestaurantContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(RestaurantReview.Models.RestaurantContext context)
        {
            context.Restaurants.AddOrUpdate(r => r.Name,
                 new Restaurant { Name = "Duio jsws", City = "Duio", Country = "Bd" },
                new Restaurant { Name = "Do jsws", City = "Duio", Country = "Bd" },
                new Restaurant
                {
                    Name = "Do jsws",
                    City = "Duio",
                    Country = "Bd",
                    Reviews = new List<Review> { 
                        new Review {
                            Rating = 9, Body = "bad"
                        }
                    }
                }
                );
        }
    }
}
