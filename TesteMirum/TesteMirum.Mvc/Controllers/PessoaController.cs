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
        public ActionResult ListaPessoa()
        {
            return View();
        }
        [HttpPost]
        public ActionResult _ListaPessoa(string Cod_Pessoa,int isBotaoPesquisar = 0)
        {
            try
            {
                if (isBotaoPesquisar == 1 && String.IsNullOrEmpty(Cod_Pessoa))
                    throw new Exception();

                if (String.IsNullOrEmpty(Cod_Pessoa))
                    return PartialView(_pessoaApplicationService.GetAll());

                return PartialView(_pessoaApplicationService.GetByFilter(Cod_Pessoa));
            }
            catch (Exception)
            {
                throw;
            }
           
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
