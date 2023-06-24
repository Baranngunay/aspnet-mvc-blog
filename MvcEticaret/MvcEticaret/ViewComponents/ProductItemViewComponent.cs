using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using MvcEticaret.Models;

namespace MvcEticaret.ViewComponents
{

    public class ProductItemViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string title, int starCount, decimal oldPrice, decimal price, string imageUrl, bool isSale)
        {
            var model = new ProductItemViewModel
            {
                Title = title,
                StarCount = starCount,
                OldPrice = oldPrice,
                Price = price,
                ImageUrl = imageUrl,
                IsSale = isSale
            };

            return View(model);
        }
    }

    
}
