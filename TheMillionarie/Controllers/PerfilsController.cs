using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheMillionarie.Models;

namespace TheMillionarie.Controllers
{
    public class PerfilsController : Controller
    {
        public IActionResult Index()
        {
            List<Perfil> list = new List<Perfil>();
            list.Add(new Perfil { IdPerfil = 0, Nome = "Root" });
            list.Add(new Perfil { IdPerfil = 1, Nome = "Comum" });
            return View(list);
        }
    }
}
