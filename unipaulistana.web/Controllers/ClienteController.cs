namespace unipaulistana.web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using unipaulistana.model;

    public class ClienteController : Controller
    {
        public ClienteController(IClienteService clienteService)
        {
            this.clienteService = clienteService;
        }

        readonly IClienteService clienteService;

        public IActionResult Index()
        { 
            if(TempData["mensagemIndex"] != null)
            {
                ViewBag.Sucesso = TempData["mensagemIndex"];
            } 

            return View(this.clienteService.ObterTodos());
        }
        
        public IActionResult Criar()
        {
             return View();
        }

        [HttpPost]
        public IActionResult Criar(Cliente dados)
        {
            try
            {
                this.clienteService.Adicionar(dados);
                TempData["mensagemIndex"] = "Cliente inserido com sucesso."; 
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("error", string.Format("Ocorreu um erro ao tentar atualizar o usuário:", ex.Message));
                return View(dados);
            }
        }

        public IActionResult Alterar(int id)
        {
            if(TempData["mensagemEdicao"] != null)
            {
                ViewBag.Sucesso = TempData["mensagemEdicao"];
            } 

            return View(this.clienteService.ObterPorID(id));
        }

        [HttpPost]
        public IActionResult Alterar(Cliente dados)
        {
            try
            {
                this.clienteService.Atualizar(dados);
                TempData["mensagemEdicao"] = "Cliente atualizado com sucesso."; 
                return RedirectToAction("Alterar", dados.ClienteID);
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("error", string.Format("Ocorreu um erro ao tentar atualizar o usuário:", ex.Message));
                return View(dados);
            }
        }

        public IActionResult Excluir(int id)
        {
            return View(this.clienteService.ObterPorID(id));
        }

        [HttpPost]
        public ActionResult Excluir(Cliente dados)
        {
            try
            {
                this.clienteService.Excluir(dados.ClienteID);
                TempData["mensagemIndex"] = "Cliente excluído com sucesso."; 
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("error", string.Format("Ocorreu um erro ao tentar atualizar o usuário:", ex.Message));
                return View(dados);
            }
        }
    }
}
