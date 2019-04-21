using System;
using System.Web.Mvc;
using TesteMirum.Application.Interfaces;
using TesteMirum.Application.ViewModels.Pessoa;

namespace TesteMirum.Mvc.Controllers
{

    public class PessoaController : Controller
    {
        private readonly IPessoaApplicationService _pessoaApplicationService;
        private readonly ICargoApplicationService _cargoApplicationService;
        public PessoaController(
            IPessoaApplicationService pessoaApplicationService
            , ICargoApplicationService cargoApplicationService
            )
        {
            this._pessoaApplicationService = pessoaApplicationService;
            this._cargoApplicationService = cargoApplicationService;
        }
        
        public ActionResult Index()
        {
            BindViewBag();
            return View();
        }


        private void BindViewBag()
        {
            var cargos = _cargoApplicationService.GetAll();           
            ViewBag.ListaCargos = new SelectList(cargos, "Id", "Cargo_Nome");
        }
         [HttpPost]
        public ActionResult _Lista()
        {
            return PartialView(_pessoaApplicationService.GetAll());
        }       
               
        [HttpPost]
        public ActionResult Criar(PessoaViewModel pessoa)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    BindViewBag();
                    return View("Index");
                }
                _pessoaApplicationService.AddPessoa(pessoa);

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {

                return RedirectToAction("Index");
            }
        }        
        [HttpPost]
        public ActionResult Editar(PessoaViewModel editarPessoa)
        {
            try
            {
                _pessoaApplicationService.EditarPessoa(editarPessoa);

                return PartialView("_Lista", _pessoaApplicationService.GetAll());
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult Excluir(int id)
        {
            try
            {
                _pessoaApplicationService.Excluir(id);

                return PartialView("_Lista", _pessoaApplicationService.GetAll());
            }
            catch
            {
                return View();
            }
        }
    }
}
