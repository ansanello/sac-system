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
    using Microsoft.AspNetCore.Http;
    using System.IO;
    using unipaulistana.web.Helper;
    using Microsoft.AspNetCore.Hosting;
    using unipaulistana.web.extensions;

    [Authorize]
    public class SolicitacaoController : Controller
    {
        public SolicitacaoController(ISolicitacaoService solicitacaoService,
                                    IClienteService clienteService,
                                    IUsuarioService usuarioService,
                                    IDepartamentoService departamentoService,
                                    IHostingEnvironment hostingEnvironment)
        {
            this.solicitacaoService = solicitacaoService;
            this.clienteService = clienteService;
            this.usuarioService = usuarioService;
            this.hostingEnvironment = hostingEnvironment;
            this.departamentoService = departamentoService;
        }

        readonly ISolicitacaoService solicitacaoService;
        readonly IClienteService clienteService;
        readonly IUsuarioService usuarioService;
        readonly IDepartamentoService departamentoService;
        readonly IHostingEnvironment hostingEnvironment;

        [Authorize(Policy="PermiteListarSolicitacao")]
        public IActionResult Index()
        {
            if (TempData["mensagemIndex"] != null)
            {
                ViewBag.Sucesso = TempData["mensagemIndex"];
            }

            return View(this.solicitacaoService.ObterTodos());
        }

        [Authorize(Policy="PermiteCriarSolicitacao")]
        public IActionResult Criar()
        {
            AtualizarListas();
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Solicitacao dados)
        {
            try
            {
                this.solicitacaoService.Adicionar(dados, User.GetUserID());
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", string.Format("Ocorreu um erro ao tentar atualizar o usuário:{0}", ex.Message));
                AtualizarListas();
                return View(dados);
            }
        }
       
        [Authorize(Policy="PermiteAlterarSolicitacao")]
        public IActionResult Alterar(int id)
        {
            if (TempData["mensagemEdicao"] != null)
            {
                ViewBag.Sucesso = TempData["mensagemEdicao"];
            }

            AtualizarListas();
            return View(this.solicitacaoService.ObterPorID(id));
        }

        [HttpPost]
        public IActionResult Alterar(Usuario dados)
        {
            try
            {
                this.usuarioService.Atualizar(dados);
                TempData["mensagemEdicao"] = "Usuário atualizado com sucesso.";
                return RedirectToAction("Alterar", dados.UsuarioID);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", string.Format("Ocorreu um erro ao tentar atualizar o usuário:{0}", ex.Message));
                AtualizarListas();
                return View(dados);
            }
        }

        void AtualizarListas()
        {
            ViewBag.ListarDepartamentos = this.departamentoService.ObterTodos();
            ViewBag.ListarCliente = this.clienteService.ObterTodos();
            ViewBag.ListarUsuarios = this.usuarioService.ObterTodos();
        }

        [Authorize(Policy="PermiteConcluirSolicitacao")]
        public IActionResult ConcluirSolicitacao(int id)
        {
            return View();
        }
    }
}
