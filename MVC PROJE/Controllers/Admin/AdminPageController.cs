using Microsoft.AspNetCore.Mvc;

namespace MVC_PROJE.Controllers.Admin
{
    public class AdminPageController : BaseAdminController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
