using Microsoft.AspNetCore.Mvc;

namespace MVC_PROJE.Controllers.User
{
    public class UserBlogController : BaseUserController
    {
        public IActionResult Search(string query, int page)
        {
            return View();
        }
    }
}
