using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_REST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            RPAlumno rpCli = new RPAlumno();
            return Ok(rpCli.ObtenerClientes());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            RPClientes rpCli = new RPClientes();

            var cliRet = rpCli.ObtenerCliente(id);

            if (cliRet == null)
            {
                var nf = NotFound("El cliente " + id.ToString() + " no existe.");
                return nf;
            }

            return Ok(cliRet);
        }
    }
}
