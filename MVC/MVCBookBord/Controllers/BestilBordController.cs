using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBookBord.BussinessLogic;
using MVCBookBord.Models;

namespace MVCBookBord.Controllers
{
    public class BestilBordController : Controller
    {
        // GET: BestilBord
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult Step1()
        {
            //ViewBag.Message = "Ste1 - Book Et Bord";
            BestilBordLogic bbl = new BestilBordLogic();
            List<Table> foundTables = bbl.GetAllFreeTables();


            //ViewBag.NumTables = foundTables.First().Id;
            ViewData["tables"] = foundTables;

            return View();
        }

        [Authorize]
        public ActionResult Step2()
        {
            ViewBag.Message = "Step2 - Book Et Bord";

            return View();
        }
    }
}