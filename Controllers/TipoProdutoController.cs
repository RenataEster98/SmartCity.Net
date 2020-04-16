using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FiapSmartCity.Controllers
{
    public class TipoProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}