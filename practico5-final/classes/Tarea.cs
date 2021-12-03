public class Tarea {

    public string Nombre { get; set; }

    public bool Aprobado { get; set; }

    public bool Finalizada { get; set; }

    public Tarea(string nombre, bool aprobado, bool finalizada) {
        this.Nombre = nombre;
        this.Aprobado = aprobado;
        this.Finalizada = finalizada;
    }

}