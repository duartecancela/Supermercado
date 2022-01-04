using Microsoft.AspNetCore.Mvc;

namespace Supermercado.Controllers
{
    public class ProdutoController : Controller
    {
        Fruit banana = new(1, "Banana", 2.4);
        Fruit orange = new(2, "Orange", 1.4);
        Fruit Apple = new(1, "Apple", 1,8);

        public IActionResult Index()
        {
            ViewData["name"] = banana.name;
            return View();
           
        }
    }
}
