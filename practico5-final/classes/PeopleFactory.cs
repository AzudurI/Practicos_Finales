public class PeopleFactory {

    //////////////////////////FACTORY
    public const int CLIENTE = 0;
    public const int ADMIN = 1;
    public const int DESARROLLADOR = 2;
    public static IPersona Creador(int tipo, string nombre)
    {
        switch (tipo)
        {
        case 0:
            return new Cliente(nombre);
        case 1:
            return new Administrador(nombre);
        case 2:
            return new Desarrollador(nombre);
        default:
            return null;
    }
  }
}