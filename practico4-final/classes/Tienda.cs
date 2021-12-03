using System.Collections.Generic;
using System;
public class Tienda {

    public List<Tarea> ListadeTareas {get; set; }

    public override string ToString()
    {
        string s = "";
        foreach (var tarea in ListadeTareas) {
            s += $"{tarea}";
        }
        return s;
    }

    public Tienda (List<Tarea> listaDeTareas) {
        this.ListadeTareas = listaDeTareas;
    }

    public void contadorGlobal(List<Usuario> listaUsuarios) {
        foreach (var usuario in listaUsuarios) {
            Console.WriteLine($"{usuario} : {usuario.Contador} puntos");
        }
    }

    public void quitarTarea(int id) {
        ListadeTareas.RemoveAt(id);
    }

    public void agregarTarea() {
        Console.WriteLine("Ingrese el nombre de la tarea:");
        string nom = Console.ReadLine();
        Console.WriteLine("Ingrese el puntaje que da la tarea:");
        int punto = Int32.Parse(Console.ReadLine());
        Tarea tarea = new Tarea (nom,punto,true);
        ListadeTareas.Add(tarea);
    }
}