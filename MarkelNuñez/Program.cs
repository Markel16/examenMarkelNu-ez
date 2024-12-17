using System;

class Program
{
    static void Examen()
    {
        int cantidadDeNumeros = 10;
        int[] numeros = new int[cantidadDeNumeros];
        Console.WriteLine($"Introduce {cantidadDeNumeros} una cantidad de numeros enteros");

        // Entrada de números
        for (int i = 0; i < cantidadDeNumeros; i++)
        {
            Console.Write($"Coloca un numero: ");
            while (!int.TryParse(Console.ReadLine(), out numeros[i]))
            {
                Console.Write("Solo valen numeros, prueba de nuevo: ");
            }
        }

        // Mostrar lista de números separados por espacios
        Console.WriteLine("\nEsta es tu lista de numeros que has puesto:");
        for (int i = 0; i < cantidadDeNumeros; i++)
        {
            if (i == cantidadDeNumeros - 1)
                Console.Write(numeros[i]); // Último número sin espacio
            else
                Console.Write(numeros[i] + " ");
        }
        Console.WriteLine();

        // Mostrar lista de números separados por comas
        Console.WriteLine("\nEsta es tumlista de numeros separados por comas:");
        bool esPrimero = true;
        foreach (int i in numeros)
        {
            if (!esPrimero) Console.Write(", ");
            Console.Write(i);
            esPrimero = false;
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        Examen();
    }
}
