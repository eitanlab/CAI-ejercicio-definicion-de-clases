using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Veterinaria DogTown = new Veterinaria("DogTown", 10);
            DogTown.agregarPaciente("Pepe");
            DogTown.agregarPaciente("Roco");
            DogTown.operarPaciente("Pepe");
        }
    }
}
