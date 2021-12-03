using System;
using System.Collections.Generic;
public class Usuario : IUsuario {

    public string Nombre {get; set; }
    public int Contador {get; set; }
    public List<Objeto> Inventario {get; set; }

    public Usuario (string nombre, int contador, List<Objeto> inventario) {
        this.Nombre = nombre;
        this.Contador = contador;
        this.Inventario = inventario;
    }

    public override string ToString()
    {
        return $"{this.Nombre}";
    }

    public string listarInventario() {
        int id = 0;
        string s = "";
        foreach (var objeto in Inventario) {
            s += $"\n\t{id++}) {objeto}";
        }
        return s;
    }


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
            Console.WriteLine($"En esta lista menos de {id} elementos"); //🐀🐀
        }
    }
}