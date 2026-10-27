using hungga.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace hungga.Controllers
{
    public class CategoryController1 : Controller
    {
        // csdl
        public static List<Category> categories = new List<Category>()
        {
            new Category() { Id = 1,Name = "laptop"},
            new Category() { Id = 2,Name = "laptop"},
            new Category() { Id = 3,Name = "laptop"},

        };

        // GET: categoryController1
        public ActionResult Index()
        {
            return View(categories);
        }

        // GET: categoryController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: categoryController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: categoryController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: categoryController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: categoryController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: categoryController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: categoryController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
