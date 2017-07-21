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

        [Route("Base/relased/{year}/{month:regex(\\d{4}):rage(1,12)}")]
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
            var add = new Base() { Name = "Dodawanie rekordu ;)" };

            //  ViewData["Base"] = add;
            //ViewBag.BaseAdd = add;
            var customers = new List<Customer>
            {
                new Customer { Name = "Komputer 1"},
                new Customer { Name = "Komuter 2"}
            };

            var viewModel = new ViewModels.AddBaseViewModel
            {
                Base = add,
                Customers = customers
            };

            return View(viewModel);
        }


    }
}