public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("CODIGO: Iterativo");
        // Llama a la función para generar la serie Iteractivo con los primeros 10 términos
        GenerarSerieIterativo(8);

        // Imprime un salto de línea para separar las dos secuencias
        Console.WriteLine();
        Console.WriteLine("CODIGO: Recursivo");

        // Llama a la función para generar la serie recursiva con los primeros 10 términos
        GenerarSerieRecursivo(8, 1);
        
    }
    public static void GenerarSerieIterativo(int A)
{
    // Itera desde 1 hasta A
    for (int i = 1; i <= A; i++)
    {
        // Imprime el término generado por la función GenerarSerie
        Console.Write(GenerarSerieI(i));

        // Imprime una coma y un espacio si no es el último término
        if (i < A)
        {
            Console.Write(", ");
        }
    }
}

public static int GenerarSerieI(int A)
{
    // Caso base: si A es 1, devuelve 1
    if (A == 1)
    {
        return 1;
    }
    // Caso base: si A es 2, devuelve 6
    else if (A == 2)
    {
        return 6;
    }
    // Caso recursivo: si A es par, llama recursivamente restando 2 y resta 1 al resultado
    else if (A % 2 == 0)
    {
        return GenerarSerieI(A - 2) - 1;
    }
    // Caso recursivo: si A es impar, llama recursivamente restando 2 y suma 1 al resultado
    else
    {
        return GenerarSerieI(A - 2) + 1;
    }
}
    public static void GenerarSerieRecursivo(int B, int i)
    {
        // Verifica si el índice actual es menor o igual al límite
        if (i <= B)
        {
            // Llama a la función para generar el término actual e imprímirlo
            Console.Write(GenerarTerminoR(i));

            // Imprime una coma y un espacio si no es el último término
            if (i < B)
            {
                Console.Write(", ");
            }

            // Llama recursivamente a la función con el siguiente índice
            GenerarSerieRecursivo(B, i + 1);
        }
    }

    public static int GenerarTerminoR(int B)
    {
        // Caso base: si B es 1, devuelve 1
        if (B == 1)
        {
            return 1;
        }
        // Caso base: si B es 2, devuelve 6
        else if (B == 2)
        {
            return 6;
        }
        // Caso recursivo segundo secuencia: si Ba es par, llama recursivamente restando 2 y resta 1 al resultado
        else if (B % 2 == 0)
        {
            return GenerarTerminoR(B - 2) - 1;
        }
        // Caso recursivo primera secuencia: si B es impar, llama recursivamente restando 2 y suma 1 al resultado
        else
        {
            return GenerarTerminoR(B - 2) + 1;
        }
    }
}