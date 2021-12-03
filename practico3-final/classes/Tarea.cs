public class Tarea {
    
    public int IDTarea {get; set; }
    public string Nombre {get; set; }
    public string Contenido {get; set; }
    public string Respuestas {get; set; }

    public Tarea (int idTarea, string nombre, string contenido, string respuestas) {
        this.IDTarea = idTarea;
        this.Nombre = nombre;
        this.Contenido = contenido;
        this.Respuestas = respuestas;
    }

    public override string ToString()
    {
        return ($"\n\tId de tarea: {this.IDTarea}\n\tNombre: {this.Nombre}\n\tContenido: {this.Contenido}\n\tRespuesta: {this.Respuestas}");    }
}