public class Canción {
    private string nombre;

    public string Nombre {
        get { return nombre; }
        set { nombre = value; }
    }

    public Canción (string Nombre) {
        this.nombre = Nombre;
    }

    public override string ToString()
    {
        return ($"{this.nombre}");
    }

    
}