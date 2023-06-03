using Microsoft.AspNetCore.Mvc;

namespace MVC_PROJE.Controllers.User
{
    public class UserBlogDetailController : BaseUserController
    {
        public IActionResult Detail(int id)
        {
            return View();
        }
    }
}
