using EjercicioHerencia;

Animal animal = new Animal();
animal.nombre = "Perro";
animal.color = "Negro";
animal.tamano = "grande";
animal.familia = "Canina";

Animal animal2 = new Animal();
animal2.nombre = "Gato";
animal2.color = "Gris";
animal2.tamano = "Mediano";
animal2.familia = "Felino";

Vertebrado vertebrado = new Vertebrado();
vertebrado.tipo = "Mamifero";
vertebrado.tienepatas = true;
vertebrado.esDomestico = true;
vertebrado.esHerbivoro = false;
vertebrado.esCarnivoro = true;


Vertebrado vertebrado2 = new Vertebrado();
vertebrado2.tipo = "Mamifero";
vertebrado2.tienepatas = true;
vertebrado2.esDomestico = true;
vertebrado2.esHerbivoro = false;
vertebrado2.esCarnivoro = true;

Animal animalIV = new Animal();
animalIV.nombre = "Hormiga";
animalIV.color = "Negro";
animalIV.tamano = "Pequeño";
animalIV.familia = "Formicidae";

Invertebrado invertebrado = new Invertebrado();
invertebrado.Tipo = "Insecto";
invertebrado.Tienepatas = true;
invertebrado.numeropatas = 6;
invertebrado.tieneconcha = false;

Animal animalIV2 = new Animal();
animalIV2.nombre = "Mariposa";
animalIV2.color = "Blanca";
animalIV2.tamano = "Pequeño";
animalIV2.familia = "Lepidopteros";

Invertebrado invertebrado2 = new Invertebrado();
invertebrado2.Tipo = "Insecto";
invertebrado2.Tienepatas = true;
invertebrado2.numeropatas = 6;
invertebrado2.tieneconcha = false;

if (animal.validar())
{
    Console.WriteLine("Primer Animal");
    Console.WriteLine("");
    animal.Imprimir();
    vertebrado.imprimir();
    Console.WriteLine("");
    Console.WriteLine("Segundo Animal");
    Console.WriteLine("");
    animal2.Imprimir();
    vertebrado2.imprimir();
    Console.WriteLine("");
    Console.WriteLine("Primer Animal invertebrado");
    Console.WriteLine("");
    animalIV.Imprimir();
    invertebrado.IMPRIMIR();
    Console.WriteLine("");
    Console.WriteLine("Segundo Animal invertebrado");
    Console.WriteLine("");
    animalIV2.Imprimir();
    invertebrado2.IMPRIMIR();
}
else
{
    Console.WriteLine("Ingrese todos los datos");
}

