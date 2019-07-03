using System.Web.Mvc;

namespace DResourceProject.Web.Controllers
{
    public class AboutController : DResourceProjectControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}