using Microsoft.AspNetCore.Mvc;

namespace MVC_PROJE.Controllers.Admin
{
    public class AdminBlogController : BaseAdminController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
