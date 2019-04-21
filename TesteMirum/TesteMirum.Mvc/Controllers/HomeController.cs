using System.Web.Mvc;
using TesteMirum.Application.Interfaces;

namespace TesteMirum.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPessoaApplicationService _pessoaApplicationService;
        public HomeController(IPessoaApplicationService pessoaApplicationService)
        {
            this._pessoaApplicationService = pessoaApplicationService;
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}