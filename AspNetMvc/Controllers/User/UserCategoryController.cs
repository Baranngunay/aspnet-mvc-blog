using Microsoft.AspNetCore.Mvc;

namespace MVC_PROJE.Controllers.User
{
    public class UserCategoryController : BaseUserController
    {
        public IActionResult Index(int id, int page)
        {
            return View();
        }
    }
}
