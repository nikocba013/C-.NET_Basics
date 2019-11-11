using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Objetos;

namespace Proyecto_Escuela
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Relaciones Entre Objetos" + Environment.NewLine);

            Alumno alumno1 = new Alumno("Marta", "Lopez", true);
            Alumno alumno2 = new Alumno("Carlos", "Perez", false);
            Alumno alumno3 = new Alumno("Miriam", "Garis", true);
            Alumno alumno4 = new Alumno("Claudio", "Soria", false);
            Alumno alumno5 = new Alumno("Ariel", "Franco", true);
            Alumno alumno6 = new Alumno("Martin", "Larra", true);

            List<Alumno> alumnos = new List<Alumno>();
            alumnos.Add(alumno1);
            alumnos.Add(alumno2);
            alumnos.Add(alumno3);
            alumnos.Add(alumno4);
            alumnos.Add(alumno5);
            alumnos.Add(alumno6);

            Materia materia1 = new Materia("ASP.NET", "...");
            Materia materia2 = new Materia("C#.NET", "...");
            Materia materia3 = new Materia("PHP", "...");

            List<Materia> materias = new List<Materia>();
            materias.Add(materia1);
            materias.Add(materia2);
            materias.Add(materia3);

            Instructor instructor = new Instructor("Pedro", "Peralta", materias);

            Aula aula1 = new Aula(15, "A1B2");

            Clase clase1 = new Clase(Convert.ToDateTime("23/01/2019 10:00"), Convert.ToDateTime("23/01/2019 13:00"), aula1);
            Clase clase2 = new Clase(Convert.ToDateTime("26/01/2019 10:00"), Convert.ToDateTime("26/01/2019 13:00"), aula1);
            Clase clase3 = new Clase(Convert.ToDateTime("29/01/2019 10:00"), Convert.ToDateTime("29/01/2019 13:00"), aula1);
            Clase clase4 = new Clase(Convert.ToDateTime("04/02/2019 10:00"), Convert.ToDateTime("04/02/2019 13:00"), aula1);

            List<Clase> clases = new List<Clase>();
            clases.Add(clase1);
            clases.Add(clase2);
            clases.Add(clase3);
            clases.Add(clase4);

            Curso curso1 = new Curso(instructor, materia1, alumnos, clases);

            Console.WriteLine("Validacion de datos: ");
            Console.WriteLine("Curso: {0}",curso1.materia.nombre);
            Console.WriteLine("Programa: {0}", curso1.materia.programa);
            Console.WriteLine("Instructor: {0} {1}" , curso1.instructor.nombre, curso1.instructor.apellido);
            Console.WriteLine("Fecha de inicio: {0}", curso1.clases.First().inicio_clase);
            Console.WriteLine("Fecha de fin: {0}", curso1.clases.Last().fin_clase);
            Console.WriteLine("Clases: {0}", curso1.clases.Count);
            Console.WriteLine("Alumnos inscriptos {0}", curso1.alumnos.Count);
            Console.WriteLine("Lista de alumnos: ");

            foreach(Alumno a in curso1.alumnos)
            {
                Console.WriteLine("{0} {1}, aprobado : {2}",a.nombre , a.apellido,a.aprobado);
            }
                Console.WriteLine("Cronograma");
            foreach(Clase c in curso1.clases)
            {
                Console.WriteLine("{0}, {1}. Aula ? {2}, (Capacidad {3} personas)", c.inicio_clase, c.fin_clase, c.aula.codigo,c.aula.capacidad);
            }
            Console.WriteLine("{0}, {1} dicta: ",curso1.instructor.nombre, curso1.instructor.apellido);

            foreach(Materia m in curso1.instructor.materias)
            {
                Console.WriteLine(m.nombre);
            }
            Console.WriteLine("");
            Console.WriteLine("Pulse una tecla para cerrar.");
            Console.ReadKey();
        }
    }
}
