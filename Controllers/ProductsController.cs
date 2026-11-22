using Assignment01MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment01MVC.Controllers
{
    public class ProductsController:Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        public JsonResult GetJsonData()
        {
            var products = GetAllProducts();

            return Json(products);
        }

        public IActionResult GetProducts(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            if (id != 3)
            {
                return NotFound();
            }

            var products = GetAllProducts();

            return Json(products);
        }

        public RedirectToActionResult Redirect()
        {
            return RedirectToAction(
                nameof(GetProducts),
                new { id = 3 }
            );
        }

        public RedirectResult RedirectToFacebook()
        {
            return Redirect("https://www.facebook.com/");
        }

        public ContentResult Content()
        {
            return Content(
                "<h1>Hello from System</h1>",
                "text/html"
            );
        }

        public FileResult DownloadFile()
        {
            var filePath = Path.Combine(
                Directory.GetCurrentDirectory(),
                "wwwroot",
                "css",
                "site.css"
            );

            var fileBytes = System.IO.File.ReadAllBytes(filePath);

            return File(
                fileBytes,
                "text/css",
                "MyCss.css"
            );
        }

        private List<Product> GetAllProducts()
        {
            return new List<Product>
            {
                new Product { Id = 1, Name = "Laptop" },
                new Product { Id = 2, Name = "PC" },
                new Product { Id = 3, Name = "PS" },
                new Product { Id = 4, Name = "Conditioner" }
            };
        }
    }
}
