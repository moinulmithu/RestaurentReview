﻿using RestaurantReview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantReview.Controllers
{
    [Authorize]
    public class RestaurantsController_Old : Controller
    {
        private RestaurantContext Context = new RestaurantContext();
        //
        // GET: /Restaurants/

        public ActionResult Index()
        {

            var model = Context.Restaurants
                .OrderByDescending(r => r.Reviews.Average(review => review.Rating))
                .Take(10)
                .Select(r => new RestaurantViewModel
                {
                    Id = r.Id,
                    Name = r.Name,
                    City = r.City,
                    Country = r.Country,
                    CountOfReviews = r.Reviews.Count()
                }
                );

            return View(model);
        }

        //
        // GET: /Restaurants/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Restaurants/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Restaurants/Create

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
        // GET: /Restaurants/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Restaurants/Edit/5

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
        // GET: /Restaurants/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Restaurants/Delete/5

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
