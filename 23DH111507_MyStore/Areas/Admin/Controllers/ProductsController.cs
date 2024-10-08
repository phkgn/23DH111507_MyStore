using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _23DH111507_MyStore.Areas.Admin.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Admin/Product
        public ActionResult Index()
        {
            return View();
        }
    }
}