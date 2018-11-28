using Microsoft.AspNetCore.Antiforgery;
using LibraryApp.Controllers;

namespace LibraryApp.Web.Host.Controllers
{
    public class AntiForgeryController : LibraryAppControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
