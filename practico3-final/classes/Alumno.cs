using System;
using System.Collections.Generic;
public class Alumno : Persona {

    public int IDalumno {get; set;}
    public List<Tarea> ListaTareasRealizadas {get; set; }

    public Alumno (string nombre, string apellido, int documento, int idAlumno, List<Tarea> listaTareasRealizadas) :base (nombre, apellido, documento) {
        this.IDalumno = idAlumno;
        this.ListaTareasRealizadas = listaTareasRealizadas;
    }

    public override void Presentarse()
    {
        Console.WriteLine($"Hola soy el alumno {this.Nombre} {this.Apellido}");
    }

    public void copiarTarea(Tarea tarea) {
        
        Console.WriteLine("Introduzca la respuesta de la tarea");
        string res = Console.ReadLine();
        tarea.Respuestas = res;
        ListaTareasRealizadas.Add(tarea);

    }

    public string verTareasRealizadas() {
        string s = "";
        foreach (var t in ListaTareasRealizadas) {
            s += $"{t}";
        }
        return s;
    }
}