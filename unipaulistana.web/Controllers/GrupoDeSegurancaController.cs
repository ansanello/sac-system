namespace unipaulistana.web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using unipaulistana.model;
    using Microsoft.AspNetCore.Authorization;

    [Authorize]
    public class GrupoDeSegurancaController : Controller
    {
        public GrupoDeSegurancaController(IGrupoDeSegurancaService grupoDeSegurancaService)
        {
            this.grupoDeSegurancaService = grupoDeSegurancaService;
        }

        readonly IGrupoDeSegurancaService grupoDeSegurancaService;

        public IActionResult Index()
        { 
            if(TempData["mensagemIndex"] != null)
            {
                ViewBag.Sucesso = TempData["mensagemIndex"];
            } 

            return View(this.grupoDeSegurancaService.ObterTodos());
        }
        
        public IActionResult Criar()
        {
             return View();
        }

        [HttpPost]
        public IActionResult Criar(GrupoDeSeguranca dados)
        {
            if (!ModelState.RemoveKeyModelState("GrupoDeSegurancaID").IsValid)
                return View(dados);

            try
            {
                this.grupoDeSegurancaService.Adicionar(dados);
                TempData["mensagemIndex"] = "Grupo inserido com sucesso."; 
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("error", string.Format("Ocorreu um erro ao tentar atualizar o grupo:", ex.Message));
                return View(dados);
            }
        }

        public IActionResult Alterar(int id)
        {
            if(TempData["mensagemEdicao"] != null)
            {
                ViewBag.Sucesso = TempData["mensagemEdicao"];
            } 

            return View(this.grupoDeSegurancaService.ObterPorID(id));
        }

        [HttpPost]
        public IActionResult Alterar(GrupoDeSeguranca dados)
        {
            if (!ModelState.IsValid)
                return View(dados);

            try
            {
                this.grupoDeSegurancaService.Atualizar(dados);
                TempData["mensagemEdicao"] = "Grupo atualizado com sucesso."; 
                return RedirectToAction("Alterar", dados.GrupoDeSegurancaID);
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("error", string.Format("Ocorreu um erro ao tentar atualizar o grupo:", ex.Message));
                return View(dados);
            }
        }

        public IActionResult Excluir(int id)
        {
            return View(this.grupoDeSegurancaService.ObterPorID(id));
        }

        [HttpPost]
        public ActionResult Excluir(Departamento dados)
        {
            try
            {
                this.grupoDeSegurancaService.Excluir(dados.DepartamentoID);
                TempData["mensagemIndex"] = "Grupo excluído com sucesso."; 
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("error", string.Format("Ocorreu um erro ao tentar excluir o grupo:", ex.Message));
                return View(dados);
            }
        }
    }
}
