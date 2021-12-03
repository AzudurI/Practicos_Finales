public class Persona {
    private string nombre;
    private string apellido;
    private bool estado;

    public string Nombre {
        get { return nombre; }
        set { nombre = value; }
    }

    public string Apellido {
        get { return apellido; }
        set { apellido = value; }
    }
     
    public bool Estado {
        get { return estado; }
        set { estado = value; }
    }

    

    public Persona (string Nombre, string Apellido, bool Estado) {
        this.nombre = Nombre;
        this.apellido = Apellido;
        this.estado = Estado;
    }

    public override string ToString()
    { 
        return ($"{this.nombre} {this.apellido}");
    }
}