using System.Web.Mvc;

namespace BeautyGoddess.Controllers
{
    public class IndexController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}