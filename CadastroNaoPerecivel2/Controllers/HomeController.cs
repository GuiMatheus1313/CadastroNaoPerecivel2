using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CadastroNaoPerecivel2.Models;
using System.Collections.ObjectModel;

namespace CadastroNaoPerecivel2.Controllers
{
    public class NaoPerecivelController : Controller
    {
        public ActionResult Index()
        {
            var naoperecivel = new Nao_Pericivel();
            return View(naoperecivel);
        }
        [HttpPost]

        public ActionResult Index(Nao_Pericivel naoperecivel)
        {
            if (ModelState.IsValid)
            {
                return View("Resultado", naoperecivel);
            }
            return View(naoperecivel);
        }

        public ActionResult Resultado(Nao_Pericivel naoperecivel)
        {
            return View(naoperecivel);
        }
    }
}