using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    internal class Vertebrado : Animal
    {
        public string? tipo;
        public bool tienepatas;
        public bool esDomestico;
        public bool esHerbivoro;
        public bool esCarnivoro;

        public void imprimir()
        {
            Console.WriteLine("Tipo :" + tipo);
            Console.WriteLine("Tiene patas :" + tienepatas);
            Console.WriteLine("Es Domestico :" + esDomestico);
            Console.WriteLine("Es Herbivoro :" + esHerbivoro);
            Console.WriteLine("Es Carnivoro :" + esCarnivoro);
        }
    }
    
}
