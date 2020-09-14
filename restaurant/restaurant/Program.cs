using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurant Tegui = new Restaurant(10,18,5,true);
            Console.WriteLine(Tegui.cantidadMesas);
             
        }
    }
}
