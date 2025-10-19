

using Clase11_Ejercicio2;
using static Clase11_Ejercicio2.ICOMPARABLE;

class Program
{
    static void Main()
    {
        List<Empleado> empleados = new List<Empleado>
        {
            new Empleado { Nombre = "Ana", Edad = 25, Salario = 50000, Antiguedad = 2, Posicion = "Junior" },
            new Empleado { Nombre = "Carlos", Edad = 40, Salario = 90000, Antiguedad = 10, Posicion = "Senior" },
            new Empleado { Nombre = "Beatriz", Edad = 30, Salario = 70000, Antiguedad = 5, Posicion = "Semi" }
        };

        Console.WriteLine("Ordenado por Nombre:");
        empleados.Sort(new OrdenarPorNombre());
        Mostrar(empleados);

        Console.WriteLine("\nOrdenado por Edad:");
        empleados.Sort(new OrdenarPorEdad());
        Mostrar(empleados);

        Console.WriteLine("\nOrdenado por Salario ASC:");
        empleados.Sort(new OrdenarPorSalario());
        Mostrar(empleados);

        Console.WriteLine("\nOrdenado por Salario DESC:");
        empleados.Sort(new OrdenarPorSalarioDescendentemente());
        Mostrar(empleados);

        Console.WriteLine("\nOrdenado por Antigüedad:");
        empleados.Sort(new OrdenarPorAntiguedad());
        Mostrar(empleados);

        Console.WriteLine("\nOrdenado por Posición:");
        empleados.Sort(new OrdenarPorPosicion());
        Mostrar(empleados);

    static void Mostrar(List<Empleado> empleados)
        {
            foreach (var e in empleados)
            {
                Console.WriteLine($"{e.Nombre,-10} Edad: {e.Edad,-3} Salario: {e.Salario,-7} Antiguedad: {e.Antiguedad,-3} Posición: {e.Posicion}");
            }
        }
    }
}