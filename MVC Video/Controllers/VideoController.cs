using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Video.Models ;

namespace MVC_Video.Controllers
{
    public class VideoController : Controller
    {
        // GET: Video
        public ActionResult Index()
        {
            using (mvcEntities1 dbModel = new mvcEntities1())
            {
                return View(dbModel.Movies.ToList());//this list all the movies the are in the database
            }
                
        }

        // GET: Video/Details/5
        public ActionResult Details(int id)
        {
            using (mvcEntities1 dbModel = new mvcEntities1())
            {
                return View(dbModel.Movies.Where(x=>x.Id== id).FirstOrDefault());//this selects the id of the movie and show it details
            }
                
        }

        // GET: Video/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Video/Create
        [HttpPost]
        public ActionResult Create(Movy movie)
        {
            try
            {
                using (mvcEntities1 dbModel = new mvcEntities1())//this add the movie to the databse
                {
                    dbModel.Movies.Add(movie);
                    dbModel.SaveChanges();
                }

                    // TODO: Add insert logic here

                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Video/Edit/5
        public ActionResult Edit(int id)
        {
            using (mvcEntities1 dbModel = new mvcEntities1())
            {
                return View(dbModel.Movies.Where(x => x.Id == id).FirstOrDefault());//this selects the id of the movie
            }
        }

        // POST: Video/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Movy movies)
        {
            try
            {
                using (mvcEntities1 dbModel = new mvcEntities1())
                {
                    dbModel.Entry(movies).State = EntityState.Modified;//this edits the movie 
                    dbModel.SaveChanges();
                }
                return RedirectToAction("Index");

            }
            catch
            {
                return View();
            }
        }

        // GET: Video/Delete/5
        public ActionResult Delete(int id)
        {
            using (mvcEntities1 dbModel = new mvcEntities1())
            {
                return View(dbModel.Movies.Where(x => x.Id == id).FirstOrDefault());//this selets the movie to be deleted 
            }
        }

        // POST: Video/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (mvcEntities1 dbModel = new mvcEntities1())
                {
                    Movy movies = dbModel.Movies.Where(x => x.Id == id).FirstOrDefault();//this delets the movie 
                    dbModel.Movies.Remove(movies);
                    dbModel.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
