using System.Web.Mvc;
using PetaPoco;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class EmployeeController : Controller
    {


        // GET: Employee
        public ActionResult Index()
        {
            var dataContext = new Database("sqlserverce");
            var employees = dataContext.Query<Employee>("Select * from Employee");
            return View(employees);
        }
           // return View(db.Employees.ToList())

        // GET: Employee/Details/5
        public ActionResult Details(int? id)
        {
            var dataContext = new Database("sqlserverce");
            var employee = dataContext.Single<Employee>("Select * from Employee where employeeId=@0",id);
            return View(employee);
        }

    // GET: Employee/Create
       public ActionResult Create()
       {
           return View();
       }

      [HttpPost]
      public ActionResult Create(Employee employee)
      {
          var dataContext = new Database("sqlserverce");
          dataContext.Insert(employee);
          return RedirectToAction("Index");
      }
    // GET: Employee/Edit/5
    public ActionResult Edit(int id)
    {
        var dataContext = new Database("sqlserverce");
        var employee = dataContext.Single<Employee>("Select * from Employee where employeeId=@0", id);
        return View(employee);
    }

    [HttpPost]
    public ActionResult Edit(Employee employee)
    {
        var dataContext = new Database("sqlserverce");
        dataContext.Update(employee);
        return RedirectToAction("Index");
    }
        public ActionResult Delete(int id)
        {
            var dataContext = new Database("sqlserverce");
            var employee = dataContext.Single<Employee>("Select * from Employee where employeeId=@0",
                                                             id);
            return View(employee);
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection formCollection)
        {
            var dataContext = new Database("sqlserverce");
            dataContext.Delete<Employee>(id);
            return RedirectToAction("Index");
        }
    }
}
