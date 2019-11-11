using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class Curso
    {
        public Instructor instructor { get; set; }
        public Materia materia { get; set; }
        public List<Alumno> alumnos { get; set; }
        public List<Clase> clases { get; set; }

        public Curso (Instructor instructor,Materia materia, List<Alumno> alumnos,List<Clase> clases)
        {
            this.instructor = instructor;
            this.materia = materia;
            this.alumnos = alumnos;
            this.clases = clases;
        }
    }
}
