using System;
using System.Collections.Generic;

namespace practico4_final
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////////////////////////////////////////🐀🐀

            Objeto objeto1 = new Objeto("Coca Cola",20);
            Objeto objeto2 = new Objeto("Carinatoy",15);

            List<Objeto> listaObjetos = new List<Objeto> {objeto1, objeto2};

            Tarea tarea1 = new Tarea("Pet the Carina",100,true);
            Tarea tarea2 = new Tarea("Feed the Carina",120,true);
            Tarea tarea3 = new Tarea("Play with the Carina",150,true);

            List<Objeto> inventario1 = new List<Objeto> {objeto1,objeto2};
            List<Objeto> inventario2 = new List<Objeto> {objeto1,objeto2};
            List<Objeto> inventario3 = new List<Objeto> {objeto1,objeto2};
            List<Tarea> listadeTarea1 = new List<Tarea> {tarea1,tarea2,tarea3};

            Tienda tienda1 = new Tienda(listadeTarea1);
            Usuario usuario1 = new Usuario ("Shrek",40,inventario1);
            Coordinador coordinador1 = new Coordinador("Darth Vader",150,inventario2);
            Administrador administrador1 = new Administrador("Carina",30,inventario3);

            List<Usuario> listadeUsuarios1 = new List<Usuario> {usuario1};
            List<Coordinador> listadeCoord1 = new List<Coordinador> {coordinador1};
            List<Administrador> listadeAdmin1 = new List<Administrador> {administrador1};

            ////////////////////////////////////////////////////////////////////////////

            usuario1.realizarTarea(ref listadeTarea1,0);
            //Console.WriteLine(listadeTarea1[0].Estado);
            tienda1.contadorGlobal(listadeUsuarios1);
            usuario1.canjearPuntos(objeto1);
            //Console.WriteLine(usuario1.Contador);
            Console.WriteLine(usuario1.listarInventario());
            usuario1.consumirObjetos(0);
            //Console.WriteLine(usuario1.listarInventario());
            tienda1.quitarTarea(0);
            Console.WriteLine(tienda1); //ver tarea
            //tienda1.agregarTarea();
            Console.WriteLine(tienda1);
            //coordinador.agregarObjetos(ref listaObjetos);

            /*int id = 0;
            foreach (var objeto in listaObjetos) {
                Console.WriteLine($"{id++} {objeto}");
            }*/

            administrador1.ingresarUsuario();
            administrador1.listarsaldo(listadeUsuarios1); //🐀
        }
    }
}
