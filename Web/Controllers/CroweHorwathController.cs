using CroweHorwath;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class CroweHorwathController : Controller
    {
        // GET: CroweHorwath
        public ActionResult Hello()
        {
            HelloWorld hello = new HelloWorld();
            return View(hello);
        }
    }
}