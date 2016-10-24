using System.Data.Entity;
using System.Net;
using System.Web.Mvc;
using petapoco.Models;
using Database = PetaPoco.Database;

namespace petapoco.Controllers
{
    public class MoviesController : Controller
    {
       // private MovieDbContext db = new MovieDbContext();

        // GET: Movies
        public ActionResult Index()
        {
            var dataContext = new Database("MovieDbContext");
            var employees = dataContext.Query<Movie>("Select * from Movies");
            return View(employees);
            // return View(dataContext.Movies.ToList());
        }
        public ActionResult Edit(int id)
        {
            var dataContext = new PetaPoco.Database("MovieDbContext");
            var employee = dataContext.Single<Movie>("Select * from Movies where Id=@0",
                                                             id);
            return View(employee);
        }

        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            var dataContext = new PetaPoco.Database("MovieDbContext");
            dataContext.Update("Movie", "Id", movie);
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var dataContext = new PetaPoco.Database("MovieDbContext");
            var employee = dataContext.Single<Movie>("Select * from Movie where Id=@0",
                                                             id);
            return View(employee);
        }
        public ActionResult Delete(int id)
        {
            var dataContext = new PetaPoco.Database("MovieDbContext");
            var employee = dataContext.Single<Movie>("Select * from Movie where Id=@0",
                                                             id);
            return View(employee);
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection formCollection)
        {
            var dataContext = new PetaPoco.Database("MovieDbContext");
            dataContext.Delete<Movie>(id);
            return RedirectToAction("Index");
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            var dataContext = new PetaPoco.Database("MovieDbContext");
            dataContext.Insert("Movie", "Id", movie);
            return RedirectToAction("Index");
        }
    }
}
