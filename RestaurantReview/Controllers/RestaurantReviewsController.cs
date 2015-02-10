using RestaurantReview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantReview.Controllers
{
    public class RestaurantReviewsController : Controller
    {
        private RestaurantContext context = new RestaurantContext();
        //
        // GET: /RestaurantReviews/

        public ActionResult Index([Bind(Prefix= "id")] int restaurentId)
        {
            var restaurent = context.Restaurants.Find(restaurentId);
            restaurent.Reviews = context.Reviews.Where(p => p.RestaurantId == restaurentId).ToList();
            if(restaurent != null)
            {
                return View(restaurent);
            }
            return HttpNotFound();
        }

        //
        // GET: /RestaurantReviews/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /RestaurantReviews/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /RestaurantReviews/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /RestaurantReviews/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /RestaurantReviews/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /RestaurantReviews/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /RestaurantReviews/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
