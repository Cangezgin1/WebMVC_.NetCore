using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Travelsal_.NetCore.Controllers
{
    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());

        public IActionResult Index()
        {
            var values = destinationManager.TGetList();
            return View(values);
        }


        [HttpGet]
        public IActionResult DestinotionDetails(int id)
        {
            var values = destinationManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult DestinotionDetails(Destination p)
        {
            return View();
        }
    }
}
