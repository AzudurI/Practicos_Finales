using System.Collections.Generic;
using System;
public class Objeto {
    public string Nombre {get; set; }

    public int Puntos {get; set; }

    public Objeto (string nombre, int puntos) {
        this.Nombre = nombre;
        this.Puntos = puntos;
    }

    public override string ToString()
    {
        return $"\n\tNombre: {this.Nombre}\n\t    Valor: {this.Puntos}";
    }
}