using API_REST.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_REST.Repositorios
{
    public class RPAlumno
    {
        public static List<Alumno> _listaAlumnos = new List<Alumno>()
        {
            new Alumno() { Id = 1, Nombre = "Alumno 1" , Apellido = "Apellido 1" },

        };

        public IEnumerable<Alumno> ObtenerAlumnos()
        {
            return _listaAlumnos;
        }

        public Alumno ObtenerAlumno(int id)
        {
            var Alumno = _listaAlumnos.Where(cli => cli.DNI == dni);

            return Alumno.FirstOrDefault();
        }

        public void Agregar(Alumno nuevoAlumno)
        {
            _listaAlumnos.Add(nuevoAlumno);
        }
    }
}
