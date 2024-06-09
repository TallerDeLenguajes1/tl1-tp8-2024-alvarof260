using EspEmpleado;

public class Program
{
  public static void Main(string[] args)
  {
    Empleado nuevo = new Empleado(1131, "Juan", "Perez");
    int opcion;

    do
    {
      Console.WriteLine("|Menu de Tareas|");
      Console.WriteLine("1. Crear Tarea");
      Console.WriteLine("2. No Crear Tarea");
      Console.WriteLine("Elige una opción: ");
      int.TryParse(Console.ReadLine(), out opcion);

      switch (opcion)
      {
        case 1:
          Console.WriteLine("Escribe la descripción de la tarea: ");
          string desc = Console.ReadLine();
          Console.WriteLine("Escribe el tiempo de duración de la tarea: ");
          int dur;
          int.TryParse(Console.ReadLine(), out dur);
          nuevo.CrearTarea(desc, dur);
          break;
        case 2:
          Console.WriteLine("Se han creado {0} tareas", nuevo.TareasPendientes());
          break;
      }
    } while (opcion != 2);


  }
}
