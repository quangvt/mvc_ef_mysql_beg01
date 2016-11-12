using mvc_ef_mysql_beg01.Models;
using System.Web.Mvc;

namespace mvc_ef_mysql_beg01.Controllers
{
    public class HomeController : Controller
    {
        private MyDBContext db = new MyDBContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            // Begin: Code Test Entity Framework here
            db.Students.Add(new Student {
                Name = "TranVan",
                Class = "1A"
            });

            db.SaveChanges();
            // End: Code Test Entity Framework here

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}