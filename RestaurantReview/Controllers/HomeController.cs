using RestaurantReview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantReview.Controllers
{
    public class HomeController : Controller
    {
        RestaurantContext _context = new RestaurantContext();

        public ActionResult Index()
        {
           // var model = _context.Restaurants.ToList();

            //var query = from r in _context.Restaurants
            //            orderby r.Reviews.Average(Review => Review.Rating) descending
            //            select r;
            //            //where rng.Reviews.Average(Review => Review.Rating) descending                        
            //            //select rng;

            //var query = from r in _context.Restaurants
            //            orderby r.Reviews.Average(Review => Review.Rating) ascending
            //            select new
            //            {
            //                r.Id,
            //                r.Name,
            //                r.City,
            //                CountofReviews = r.Reviews.Count()
            //            };

            //var query = _context.Restaurants
            //    .Where(r => r.Country == "Bangladesh")
            //    .OrderBy(r => r.Name)
            //    .Skip(1)
            //    .Take(10);

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
