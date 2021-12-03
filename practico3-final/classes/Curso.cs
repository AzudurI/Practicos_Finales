using System;
using System.Collections.Generic;
public class Curso {

    public Docente DocenteTitular {get; set; }
    public WebAsignatura WEBAsignatura {get; set; }
    public List<Alumno> ListaAlumnos {get; set; }

    public Curso (Docente docenteTitular, WebAsignatura webAsignatura, List<Alumno> listaAlumnos) {
        this.DocenteTitular = docenteTitular;
        this.WEBAsignatura = webAsignatura;
        this.ListaAlumnos = listaAlumnos;
    }

    public string listarAlumnos() {
        string s = "";
        foreach (var alumno in ListaAlumnos) {
           s += $"\n\t{alumno.ToString()}";
        }
    return s;
    }   

    public string listarPersonas() {
        return ($"\nDocente titular:\n\t{this.DocenteTitular}\nAlumnos:\n\t{this.listarAlumnos()}");
    }

}