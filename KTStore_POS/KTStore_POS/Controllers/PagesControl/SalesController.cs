using System.Web.Mvc;

namespace KTStore.Controllers.PagesControl
{
    public class SalesController : Controller
    {
        // GET: Sales
        public ActionResult POS()
        {
            return View("POS");
        }

        public ActionResult Index()
        {
            return View("POS");
        }
    }
}