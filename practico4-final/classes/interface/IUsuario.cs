using System.Collections.Generic;
interface IUsuario {
    public string Nombre {get; set; }
    public int Contador {get; set; }
    public List<Objeto> Inventario {get; set; }
    void realizarTarea(ref List<Tarea> listaTarea, int id);
    void canjearPuntos(Objeto objeto);
    void consumirObjetos(int id);
    }