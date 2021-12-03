using System;
public class Desarrollador : IPersona {

    public string Nombre { get; set; }

    public Desarrollador (string nombre) {
        this.Nombre = nombre;
    }

    public void Notify(string s) 
    {
        if (s == "Tarea aprobada") {
            Console.WriteLine($"El desarrollador {this.Nombre} fue notificado de la tarea aprobada");
        }
    }

    public void realizarTarea(int id) {
        Sistema.GetInstance().realizarTarea(id);
    }
}