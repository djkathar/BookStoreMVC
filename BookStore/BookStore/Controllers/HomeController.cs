using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class HomeController:Controller
    {
        [ViewData]
        public string customProperty { get; set; }

        [ViewData]
        public string Title { get; set; }
        public ViewResult Index()
        {
            //ViewBag.Title = 123;
            //dynamic _data = new ExpandoObject();

            //_data.Id = 1;
            //_data.Name = "Dhananjay";

            //ViewBag.data = _data;

            customProperty = "This is custom prop";
            Title = "Home";

            return View();
        }

        public ViewResult AboutUs()
        {
            Title = "About Us";
            return View();
        }

        public ViewResult ContactUs()
        {
            Title = "Contact Us";
            return View();
        }
    }
}
