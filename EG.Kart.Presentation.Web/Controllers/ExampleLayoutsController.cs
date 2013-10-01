using System.Web.Mvc;

namespace EG.Kart.Presentation.Web.Controllers
{
    public class ExampleLayoutsController : Controller
    {
        public ActionResult Starter()
        {
            return View();
        }

        public ActionResult Marketing()
        {
            return View();
        }

        public ActionResult Fluid()
        {
            return View();
        }

        public ActionResult StickyFooter()
        {
            return View("TBD");
        }

        public ActionResult Carousel()
        {
            return View("TBD");
        }
    }
}
