namespace EspTarea
{
  public class Tarea
  {
    public int _tareaId { set; get; }
    public string _descripcion { set; get; }
    public int _duracion { set; get; }

    public Tarea(int id, string desc, int dur)
    {
      this._tareaId = id;
      this._descripcion = desc;
      this._duracion = dur;
    }
  }
}
