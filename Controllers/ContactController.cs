using Microsoft.AspNetCore.Mvc;

namespace MvcRoutingAttributesApp.Controllers
{
    [Route("info/{action=Index}")]
    public class ContactController : Controller
    {
        
        public IActionResult Index()
        {
            return Content("Contact page");
        }
        public IActionResult Map()
        {
            return Content("Contact Map page");
        }
    }
}
