using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTestSQL.Models;
using WebTestSQL.ViewModels;
using WebTestSQL.Utils;
using System.Security.Claims;

namespace WebTestSQL.Controllers
{
    public class AutenticacaoController : Controller
    {
        private UsuariosContext db = new UsuariosContext();
        // GET: Autenticacao
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(CadastroUsuarioViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }
            if (db.Usuarios.Count(u => u.login == viewModel.login) > 0)
            {
                ModelState.AddModelError("Login", "Este Login já está em uso");
                return View(viewModel);
            }
            Usuarios novoUsuario = new Usuarios { nome = viewModel.nome, login = viewModel.login, senha = Hash.GerarHash(viewModel.senha) };

            db.Usuarios.Add(novoUsuario);
            db.SaveChanges();
            TempData["Mensagem"] = "Cadastro realizado com sucesso";
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Login(string ReturnUrl)
        {
            var viewModel = new LoginViewModel { UrlRetorno = ReturnUrl };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }
            var usuario = db.Usuarios.FirstOrDefault(u => u.login == viewModel.login);

            if (usuario == null)
            {
                ModelState.AddModelError("Login", "Este Login já está em uso");
                return View(viewModel);
            }
            if (usuario.senha != Hash.GerarHash(viewModel.senha))
            {
                ModelState.AddModelError("Senha", "Este Login já está em uso");
                return View(viewModel);
            }

            var identity = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, usuario.nome), new Claim("Login", usuario.login) }, "ApplicationCookie");

            Request.GetOwinContext().Authentication.SignIn(identity);
            if((!String.IsNullOrWhiteSpace(viewModel.UrlRetorno)) || (Url.IsLocalUrl(viewModel.UrlRetorno)))
            { return Redirect(viewModel.UrlRetorno); }
            else { return RedirectToAction("Index", "Painel"); }
        }

        public ActionResult Logout()
        {
            Request.GetOwinContext().Authentication.SignOut("ApplicationCookie");
            return RedirectToAction("Index", "Home");
        }
    }
}