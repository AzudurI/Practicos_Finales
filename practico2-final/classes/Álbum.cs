using System;
using System.Collections.Generic;
public class Álbum {
    private string nombre;
    private List<Canción> listaCanciones;

    public void borrarCancion(int id) {
        try {
            listaCanciones.RemoveAt(id);
        } catch {
            Console.WriteLine("no rompas mi programa squeak🐀");
        }
    }
    public string Nombre {
        get { return nombre; }
        set { nombre = value; }
    }

    public string getListaCanciones() {
        int id = 0;
        string s = "";
        foreach (Canción cancion in listaCanciones) {
            s += $"\n\t\t\t{id++} {cancion.ToString()}";
        }
        return s;
    }

    


    public Álbum (string Nombre, List<Canción> listaCAnciones) {
        this.nombre = Nombre;
        this.listaCanciones = listaCAnciones;
    }

    public override string ToString()
    {
        return ($"Nombre:{this.nombre}");
    }
}