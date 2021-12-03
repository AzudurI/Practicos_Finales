using System;
using System.Collections.Generic;
public class Menu {

    public Menu () {
        //datadatadatadatadatadata
        Habitaciones h1 = new Habitaciones("Dormitorios",2);
        Habitaciones h2 = new Habitaciones("Baño",1);

        Habitaciones h3 = new Habitaciones("Dormitorios",3);
        Habitaciones h4 = new Habitaciones("Baño",2);

        Habitaciones h5 = new Habitaciones("Dormitorios",1);
        Habitaciones h6 = new Habitaciones("Baño",1);

        Habitaciones h7 = new Habitaciones("Dormitorios",2);
        Habitaciones h8 = new Habitaciones("Baño",2);

        List <Habitaciones> lista1 = new List<Habitaciones>() {h1,h2}; //lista1.Add(h1); lista1.Add(h2);
        List <Habitaciones> lista2 = new List<Habitaciones>() {h3,h4};
        List <Habitaciones> lista3 = new List<Habitaciones>() {h5, h6};
        List <Habitaciones> lista4 = new List<Habitaciones>() {h7, h8};

        Propiedad casa1 = new Propiedad(nameof(casa1),"Rivera 1279","Rojo",402,lista1,false,true);
        Propiedad casa2 = new Propiedad(nameof(casa2),"Chile 1342","Blanco",320,lista2,true,true);
        Propiedad casa3 = new Propiedad(nameof(casa3),"Brasil 134","Amarillo",300,lista3,false,false);
        Propiedad casa4 = new Propiedad(nameof(casa4),"Argentina 2100","Blanco",420,lista4,true,false);

        listaPropiedades = new List<Propiedad>() {casa1,casa2,casa3,casa4};
    }
    List<Propiedad> listaPropiedades;

    public void verMenu() 
    {
        bool run = true;
        while (run) {
            Console.WriteLine($"\n¿Qué desea hacer?\n(1) = Ver lista\n(2) = Modificar propiedad\n(3) = Eliminar propiedad\n(4) = Salir");
            int num = Int32.Parse(Console.ReadLine());
        
            switch (num) {
                case 1:
                    verDisponible();
                    break;
                case 2:
                    modificarPropiedad();
                    break;
                case 3:
                    eliminarPropiedad(); //hago que no reciba para trabajar con la lista original (si recibe, son copias)
                    break;
                case 4:
                    run = false;
                    break;
            }
        }
        
    }
    ////////////
    ConsoleKey key; //para los console.readkey
    
    ////////////

    public static void verLista(List<Propiedad> listapropiedades) {
        int id = 0;
        foreach (Propiedad propiedades in listapropiedades) {
            Console.WriteLine($"{id} {propiedades.ToString()}");
            id += 1;
        }

    } 
     public void verDisponible() {

        Console.WriteLine("(1) = Ver propiedades disponibles\n(2) = Ver propiedades no disponibles");
        key = Console.ReadKey(true).Key;
        
        List<Propiedad> listaPropiedadFinales = new List<Propiedad>();
         
            if (key == ConsoleKey.D1) { //si apretas la tecla 1 del teclado
                foreach (Propiedad p in listaPropiedades) {
                    if (p.Disponible) { // == true
                        listaPropiedadFinales.Add(p);
                    }
                verLista(listaPropiedadFinales);
                }
            }
            else if (key == ConsoleKey.D2) { //si apretas la tecla 2 del teclado
                foreach (Propiedad p in listaPropiedades) {
                    if (!p.Disponible) { // == false
                        listaPropiedadFinales.Add(p);
                    }
                verLista(listaPropiedadFinales);
                } 
            }
        
            
    }

    public void modificarPropiedad() {
        
        bool run = true;
        verLista(listaPropiedades);
        
        while (run) {
            Console.WriteLine("\n¿Qué propiedad desea modificar?");
            int id = Int32.Parse(Console.ReadLine());
            listaPropiedades[id].ToString();

            Console.WriteLine("¿Esta es la propiedad que desea modificar?\n (1) = Si\n (2) = No");
            key = Console.ReadKey(true).Key;

            if (key == ConsoleKey.D1) {
                Console.WriteLine("¿Qué desea modificar?\n(1) Habilitar/deshabilitar disponibilidad\n(2) Ubicación\n(3) Color\n(4) Tamaño\n(5) Habitaciones\n(6) Disponibilidad de patio");
                int num = Int32.Parse(Console.ReadLine());

                switch (num) {
                    case 1:
                        if (listaPropiedades[id].Disponible) {
                            listaPropiedades[id].Disponible = false;
                        }
                        else if (!listaPropiedades[id].Disponible) {
                            listaPropiedades[id].Disponible = true;
                        }
                        break;

                    case 2:
                        Console.WriteLine("Ingrese la nueva ubicación:");
                        listaPropiedades[id].Ubicacion = (Console.ReadLine());
                        break;

                    case 3:
                        Console.WriteLine("Ingrese el nuevo color:");
                        listaPropiedades[id].Color = (Console.ReadLine());
                        break;

                    case 4:
                        Console.WriteLine("Ingrese el nuevo tamaño:");
                        listaPropiedades[id].Tamaño = Int32.Parse(Console.ReadLine());
                        break;

                    case 5:
                        Console.WriteLine(listaPropiedades[id].getListaHabitaciones());

                        Console.WriteLine("¿Qué habitación desea modificar?");
                        id = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese el nuevo número");
                        num = Int32.Parse(Console.ReadLine());
                        listaPropiedades[id].CambiarNumHabs(id, num);
                        break;

                    case 6:
                        if (listaPropiedades[id].Patio) {
                            listaPropiedades[id].Patio = false;
                        }
                        else if (!listaPropiedades[id].Patio) {
                            listaPropiedades[id].Patio = true;
                        }
                        break;
                }
                run = false;
                break;
            }
            else if (key == ConsoleKey.D2) {
                continue;
            }

        }
    }

    public void eliminarPropiedad() {
        bool run = true;
        verLista(listaPropiedades);
        
        while (run) {
            Console.WriteLine("¿Qué propiedad desea eliminar?");
            int id = Int32.Parse(Console.ReadLine());
            listaPropiedades[id].ToString();

            Console.WriteLine("¿Esta es la propiedad que desea eliminar?\n (1) = Si\n (2) = No");
            if (key == ConsoleKey.D1) {
                listaPropiedades.Remove(listaPropiedades[id]);
            }
            else if (key == ConsoleKey.D2) {
                continue;
            }
        }
        

    }
}