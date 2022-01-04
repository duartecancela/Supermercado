using Microsoft.AspNetCore.Mvc;


namespace Supermercado.Controllers
{
    public class ProdutoController : Controller
    {
        //Fruit banana = new(1, "Banana", 2.4);
        //Fruit orange = new(2, "Orange", 1.4);
        //Fruit apple = new(1, "Apple", 1.8);

        //List<Fruit> fruits = new List<Fruit>();
        //static Fruit[] fruits = { new(1, "Banana", 2.4), new(2, "Orange", 1.4), new(1, "Apple", 1.8) };
        List<Fruit> fruits = new List<Fruit>() { new(1, "Banana", 2.4), new(2, "Orange", 1.4), new(1, "Apple", 1.8) };

        public IActionResult Index()
        {
            ViewData["fruits"] = fruits;
            return View();
           
        }
    }
}
