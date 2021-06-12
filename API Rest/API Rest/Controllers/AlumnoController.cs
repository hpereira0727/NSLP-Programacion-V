using API_REST.Modelos;
using API_REST.Repositorios;
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
            RPAlumno rpAlum = new RPAlumno();
            return Ok(rpAlum.ObtenerAlumnos());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            RPAlumno rpAlum = new RPAlumno();

            var AlumRet = rpAlum.ObtenerAlumno(id);

            if (AlumRet == null)
            {
                var nf = NotFound("El alumno " + id.ToString() + " no existe.");
                return nf;
            }

            return Ok(AlumRet);
        }
        [HttpPost("agregar")]
        public IActionResult AgregarAlumno(Alumno nuevoAlumno)
        {
            RPAlumno rpAlum = new RPAlumno();
            rpAlum.Agregar(nuevoAlumno);
            return CreatedAtAction(nameof(AgregarAlumno), nuevoAlumno);
        }
    }
}
