public class Persona {

    public string Nombre {get; set; }
    public string Apellido {get; set; }

    public int Documento {get; set; }

    public virtual void Presentarse() {}

    public Persona (string nombre, string apellido, int documento) {
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.Documento = documento;
    }

    public override string ToString()
    {
        return ($"\n\tNombre: {this.Nombre} {this.Apellido}\n\tDocumento: {this.Documento}");
    }
}