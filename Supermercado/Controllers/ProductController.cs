using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Supermercado.Controllers
{
    public class ProductController : Controller
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

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Store(IFormCollection model)
        {
            var id = Convert.ToInt16(model["id"]);
            var name = model["name"];
            var price = Convert.ToInt16(model["price"]);
            fruits.Add(new(4, "Lime", 2.0));
            return RedirectToAction("Details", "Produto", model["id"]);
        }

        public IActionResult Edit(int id)
        {
            var fruit = fruits[id];
            return View(fruit);

        }

        public IActionResult Delete(int id)
        {
            var fruit = fruits[id];
            return View(fruit);

        }
    }
}
