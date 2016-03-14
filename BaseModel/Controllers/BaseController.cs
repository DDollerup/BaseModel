using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaseModel.Models.BaseModels;

namespace BaseModel.Controllers
{
    public class BaseController : Controller
    {
        List<Site> pages = new List<Site>();

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            pages.Add(new Site()
            {
                PageID = 1,
                Text = "Tekst 1",
                Image = "placeholder.jpg",
                MetaDescription = "Page 1",
                PageTitle = "Page 1"
            });

            pages.Add(new Site()
            {
                PageID = 2,
                Text = "Tekst 2",
                Image = "placeholder.jpg",
                MetaDescription = "Page 2",
                PageTitle = "Page 2"
            });

            pages.Add(new Site()
            {
                PageID = 3,
                Text = "Tekst 3",
                Image = "placeholder.jpg",
                MetaDescription = "Page 3",
                PageTitle = "Page 3"
            });

            ViewBag.Pages = pages;

            base.OnActionExecuting(filterContext);
        }

        public ActionResult Site(int id)
        {
            Site selectedSite = pages.Find(x => x.PageID == id);
            return View(selectedSite);
        }

    }
}