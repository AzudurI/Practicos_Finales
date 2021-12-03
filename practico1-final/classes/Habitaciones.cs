public class Habitaciones {
    public string nombre { get; set; }
    public int numero { get; set; }

    public Habitaciones(string Nombre, int Numero) {
        this.nombre = Nombre;
        this.numero = Numero;
    }

    public override string ToString() {
        return ($"{this.nombre},{this.numero}");
    }
}