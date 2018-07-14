using System.Web.Mvc;

namespace ArmchairLeague.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {            
            return Redirect("draft");
        }
    }
}
