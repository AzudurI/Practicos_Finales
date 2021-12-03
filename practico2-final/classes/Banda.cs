using System;
using System.Collections.Generic;
public class Banda {
    private string nombre;
    private string genero;
    private List<Persona> listaIntegrantes;
    private List<Álbum> listaAlbumes;

    public List<Álbum> GetÁlbum() {
        return listaAlbumes;
    }


    public string Nombre {
        get { return nombre; }
        set { nombre = value; }
    }
    public string Genero {
        get { return genero; }
        set { genero = value; }
    }

    public List<Persona> Integrantes {
        get { return listaIntegrantes; }
        set { listaIntegrantes= value; }
    }

    public List<Álbum> Albumes {
        get { return listaAlbumes; }
        set { listaAlbumes = value; }
    }

    public void borrarÁlbum(int id) {
        try {
            listaAlbumes.RemoveAt(id);
        } catch {
            Console.WriteLine("no rompas mi programa squeak🐀");
        }
    }
    
    public void borrarCancion(int id, int idCancion) {
        try {
            listaAlbumes[id].borrarCancion(idCancion);
        } catch {
            Console.WriteLine("no rompas mi programa squeak🐀");
        }
    }

    public void cambiarEstadoIntegrante(int id) {
        try {
            listaIntegrantes[id].Estado =  !listaIntegrantes[id].Estado; //lo igualas al opuesto :D🐀🐀
        } catch {
            Console.WriteLine("no rompas mi programa squeak🐀");
        }
    }

    public Banda (string Nombre, string Genero, List<Persona> listaINtegrantes, List<Álbum> listaALbumes) {
        this.nombre = Nombre;
        this.genero = Genero;
        this.listaIntegrantes = listaINtegrantes;
        this.listaAlbumes = listaALbumes;
    }

    public string getListaIntegrantes() {
        string s = "";
        int id = 0;
        foreach (Persona integrante in listaIntegrantes) {
            s = $"\n\t {id++} - {integrante.Nombre} {integrante.Apellido}\n\tEstado: {integrante.Estado}";
        }
        return s;
    }

    public string getListaAlbumes() {
        string s = "";
        foreach (var album in listaAlbumes) {
            s = $"\n\t{album.Nombre}\n\t\tCanciones:{album.getListaCanciones()}";
        }
        return s;
    }

    public override string ToString()
    {  
        return ($" Nombre: {this.nombre}\nGenero: {this.genero}\nIntegrantes: {this.getListaIntegrantes()}\nAlbumes: {this.getListaAlbumes()}");
        
    }
    

    

}