using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace DResourceProject.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : DResourceProjectControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}