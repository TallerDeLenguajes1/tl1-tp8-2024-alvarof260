using EspEmpleado;

public class Program
{
  public static void Main(string[] args)
  {
    Empleado nuevo = new Empleado(1131, "Juan", "Perez");
    int opcion;
    do
    {
      Console.WriteLine("|Menu de Tareas|"); Console.WriteLine("1. Crear Tarea"); Console.WriteLine("2. No Crear Tarea"); Console.WriteLine("Elige una opción: "); int.TryParse(Console.ReadLine(), out opcion); switch (opcion)
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
          break;
      }
    } while (opcion != 2);

    do
    {
      Console.WriteLine("Menu");
      Console.WriteLine("1. Marcar Tarea como realizada");
      Console.WriteLine("2. Mostrar Tareas Pendientes");
      Console.WriteLine("3. Mostrar Tareas Realizadas");
      Console.WriteLine("4. Buscar tarea por id o palabra");
      Console.WriteLine("5. Salir");

      Console.WriteLine("Elige una opción: ");
      int.TryParse(Console.ReadLine(), out opcion);

      switch (opcion)
      {
        case 1:
          Console.WriteLine("Escribe el número de la tarea que quieres marcar como realizada: ");
          int num;
          int.TryParse(Console.ReadLine(), out num);
          nuevo.CambiarEstado(num);
          break;
        case 2:
          nuevo.MostrarTareasPendientes();
          break;
        case 3:
          nuevo.MostrarTareasRealizadas();
          break;
        case 4:
          Console.WriteLine(" 1- Buscar por id");
          Console.WriteLine(" 2- Buscar por palabra clave");
          Console.Write("Ingrese la opción: ");
          int opcionBusqueda = int.Parse(Console.ReadLine());
          if (opcionBusqueda == 1)
          {
            Console.Write("Ingrese el id: ");
            int id = int.Parse(Console.ReadLine());
            nuevo.BuscarTareaPorId(id);
          }
          else if (opcionBusqueda == 2)
          {
            Console.Write("Ingrese la palabra clave: ");
            string palabra = Console.ReadLine();
            nuevo.BuscarTareaPorPalabra(palabra);
          }
          break;
        case 5:
          Console.WriteLine("Gracias por usar el programa");
          break;
      }
    } while (opcion != 5);
  }
}
