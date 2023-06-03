using Microsoft.AspNetCore.Mvc;

namespace MVC_PROJE.Controllers.Admin
{
    public class AdminUserController : BaseAdminController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
