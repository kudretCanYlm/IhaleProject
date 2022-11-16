using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using IhaleProject.Controllers;

namespace IhaleProject.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : IhaleProjectControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
