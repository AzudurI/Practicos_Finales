using System;
using System.Collections.Generic;
public class Sistema 
{

    private List<IPersona> listaPersonas;
    private List<Tarea> listaTareas;

    public List<IPersona> ListaPersonas {
        get { return listaPersonas; }
        set { listaPersonas = value; }
    }
    
    /////////////////////////////SINGLETON
    private Sistema() 
    {
        listaPersonas = new List<IPersona>();
        listaTareas = new List<Tarea>();
    }
    private static Sistema instancia;
    public static Sistema GetInstance() {
        if (instancia == null) 
        {
            instancia = new Sistema();
        }
        return instancia;
    }

    /////////////////////////////OBSERVER

    public void Notificar(string s) {
        foreach (var persona in listaPersonas) {
            persona.Notify(s);
        }

    }
    //////////////////////////////7

    public void agregarTarea(Tarea t) {
        listaTareas.Add(t);
        Notificar("Nueva tarea");
    }

    public void aprobarTarea(bool Aprobar, int id) {
        listaTareas[id].Aprobado = Aprobar;
        if (Aprobar) {
            Notificar("Tarea aprobada");
        }
    }

    public void realizarTarea(int id) {
        listaTareas[id].Finalizada = true;
        Notificar("Tarea finalizada");
    }
}