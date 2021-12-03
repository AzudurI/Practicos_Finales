using System;
using System.Collections.Generic;
public class Propiedad {
    public string nombre;
    public string ubicacion;
    public string color;
    public int tamaño;
    public List<Habitaciones> listaHabitaciones;
    public bool patio;
    public bool disponible;

    //beautiful getters and setters
    public string Nombre {
        get { return nombre; }
        set { nombre = value; }
    }

    public string Ubicacion {
        get { return ubicacion; }
        set { ubicacion = value; }
    }

    public string Color {
        get { return color; }
        set { color = value; }
    }

    public int Tamaño {
        get { return tamaño; }
        set { tamaño = value; }
    }

    public bool Patio {
        get { return patio; }
        set { patio = value; }
    }

    public bool Disponible {
        get { return disponible; }
        set { disponible = value; }
    }

    public string getListaHabitaciones() {
        int id = 0;
        string result = "";
        foreach (Habitaciones habitacion in listaHabitaciones) {
            result+= id +" "+ habitacion.ToString()+"\n";
            id += 1;
        }
        return result;
    }
    
    public void CambiarNumHabs(int posicion, int num){
        listaHabitaciones[posicion].numero = num;
    }

    public Propiedad(string Nombre, string Ubicación,string Color, int Tamaño, List<Habitaciones> Habitaciones, bool Patio, bool Disponible) {
            this.nombre = Nombre;
            this.ubicacion = Ubicación;
            this.color = Color;
            this.tamaño = Tamaño;
            this.listaHabitaciones = Habitaciones;
            this.patio = Patio;
            this.disponible = Disponible; 
        }

    public override string ToString() {
        return ($"-----\n [{this.nombre}]\n Ubicación:{this.ubicacion}\n Color:{this.color}\n Tamaño:{this.tamaño}\n Habitaciones:\n{this.getListaHabitaciones()} Patio:{this.patio}\n Disponible:{this.disponible}");
    }
}