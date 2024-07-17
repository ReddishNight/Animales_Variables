using System;
using System.Collections.Generic;

class Program
{
    static List<string> tipo_especies = new List<string> { "Zorro", "Perro", "Pulpo" };
    static List<string> gafas = new List<string> { "Gafas de sol", "Gafas de lectura", "Sin gafas", "Gafas Fiesteras" };
    static List<string> sombreros = new List<string> { "Sombrero_de_paja", "Gorra", "Sin_sombrero", "Boina", "Sombrero_Vaquero", "Deportiva" };
    static List<string> colores_pelaje = new List<string> { "Pelaje_Marrón", "Pelaje_Negro", "Pelaje_Blanco", "Pelaje_Gris", "Pelaje_Manchado", "Pelaje_Tricolor" };
    static List<string> tamanos = new List<string> { "Tamaño_Pequeño", "Tamaño_Mediano", "Tamaño_Grande" };
    static List<string> pesos = new List<string> { "Peso_Ligero", "Peso_Medio", "Peso_Pesado" };
    static List<string> razas = new List<string> { "Raza 1", "Raza 2", "Raza 3" };
    static List<string> joyas = new List<string> { "Collar de diamantes", "Pulsera de oro", "Sin joyas", "Reloj" };
    static List<string> colores_ojos = new List<string> { "Ojos_Azul", "Ojos_Verde", "Ojos_Marrones", "Ojos_Negros", "Ojos_Dorados" };

    static void Main(string[] args)
    {
        Opciones();
        string? opcion = Console.ReadLine();

        Dictionary<string, string> animal;
        if (opcion == "1")
        {
            animal = AnimalRandom();
        }
        else if (opcion == "2")
        {
            animal = GenerarAnimalManual();
        }
        else
        {
            Console.WriteLine("Opción no válida. Generando un animal aleatorio.");
            animal = AnimalRandom();
        }

        MostrarAnimal(animal);
    }

    static void Opciones()
    {
        Console.WriteLine("Selecciona una opción:");
        Console.WriteLine("1. Automático (Generar un animal aleatorio)");
        Console.WriteLine("2. Manual (Seleccionar características manualmente)");
    }

    static Dictionary<string, string> AnimalRandom()
    {
        Random random = new Random();
        var animal = new Dictionary<string, string>
        {
            { "Especie", tipo_especies[random.Next(tipo_especies.Count)] },
            { "Gafas", gafas[random.Next(gafas.Count)] },
            { "Sombrero", sombreros[random.Next(sombreros.Count)] },
            { "Color de Pelaje", colores_pelaje[random.Next(colores_pelaje.Count)] },
            { "Tamaño", tamanos[random.Next(tamanos.Count)] },
            { "Peso", pesos[random.Next(pesos.Count)] },
            { "Raza", razas[random.Next(razas.Count)] },
            { "Joyas", joyas[random.Next(joyas.Count)] },
            { "Color de Ojos", colores_ojos[random.Next(colores_ojos.Count)] }
        };
        return animal;
    }

    static Dictionary<string, string> GenerarAnimalManual()
    {
        Console.WriteLine("Selecciona las características del animal:");
        string especie = ListaDeOpciones(tipo_especies);
        string gafasSeleccion = ListaDeOpciones(gafas);
        string sombreroSeleccion = ListaDeOpciones(sombreros);
        string colorPelaje = ListaDeOpciones(colores_pelaje);
        string tamanoSeleccion = ListaDeOpciones(tamanos);
        string pesoSeleccion = ListaDeOpciones(pesos);
        string razaSeleccion = ListaDeOpciones(razas);
        string joyasSeleccion = ListaDeOpciones(joyas);
        string colorOjos = ListaDeOpciones(colores_ojos);

        var animal = new Dictionary<string, string>
        {
            { "Especie", especie },
            { "Gafas", gafasSeleccion },
            { "Sombrero", sombreroSeleccion },
            { "Color de Pelaje", colorPelaje },
            { "Tamaño", tamanoSeleccion },
            { "Peso", pesoSeleccion },
            { "Raza", razaSeleccion },
            { "Joyas", joyasSeleccion },
            { "Color de Ojos", colorOjos }
        };
        return animal;
    }

    static string ListaDeOpciones(List<string> lista)
    {
        for (int i = 0; i < lista.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {lista[i]}");
        }

        string? seleccion = Console.ReadLine();
        if (int.TryParse(seleccion, out int index) && index >= 1 && index <= lista.Count)
        {
            return lista[index - 1];
        }

        Console.WriteLine("Por favor, ingresa un número válido de opción.");
        return ListaDeOpciones(lista);
    }

    static void MostrarAnimal(Dictionary<string, string> animal)
    {
        Console.WriteLine("\nCaracterísticas del animal:");
        foreach (var atributo in animal)
        {
            Console.WriteLine($"{atributo.Key}: {atributo.Value}");
        }
    }
}