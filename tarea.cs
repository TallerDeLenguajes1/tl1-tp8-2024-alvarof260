namespace EspTarea
{
  public class Tarea
  {
    int tareaId;

    string descripcion;

    int duracion;

    public Tarea(int TareaId, string Descripcion, int Duracion)
    {
      this.tareaId = TareaId;
      this.descripcion = Descripcion;
      this.duracion = Duracion;
    }

    public string mostrarTarea()
    {
      return $"Tarea: {this.tareaId} - Descripción: {this.descripcion} - Duración: {this.duracion}";
    }
  }
}
