using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using CC_MVC.Models;
using CC_MVC.Repository;
namespace CC_MVC.Controllers
{
    public class MoviesController : Controller
    {
        ImovieRepository<movie> movierepo = null;

        public MoviesController()
        {
            movierepo = new MovieRepository<movie>();
        }

        // GET: Movies
        public ActionResult Index()
        {
            var movie = movierepo.GetAll();
            return View(movie);
        }

        //2. Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(movie m)
        {
            if (ModelState.IsValid)
            {
                movierepo.Insert(m);
                movierepo.Save();
                return RedirectToAction("Index");
            }
            return View(m);
        }

        //3. Edit a Movie(Modification)
        public ActionResult Edit(int Id)
        {
            var movie = movierepo.GetById(Id);
            return View(movie);
        }

        [HttpPost]
        public ActionResult Edit(movie m)
        {
            if (ModelState.IsValid)
            {
                movierepo.Update(m);
                movierepo.Save();
                return RedirectToAction("Index");
            }
            else
            {
                return View(m);
            }
        }


        public ActionResult MoviesByYear(int year)
        {
            ViewBag.Year = year;
            return View();
        }

        //Delete a specific Movie
        public ActionResult Delete(int Id)
        {
            var movie = movierepo.GetById(Id);
            return View(movie);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeletePost(int Id)
        {
            var product = movierepo.GetById(Id);
            movierepo.Delete(Id);
            movierepo.Save();
            return RedirectToAction("Index");
        }
    }
}
