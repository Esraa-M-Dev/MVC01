using Microsoft.AspNetCore.Mvc;
namespace Assignment01MVC.Controllers
{
    public class MembersControlles : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetMembers(int id)
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
