using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace backend_tareas.Controllers
{
    public class DefaultController : Controller
    {
        [HttpGet]
        public string Get()
        {
            return "Aplicacion corriendo..";
        }
       
    }
}
