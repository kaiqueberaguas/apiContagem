using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiContagem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContadorController : Controller
    {
        private static int contador = 0;
        
        [HttpGet]
        public int Get()
        {
            if (contador > 10)
            {
                contador = 0;
                throw new Exception("Contador maior que 10");
            }
            return contador++;
        }

    }
}
