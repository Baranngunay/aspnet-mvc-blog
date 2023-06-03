using Microsoft.AspNetCore.Mvc;

namespace MVC_PROJE.Controllers.Admin
{
    public class AdminCategoryController : BaseAdminController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
