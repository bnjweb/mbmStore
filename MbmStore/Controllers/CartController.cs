using MbmStore.Data;
using MbmStore.Infrastructure;
using MbmStore.Models;
using MbmStore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace MbmStore.Controllers
{
    public class CartController : Controller
    {
        private Cart cart;
        private MbmStoreContext dataContext;

       
        public CartController(MbmStoreContext dbContext, Cart cartService)
        {
            dataContext = dbContext;
            cart = cartService;
        }

        public ViewResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = cart,
                ReturnUrl = returnUrl
            });
        }

        public RedirectToActionResult AddToCart(int productId, string returnUrl)
        {
            Product product = dataContext.Products
            .FirstOrDefault(p => p.ProductId == productId);
            if (product != null)
            {
                cart.AddItem(product, 1);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToActionResult RemoveFromCart(int productId, string returnUrl)
        {
            Product product = dataContext.Products
            .FirstOrDefault(p => p.ProductId == productId);
            if (product != null)
            {
                cart.RemoveLine(product);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
    }
}
