using KTStore.Library.Helper;
using System;
using System.Web.Mvc;

namespace KTStore.Controllers
{
    public class ProductsController : Controller
    {
       
        public ActionResult Sales()
        {
            return View("Sales");
        }
    }
}
