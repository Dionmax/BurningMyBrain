using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace CalculoNumerico.Controllers
{
    public class Calculos : Controller
    {

        public IActionResult Index()
            => View();

        public IActionResult EliminacaoGauss()
            => View();

        public IActionResult Comeco(string name, int numTimes)
        {
            ViewData["Message"] = "Olá " + name;
            ViewData["numTimes"] = numTimes;

            return View();
        }
    }
}
