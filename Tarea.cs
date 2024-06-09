namespace EspTarea
{
  public class Tarea
  {
    int _tareaId { set; get; }
    string _descripcion { set; get; }
    int _duracion { set; get; }

    public Tarea(int id, string desc, int dur)
    {
      this._tareaId = id;
      this._descripcion = desc;
      this._duracion = dur;
    }
  }
}
