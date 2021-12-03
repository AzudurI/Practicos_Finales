using System;
using System.Collections.Generic;
public class Docente : Persona {

    public int IDdocente {get; set;}
    public Docente (string nombre, string apellido, int documento, int idDocente) : base (nombre, apellido, documento) {
        this.IDdocente = idDocente;
    }
    
    public override void Presentarse()
    {
        Console.WriteLine($"Hola soy el profesor {this.Nombre} {this.Apellido}");
    }

    public void agregarTarea(List<Tarea> listaTareas) {
        Console.WriteLine("Introduzca el id de la tarea");
        int id = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Introduzca el nombre de la tarea");
        string nom = Console.ReadLine();
        Console.WriteLine("Introduzca el contenido de la tarea");
        string con = Console.ReadLine();
        Console.WriteLine("Introduzca la respuesta de la tarea");
        string res = Console.ReadLine();

        Tarea tarea = new Tarea (id,nom,con,res);
        listaTareas.Add(tarea);
    }

    public void listarTareasRealizadas(List<Alumno> listaAlumnos) {
        foreach (var alumno in listaAlumnos) {
            Console.WriteLine(alumno.verTareasRealizadas());
        }
    }
}