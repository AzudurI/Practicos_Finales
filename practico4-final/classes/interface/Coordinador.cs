using System.Collections.Generic;
using System;
public class Coordinador : IUsuario {

    public string Nombre {get; set; }
    public int Contador {get; set; }
    public List<Objeto> Inventario {get; set; }

    public Coordinador (string nombre, int contador, List<Objeto> inventario) {
        this.Nombre = nombre;
        this.Contador = contador;
        this.Inventario = inventario;
    }

    ////////////////////////////////////////////////////////////
    public void realizarTarea(ref List<Tarea> listaTarea, int id) {
        if (listaTarea.Count>id && listaTarea[id].Estado) {
                Contador += listaTarea[id].Puntaje;
                listaTarea[id].Estado = !listaTarea[id].Estado;
            }
        else {
            Console.WriteLine("La tarea debe estar dentro de la lista de tareas y debe estar activa");
        } 
    }
    public void canjearPuntos(Objeto objeto) {
        if (Contador >= objeto.Puntos) {
                Contador -= objeto.Puntos;
                Inventario.Add(objeto);
        }
        else {
            Console.WriteLine("No tiene suficientes puntos para este objeto");
        }
    }
    public void consumirObjetos(int id) {
        try {
            Inventario.RemoveAt(id);
        } catch {
            Console.WriteLine($"En esta lista existen menos de {id} elementos"); //🐀🐀
        }
    }
    //////////////////////////////////////////////////////////////

    public void agregarObjetos(ref List<Objeto> listaObjetos) {
        Console.WriteLine("Ingrese el nombre del objeto:");
        string nom = Console.ReadLine();
        Console.WriteLine("Ingrese los puntos que cuesta el objeto:");
        int punto = Int32.Parse(Console.ReadLine());
        Objeto objeto = new Objeto(nom, punto);
        listaObjetos.Add(objeto);
        Console.WriteLine($"Objeto añadido por {this.Nombre}");
    }
 
}