using System;
using System.Collections.Generic;

namespace practico3_final
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Tarea tarea1 = new Tarea(433,"Un titulo","Un contenido","Una respuesta");
            Tarea tarea2 = new Tarea(433,"Un titulo","Un contenido","Una respuesta mal");

            List<Tarea> listaTarea1 = new List<Tarea> {tarea1,tarea1,tarea1};
            List<Tarea> listaTareaR1 = new List<Tarea> {tarea2};

            WebAsignatura webasignatura1 = new WebAsignatura(listaTarea1);

            Persona persona1 = new Persona ("Bob","Esponja",58392815);
            Alumno persona2 = new Alumno ("Patricio","Estrella",58392815,6578,listaTareaR1);
            Docente persona3 = new Docente ("Calamardo","Tentáculos",58392815,8698);

            List<Alumno> listaAlumnos1 = new List<Alumno> {persona2, persona2, persona2};
            Curso curso1 = new Curso(persona3,webasignatura1,listaAlumnos1); 

        //////////////////////////////////////////////////////

            //persona3.agregarTarea(listaTarea1);
            //persona2.copiarTarea(tarea1);
            persona3.listarTareasRealizadas(listaAlumnos1);
            Console.WriteLine(curso1.listarPersonas());
            //Console.WriteLine(persona1);

        }
    }
}
