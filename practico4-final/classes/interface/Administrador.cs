using System.Collections.Generic;
using System;
public class Administrador : IUsuario {

    public string Nombre {get; set; }
    public int Contador {get; set; }
    public List<Objeto> Inventario {get; set; }

    public List<Usuario> listaUsuarios {get; set; }

    public Administrador (string nombre, int contador, List<Objeto> inventario) {
        this.Nombre = nombre;
        this.Contador = contador;
        this.Inventario = inventario;
    }

    //////////////////////////////////////////////////////////
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
    ////////////////////////////////////////////////////

    public void eliminarObjeto(int idUsuario, int idObjeto) {
        listaUsuarios[idUsuario].Inventario.RemoveAt(idObjeto);
    }

    public void ingresarUsuario() {
        List<Objeto> inventario = new List<Objeto>();
        Console.WriteLine("Ingrese el nombre del usuario:");
        string nom = Console.ReadLine();
        Console.WriteLine("Ingrese el rol del usuario\n1)usuario\n2)administrador\n3)coordinador:");
        string num = Console.ReadLine();
        switch(num) {
            case "1":
                Usuario usuario = new Usuario(nom,0,inventario);
                break;
            case "2":
                Administrador administrador = new Administrador(nom,0,inventario);
                break;
            case "3":
                Coordinador coordinador = new Coordinador(nom,0,inventario);
                break;
        }
    }

    public void listarsaldo(List<Usuario> listaUsuarios) {
        foreach (var usuario in listaUsuarios) {
            Console.WriteLine($"{usuario} : {usuario.Contador}");
        }
    }
    public void listarInventarioUsuarios(List<Usuario> listaUsuarios) {
        foreach (var usuario in listaUsuarios) {
            Console.WriteLine($"{usuario} : {usuario.listarInventario()}");
        }
    }

    
}