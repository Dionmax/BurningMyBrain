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
       
        public string Index()
        {
            return "This is my default action...";
        }

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }

        public string Comecando(string nome, int numerosCalculos = 1)
        {
            return HtmlEncoder.Default.Encode($"Ola {nome}, Numero Calculos: {numerosCalculos}");
        }
    }
}
