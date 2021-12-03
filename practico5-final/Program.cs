using System;
using System.Collections.Generic;

namespace practico5
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersona cliente = PeopleFactory.Creador(0,"Guido");
            IPersona admin = PeopleFactory.Creador(1,"Carina");
            IPersona admin2 = (Administrador)PeopleFactory.Creador(1,"Zinerva");
            IPersona desarrollador = PeopleFactory.Creador(2,"Alonzo");
            IPersona desarrollador2 = (Desarrollador)PeopleFactory.Creador(2,"Raffa");

            List<IPersona> listaPersona = new List<IPersona>{cliente,admin,admin2,desarrollador,desarrollador2};
            Sistema.GetInstance().ListaPersonas = listaPersona;

            ((Cliente)cliente).crearTarea();
            ((Administrador)admin).aprobarTarea(true,0);
            ((Cliente)cliente).crearTarea();
            ((Administrador)admin2).aprobarTarea(false,1);
            ((Desarrollador)desarrollador).realizarTarea(0);
            
        }
    }
}
