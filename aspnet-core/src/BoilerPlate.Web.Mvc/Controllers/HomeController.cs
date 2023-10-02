using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using BoilerPlate.Controllers;

namespace BoilerPlate.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : BoilerPlateControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
