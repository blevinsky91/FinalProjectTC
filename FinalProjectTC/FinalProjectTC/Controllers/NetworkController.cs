using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProjectTC.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FinalProjectTC.Controllers
{
    public class NetworkController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {

            var networksResponse = CityBikeAPI.CallBikeAPI();
            return View(networksResponse);

        }
    }
}

