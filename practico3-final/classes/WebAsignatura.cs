using System;
using System.Collections.Generic;
public class WebAsignatura {


    private List<Tarea> listaTareas;

    public List<Tarea> ListaTareas {
        get { return ListaTareas; }
        set { ListaTareas = value; }
    }

    public WebAsignatura (List<Tarea> Listatareas) {
        this.listaTareas = Listatareas;
    }

}