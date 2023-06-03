using Microsoft.AspNetCore.Mvc;

namespace MVC_PROJE.Controllers.Admin
{
    public class BaseAdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
