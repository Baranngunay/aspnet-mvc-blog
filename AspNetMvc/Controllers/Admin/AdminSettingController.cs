using Microsoft.AspNetCore.Mvc;

namespace MVC_PROJE.Controllers.Admin
{
    public class AdminSettingController : BaseAdminController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
