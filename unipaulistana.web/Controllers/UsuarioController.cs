namespace unipaulistana.web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using unipaulistana.model;

    public class UsuarioController : Controller
    {
        public UsuarioController(IUsuarioService usuarioService)
        {
            this.usuarioService = usuarioService;
        }

        readonly IUsuarioService usuarioService;

        public IActionResult Index()
        { 
            if(TempData["mensagemIndex"] != null)
            {
                ViewBag.Sucesso = TempData["mensagemIndex"];
            } 

            return View(this.usuarioService.ObterTodos());
        }
        
        public IActionResult Criar()
        {
             return View();
        }

        [HttpPost]
        public IActionResult Criar(Usuario dados)
        {
            if (!ModelState.IsValid)
                return View(dados);

            try
            {
                this.usuarioService.Adicionar(dados);
                TempData["mensagemIndex"] = "Usuário inserido com sucesso."; 
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

            return View(this.usuarioService.ObterPorID(id));
        }

        [HttpPost]
        public IActionResult Alterar(Usuario dados)
        {
            if (!ModelState.IsValid)
                return View(dados);

            try
            {
                this.usuarioService.Atualizar(dados);
                TempData["mensagemEdicao"] = "Usuário atualizado com sucesso."; 
                return RedirectToAction("Alterar", dados.UsuarioID);
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("error", string.Format("Ocorreu um erro ao tentar atualizar o usuário:", ex.Message));
                return View(dados);
            }
        }

        public IActionResult Excluir(int id)
        {
            return View(this.usuarioService.ObterPorID(id));
        }

        [HttpPost]
        public ActionResult Excluir(Usuario dados)
        {
            try
            {
                this.usuarioService.Excluir(dados.UsuarioID);
                TempData["mensagemIndex"] = "Usuário excluído com sucesso."; 
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
