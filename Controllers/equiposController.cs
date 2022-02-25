using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace equiposApi.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class equiposController : ControllerBase
    {
        private readonly equipoContext contexto;
        public equiposController(equipoContext mi)
        {
            contexto = mi;
        }

        
        [HttpGet]
        [Route("api/equipos")]
        public IActionResult Get()
        {
            IEnumerable<models.equipos> equipolista = (from e in contexto.equipos select e);
            return Ok(equipolista);
        }
    }
    


}