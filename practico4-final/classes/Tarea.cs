public class Tarea {
    public string Nombre {get; set; }
    public int Puntaje {get; set; }
    public bool Estado {get; set; }

    public Tarea (string nombre, int puntaje, bool estado) {
        this.Nombre = nombre;
        this.Puntaje = puntaje;
        this.Estado = estado;
    }

    public override string ToString()
    {
        return $"\n\tNombre de Tarea: {this.Nombre}\n\tValor: {this.Puntaje}\n\tEstado: {this.Estado}";
    }
}