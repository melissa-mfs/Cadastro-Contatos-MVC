using Contatos_MVC.Data.Repositorio;
using Contatos_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Contatos_MVC.Controllers
{
    public class ContatoController : Controller
    {
        //Extrai variavel contatoRepositorio
        private readonly IContatoRepositorio _contatoRepositorio;

        //injeta para dentro de ContatoController
        public ContatoController(IContatoRepositorio contatoRepositorio)
        {
            _contatoRepositorio = contatoRepositorio;
        }

        //Métodos Get
        public IActionResult Index()
        {
            List<ContatoModel> contatos = _contatoRepositorio.BuscarTodos();

            return View(contatos);
        }

        public IActionResult Adicionar()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult DeletarConfirmacao()
        {
            return View();
        }

        //Métodos Post
        [HttpPost]
        public IActionResult Adicionar(ContatoModel contato)
        {
            _contatoRepositorio.Adicionar(contato);

            return RedirectToAction("Index");
        }
    }
}
