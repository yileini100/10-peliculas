// See https://aka.ms/new-console-template for more information

Console.WriteLine("listado de 10 peliculas");
Console.WriteLine();

// Definir arrays para las series de películas y las categorías
string[] Peliculas = new string[10];
string[] categorias = new string[10];


// Leer los datos de las series y categorías
for (int i = 0; i < Peliculas.Length; i++)
{
    Console.WriteLine("Ingrese el nombre de la pelicula #{0}:", (i + 1));
    Peliculas [i] = Console.ReadLine();

    Console.WriteLine("Ingrese la categoría de la pelicula #{0}:", (i + 1));
    categorias[i] = Console.ReadLine();
}

Console.WriteLine();

// Mostrar los datos en pantalla
Console.WriteLine("Datos de las series de películas:");
for (int i = 0; i < categorias.Length; i++)
{
    Console.WriteLine("Serie {0}:  y  Categoría: {1}", Peliculas [i], categorias[i]);
}

Console.ReadLine();









