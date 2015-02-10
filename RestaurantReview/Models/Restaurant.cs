using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantReview.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public ICollection<Review> Reviews { get; set; }

        //public int CountOfReviews { get; set; }

    }
}