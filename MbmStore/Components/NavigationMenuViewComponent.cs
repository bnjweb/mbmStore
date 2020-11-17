using Microsoft.AspNetCore.Mvc;
using System.Linq;
using MbmStore.Infrastructure;
using MbmStore.Data;

namespace MbmStore.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {

        private MbmStoreContext dataContext;

        public NavigationMenuViewComponent(MbmStoreContext dbContext)
        {
            dataContext = dbContext;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(dataContext.Products
            .Select(x => x.Category)
            .Distinct()
            .OrderBy(x => x));
        }
    }
}

