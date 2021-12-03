using System;
public class Administrador : IPersona {

    public string Nombre {get; set; }

    public Administrador (string nombre) {
        this.Nombre = nombre;
    }

    public void Notify(string s) 
    {
        if (s == "Nueva tarea") {
            Console.WriteLine($"El administrador {this.Nombre} fue notificado de la nueva tarea");
        }
        else if (s == "Tarea finalizada") {
            Console.WriteLine($"El administrador {this.Nombre} fue notificado de la tarea finalizada");
        }
    }

    public void aprobarTarea(bool Aprobado, int id) {
        Sistema.GetInstance().aprobarTarea(Aprobado, id);
    }
}