using Microsoft.AspNetCore.Mvc;

namespace MVC_PROJE.Controllers.Admin
{
    public class AdminHomeController : BaseAdminController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
