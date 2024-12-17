static void Examen()
{
    int cantidadDeNumeros = 10;
    int[] numeros = new int[cantidadDeNumeros];
    Console.WriteLine($"Introduce {cantidadDeNumeros} una cantidad de numeros enteros");

    for (int i = 0; i < cantidadDeNumeros; i++)
    {
        Console.WriteLine($"Coloca un numero {i + 1}:");

        while (!int.TryParse(Console.ReadLine(), out numeros[i]))
        {
            Console.Write("Solo valen numeros, prueba de nuevo:");
        }
    }
}