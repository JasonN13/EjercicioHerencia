using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    internal class Invertebrado : Animal
    {
        public string? Tipo;
        public bool Tienepatas;
        public int numeropatas;
        public bool tieneconcha;

        public void IMPRIMIR()
        {
            Console.WriteLine("Tipo :" + Tipo);
            Console.WriteLine("Tiene Patas :" + Tienepatas);
            Console.WriteLine("Numero Patas :" + numeropatas);
            Console.WriteLine("Tiene Concha :" + tieneconcha);
        }

    }
}
