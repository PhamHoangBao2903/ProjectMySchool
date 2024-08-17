using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using PagedList;
using PagedList.Mvc;
using QL_BadmintonShop.Models;
namespace QL_BadmintonShop.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            //if (page == null)
            //    page = 1;
            //int pageSize = 3;
            //int pageNumber = (page ?? 1);int? page

            //var listSP = db.SANPHAMs.OrderBy(s => s.TENSP).ToList();listSP.ToPagedList(pageNumber, pageSize)

            return View();
            
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