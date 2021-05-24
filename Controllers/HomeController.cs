using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TallerEje3MVC.Data;
using TallerEje3MVC.Models;

namespace TallerEje3MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TallerEje3MVCContext _db;

        public HomeController(ILogger<HomeController> logger, TallerEje3MVCContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            //obtengo los candidatos y los retorno a la vista
            var candidatos = _db.Candidatos.ToList();

             return View(candidatos);
        }

        [HttpPost]
        public IActionResult Votar(int id_candidato, string identificacion)
        {
            try
            {
                //agrego cambios al contexto
                var insertar_voto = _db.Votos.Add(new VotosModel { id_candidato = id_candidato, cedula = identificacion });
                //hago commit a la db para insertar los datos
                _db.SaveChanges();
                ViewBag.VotoAlmacenado = true;

                return View();
                
            }
            catch (Exception)
            {
                 ViewBag.VotoAlmacenado = false;
            }
           
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
