using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Jogo.Models;

namespace Jogo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Usuario usuario)
        {
            if (!(string.IsNullOrEmpty(usuario.Nome) && string.IsNullOrEmpty(usuario.Email)))
            {
                return View("HomeGame", usuario);
            }
            return View();
        }

        public ActionResult HomeGame()
        {
            return View();
        }

        public ActionResult Game()
        {
            return View();
        }
	}
}