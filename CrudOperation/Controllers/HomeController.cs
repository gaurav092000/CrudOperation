using CrudOperation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudOperation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        CrudContext cr=new CrudContext();
        public ActionResult Category() 
        {
            var data=cr.categories.ToList();
            return View(data);
        }

        public ActionResult Create() 
        {
            return View();
        }
        [HttpPost]

        public ActionResult Create(Category c)
        {
            if (ModelState.IsValid == true)
            {
                cr.categories.Add(c);
                int n = cr.SaveChanges();
                if(n>0)
                {
                    TempData["Create"] = "<script>alert('DATA SAVA SUCCESSFULLY')</script>";
                    return RedirectToAction("Category");
                }
                else
                {
                    TempData["Create"] = "<script>alert('DATA NOT SAVA SUCCESSFULLY')</script>";
                }

            }
            return View();
        }

        

       
    }
}