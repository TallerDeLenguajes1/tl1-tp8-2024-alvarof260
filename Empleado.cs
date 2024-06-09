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

  }
}
