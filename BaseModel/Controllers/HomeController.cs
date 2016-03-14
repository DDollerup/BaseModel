using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaseModel.Models.BaseModels;

namespace BaseModel.Controllers
{
    public class HomeController : BaseController
    {
        // GET: Home
        public ActionResult Index()
        {
            Home home = new Home();
            home.PageTitle = "My BaseModel Site";
            home.MetaDescription = "This is my home page, this is where you can access my page.";

            home.HomeID = 1;
            home.Text = "This is a lot of text";
            home.Image = "placeholder.jpg";

            return View(home);
        }
    }
}