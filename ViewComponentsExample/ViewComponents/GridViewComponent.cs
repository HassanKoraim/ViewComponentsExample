using Microsoft.AspNetCore.Mvc;

namespace ViewComponentsExample.ViewComponents
{
    public class GridViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("Sample"); // Invoked the partial view in Views/Shared/Components/Grid/Default.cshtml
        }
    }
}
