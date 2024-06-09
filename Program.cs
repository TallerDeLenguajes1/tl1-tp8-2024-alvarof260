using EspTarea;

var tareas = new List<Tarea>();

for (int i = 0; i < 5; i++)
{
  tareas.Add(new Tarea(i, $"Tarea {i}", (i + 1) * 6));
}

foreach (var tarea in tareas)
{
  Console.WriteLine(tarea.mostrarTarea());
}
