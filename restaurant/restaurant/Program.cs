using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurant Tegui = new Restaurant(10,18,5,true);
            Tegui.agregarEmpleado("Juan");
            Tegui.agregarEmpleado("Pepe");
            Tegui.quitarEmpleado("Pepe");
            bool empleadoQuitado = Tegui.quitarEmpleado("Gonzalo");
            if(empleadoQuitado == true)
            {
                Console.WriteLine("Empleado quitado");
            } else
            {
                Console.WriteLine("No se encontró empleado a quitar");
            }
            Tegui.agregarMesa();
            Tegui.empleados.ForEach(Print);
            void Print(string s)
            {
                Console.WriteLine(s);
            }

        }
    }
}
