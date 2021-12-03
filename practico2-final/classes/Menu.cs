using System;
using System.Collections.Generic;
public class Menu {

    List<Banda> listaB1;
    List<Álbum> listaA1;
    public Menu () {
        Persona persona1 = new Persona ("Bob","Esponja",true);
        Persona persona2 = new Persona ("Patricio","Estrella",true);
        Canción cancion1 = new Canción ("Al vacío");
        Canción cancion2 = new Canción ("El viejo");

        List<Canción> listaC1 = new List<Canción> {cancion1,cancion2};
        List<Persona> listaP1 = new List<Persona> {persona1,persona2}; 

        Álbum album1 = new Álbum ("Mejores hits",listaC1);
        listaA1 = new List<Álbum> {album1};

        Banda banda1 = new Banda("No te va a gustar","Rock",listaP1,listaA1);
        listaB1 = new List<Banda> {banda1, banda1, banda1};
    }

    ConsoleKey key;
    int id = 0;
    int idAlbum = 0;

    public void verMenu() {

    
    while (true) {
        Console.WriteLine($"\n1) Agregar banda\n2) Listar bandas\n3) Listas canciones\n4) Eliminar banda\n5) Eliminar canción\n6) Eliminar álbum\n7) Cambiar estado de integrante\n8) Salir🐀🐀🐀");
        string num = Console.ReadLine();
        switch (num) {
            case "1":
                agregarBanda();
                break;
            case "2":
                getListaBanda();
                break;
            case "3":
                getListaBanda();
                Console.WriteLine("Elija número de banda para ver su lista de canciones");
                id = Int32.Parse(Console.ReadLine());

                foreach(Álbum c in listaB1[id].GetÁlbum()) {
                    Console.WriteLine(c.getListaCanciones());
                }
                break;

            case "4":
                getListaBanda();
                Console.WriteLine("Elija número de banda que desea eliminar");
                id = Int32.Parse(Console.ReadLine());
                listaB1.Remove(listaB1[id]); 
                break;

            case "5":
                getListaBanda();
                Console.WriteLine("Elija número de banda para ver su lista de canciones");
                id = Int32.Parse(Console.ReadLine());
                int numAlbum = 0;
                foreach(var c in listaB1[id].GetÁlbum()) {
                    Console.WriteLine($"Album N°{numAlbum++}");
                    Console.WriteLine(c.getListaCanciones());
                }
                Console.WriteLine("Elija el número de álbum");
                idAlbum = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Elija el número de la canción que desea eliminar");
                int idCancion = Int32.Parse(Console.ReadLine());
                listaB1[id].borrarCancion(idAlbum,idCancion);
                break;
                
            case "6":
                getListaBanda();
                Console.WriteLine("Elija número de banda para ver su lista de álbumes");
                id = Int32.Parse(Console.ReadLine());
                foreach(var c in listaB1[id].GetÁlbum()) { 
                    Console.WriteLine(c.getListaCanciones());
                }
                Console.WriteLine("Elija el número de álbum que desea eliminar");
                idAlbum = Int32.Parse(Console.ReadLine());
                listaB1[id].borrarÁlbum(idAlbum);
                break;
            case "7":
                getListaBanda();
                Console.WriteLine("Elija número de banda para ver su lista de integrantes");
                id = Int32.Parse(Console.ReadLine());
                Console.WriteLine(listaB1[id].getListaIntegrantes());

                Console.WriteLine("Elija número de integrante para cambiar su estado");
                int idInt = Int32.Parse(Console.ReadLine());
                listaB1[id].cambiarEstadoIntegrante(idInt);
                break;
                }
            if (num == "8") break;
            }
        
        }
    public void getListaBanda() {
        id = 0;
        foreach(var b in listaB1) {
            Console.WriteLine($"id: {id++}\n{b.ToString()}");
        }
    }
    List<Persona> listaI;
    public void hacerIntegrante() {
        
        Persona persona;

        while (true) {
            Console.WriteLine("Ingrese nombre del integrante");
            string nom = Console.ReadLine();
            Console.WriteLine("Ingrese apellido del integrante");
            string ape = Console.ReadLine();
            Console.WriteLine("Ingrese estado del integrante (true/false)");
            bool est = bool.Parse(Console.ReadLine());
            persona = new Persona (nom,ape,est);
            listaI = new List<Persona> {persona};
            
            key = leer("¿Ingresar otro integrante?\n\t1) Si\n\t2)No");
            if (key == ConsoleKey.D1) {
                continue;
            }
            else if (key == ConsoleKey.D2) {
                break;
            }
        }
    }

    List<Álbum> listaA;
    List<Canción> listaC;
    public void hacerÁlbum() {
        Canción cancion;
        Álbum album;

        Console.WriteLine("Ingrese nombre del álbum");
        string nom = Console.ReadLine();

        while(true) {
            Console.WriteLine("Ingrese el nombre de la canción");
            string nomC = Console.ReadLine();
            cancion = new Canción(nomC);
            listaC = new List<Canción> {cancion};

            key = leer("¿Ingresar otra canción?\n\t1) Si\n\t2)No");
            if (key == ConsoleKey.D1) {
                continue;
            }
            else if (key == ConsoleKey.D2) {
                break;
            }
        }
        album = new Álbum (nom, listaC);
        listaA = new List<Álbum> {album};
    }

    public void agregarBanda() {
        Banda banda;
        Console.WriteLine("Ingrese nombre:");
        string n = Console.ReadLine();
        Console.WriteLine("Ingrese genero de la banda:");
        string g = Console.ReadLine();
        hacerIntegrante();
        hacerÁlbum();

        banda = new Banda(n,g,listaI,listaA1);
        listaB1.Add(banda);
    }
    public ConsoleKey leer(string cosa) {
        Console.WriteLine(cosa);
        ConsoleKey key = Console.ReadKey(true).Key;
        return key;
    }
}
