using System;
using System.Collections.Generic;
public class Cliente : IPersona {

    public string Nombre { get; set; }

    public Cliente (string nombre) {
        this.Nombre = nombre;
    }

    public void crearTarea() {
        Console.WriteLine("Ingrese la tarea:");
        string nom = Console.ReadLine();
        bool aproved = false; //NO APROBADA
        bool finish = false;
        Tarea tarea = new Tarea(nom,aproved,finish);
        Sistema.GetInstance().agregarTarea(tarea);
    }

    public void Notify(string s) 
    {
        if (s == "Tarea finalizada") {
            Console.WriteLine($"El cliente {this.Nombre} fue notificado de la tarea finalizada");
        }
    }
}