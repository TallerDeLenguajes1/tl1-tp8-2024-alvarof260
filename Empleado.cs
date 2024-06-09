using EspTarea;
namespace EspEmpleado
{
  public class Empleado
  {
    public int _id { set; get; }
    public string _nombre { set; get; }
    public string _apellidos { set; get; }
    private List<Tarea> _tareasPendientes { set; get; }
    private List<Tarea> _tareasRealizadas { set; get; }

    public Empleado(int id, string nom, string ape)
    {
      this._id = id;
      this._nombre = nom;
      this._apellidos = ape;
      this._tareasPendientes = new List<Tarea>();
      this._tareasRealizadas = new List<Tarea>();
    }

    private int GenerarId()
    {
      return this._tareasPendientes.Count + 1000;
    }

    public void CrearTarea(string desc, int dur)
    {
      Tarea t = new Tarea(GenerarId(), desc, dur);
      this._tareasPendientes.Add(t);
    }

    public int TareasPendientes()
    {
      return this._tareasPendientes.Count;
    }

    public void CambiarEstado(int id)
    {
      Tarea t = this._tareasPendientes.Find(x => x._tareaId == id);
      if (t != null)
      {
        this._tareasPendientes.Remove(t);
        this._tareasRealizadas.Add(t);
      }
    }

    public void MostrarTareasPendientes()
    {
      Console.WriteLine($"Tareas pendientes de {this._nombre} {this._apellidos}");
      foreach (Tarea t in this._tareasPendientes)
      {
        Console.WriteLine($"Tarea {t._tareaId}: {t._descripcion}");
      }
    }

    public void MostrarTareasRealizadas()
    {
      Console.WriteLine($"Tareas realizadas de {this._nombre} {this._apellidos}");
      foreach (Tarea t in this._tareasRealizadas)
      {
        Console.WriteLine($"Tarea {t._tareaId}: {t._descripcion}");
      }

    }

    public void BuscarTareaPorId(int id)
    {
      Tarea tarea = this._tareasPendientes.Concat(this._tareasRealizadas).FirstOrDefault(t => t._tareaId == id);
      if (tarea != null)
      {
        Console.WriteLine(tarea);
      }
      else
      {
        Console.WriteLine("No se encontró la tarea con la ID especificada.");
      }
    }

    public void BuscarTareaPorPalabra(string palabra)
    {
      var tareas = this._tareasPendientes.Concat(this._tareasRealizadas).Where(t => t._descripcion.Contains(palabra)).ToList();
      if (tareas.Any())
      {
        foreach (var tarea in tareas)
        {
          Console.WriteLine(tarea);
        }
      }
      else
      {
        Console.WriteLine("No se encontró ninguna tarea con la palabra clave especificada.");
      }
    }
  }
}
