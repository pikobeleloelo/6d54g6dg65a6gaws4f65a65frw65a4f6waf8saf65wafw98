using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        [Route("base/relased/{year}/{month:regex(\\d{4}):rage(1,12)}")]
        public ActionResult ByRelasesYear(int year, int month)
        {

            return Content(year + "/" + month);
        }


        public ActionResult Edit(int id)
        {
            return Content("id= " + id);
        }

        public ActionResult Add()
        {
            var add = new Base() { Name = "Dodawanie rekordu " };
            ViewResult.ViewData.Model

            return View(add);
        }


    }
}