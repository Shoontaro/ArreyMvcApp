using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using ArreyMvcApp.Models;

namespace ArreyMvcApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult Edit() {
        //    List<Book> books = new List<Book>();
        //    books.Add(new Book { Name = "Testbook 1", Author = "TestAuthor 1", Price = 42});
        //    books.Add(new Book { Name = "Testbook 2", Author = "TestAuthor 2", Price = 42});
        //    books.Add(new Book { Name = "Testbook 3", Author = "TestAuthor 3", Price = 42});
        //    return View(books);
        //}

        //[HttpPost]
        //public string Edit(List<Book> books) {
        //    return books.Count.ToString();
        //}

        public ActionResult GetAuthor() {
            return View();
        }

        [HttpPost]
        public ActionResult GetAuthor(Author author) {
            return View();
        }

        public ActionResult Array() {
            return View();
        }

        [HttpPost]
        public string Array(List<string> names) {
            //string fin = "";

            StringBuilder fin = new StringBuilder();

            for (int i = 0; i < names.Count; i++) {
                fin.Append(names[i] + "; ");
            }
            return fin.ToString();
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}