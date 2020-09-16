using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen
{
    class Program
    {
        static void Main(string[] args)
        {
            Almacen Pepito = new Almacen();
            Pepito.agregarProducto("Arroz");
            Pepito.agregarProducto("Fideos");
            Pepito.agregarProducto("Mostaza");
            Pepito.agregarProducto("Leche");
            Pepito.agregarProducto("Harina");
            Pepito.agregarProducto("Atún");
            Console.WriteLine(Pepito.productos.Count);
            List<string> productosDelAlmacen = new List<string>();
        }
    }
}
