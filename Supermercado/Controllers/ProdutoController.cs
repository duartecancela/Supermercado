using Microsoft.AspNetCore.Mvc;

namespace Supermercado.Controllers
{
    public class ProdutoController : Controller
    {
       
        List<Fruit> fruits = new List<Fruit>() { new(1, "Banana", 2.4), new(2, "Orange", 1.4), new(3, "Apple", 1.8) };

        public IActionResult Index()
        {
            ViewBag.fruits = fruits;
            return View();
           
        }

        public IActionResult List1()
        {
            ViewBag.fruits = fruits;
            return View(fruits);

        }

        public IActionResult Details1(int id)
        {
            var fruit = fruits[id];
            ViewData["fruitId"] = fruit.id;
            ViewData["fruitName"] = fruit.name;
            ViewData["fruitprice"] = fruit.price;
            return View();

        }

        //public JsonResult ListJSON()
        //{
        //    return Json(fruits);
        //}

        public JsonResult ListJSON(int id)
        {
            if (id >= 1 )
                {
                    return Json(fruits[id - 1]); 
                }
            else
                {
                    return Json(fruits);
            }  
        }

        public IActionResult List()
        {
            
            return View(fruits);

        }

        public IActionResult Details(int id)
        {
            var fruit = fruits[id];
            return View(fruit);

        }
    }
}
