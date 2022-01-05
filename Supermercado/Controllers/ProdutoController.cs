using Microsoft.AspNetCore.Mvc;


namespace Supermercado.Controllers
{
    public class ProdutoController : Controller
    {
       
        List<Fruit> fruits = new List<Fruit>() { new(1, "Banana", 2.4), new(2, "Orange", 1.4), new(1, "Apple", 1.8) };

        public IActionResult Index()
        {
            ViewBag.fruits = fruits;
            return View();
           
        }

        public IActionResult List()
        {
            ViewBag.fruits = fruits;
            return View();

        }

        public IActionResult Details(int id)
        {
            var fruit = fruits[id];
            ViewData["fruitId"] = fruit.id;
            ViewData["fruitName"] = fruit.name;
            ViewData["fruitprice"] = fruit.price;
            return View();

        }
    }
}
