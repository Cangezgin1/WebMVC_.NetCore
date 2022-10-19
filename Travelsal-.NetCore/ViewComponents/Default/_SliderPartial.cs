using Microsoft.AspNetCore.Mvc;

namespace Travelsal_.NetCore.ViewComponents.Default
{
    public class _SliderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
