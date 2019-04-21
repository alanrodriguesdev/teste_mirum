using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TesteMirum.Application.Interfaces;
using TesteMirum.Application.ViewModels.Cargo;

namespace TesteMirum.Mvc.Controllers
{
    public class CargoController : Controller
    {
        private readonly ICargoApplicationService _cargoApplicationService;
        private readonly IPessoaApplicationService _pessoaApplicationService;
        public CargoController(ICargoApplicationService cargoApplicationService
            , IPessoaApplicationService pessoaApplicationService)
        {
            this._cargoApplicationService = cargoApplicationService;
            this._pessoaApplicationService = pessoaApplicationService;
        }
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Criar(CargoViewModel cargo)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View("Index");
                }
                _cargoApplicationService.AddCargo(cargo);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {

                return RedirectToAction("Index");
            }
        }
        public ActionResult ListaCargo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult _ListaCargo(string Cod_Cargo, int isBotaoPesquisar = 0)
        {
            try
            {
                if (isBotaoPesquisar == 1 && String.IsNullOrEmpty(Cod_Cargo))
                    throw new Exception();

                if (String.IsNullOrEmpty(Cod_Cargo))
                    return PartialView(_cargoApplicationService.GetByFilter());

                return PartialView(_cargoApplicationService.GetByFilter(Cod_Cargo));
            }
            catch (Exception)
            {
                throw;
            }

        }
        public ActionResult _Lista()
        {
            return PartialView(_cargoApplicationService.GetAll());
        }
        public ActionResult Editar(CargoViewModel editarCargo)
        {
            try
            {
                _cargoApplicationService.EditarCargo(editarCargo);

                return PartialView("_Lista", _cargoApplicationService.GetAll());
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
                _pessoaApplicationService.ExcluirPessoaByCargoId(id);
                _cargoApplicationService.Excluir(id);

                return PartialView("_Lista", _cargoApplicationService.GetAll());
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public JsonResult QuantidadePessoas(int cargoId)
        {
            return Json(new { quantPessoas = _pessoaApplicationService.GetQuantPessoasByCargoId(cargoId) },JsonRequestBehavior.AllowGet);
        }
    }
}