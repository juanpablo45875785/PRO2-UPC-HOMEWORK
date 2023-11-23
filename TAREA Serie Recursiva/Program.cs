using System;

public class Program
{
    public static void Main(string[]args)
    {
        // Imprimir los primeros 10 términos de la serie

        // Bucle for que itera desde 1 hasta 10
        for (int i = 1; i <= 10; i++)
        {
            // Llama a la función RecursivaSerie y muestra el resultado en la consola
            Console.Write(RecursivaSerie(i));
            
            // Imprimir una coma y un espacio si no es el último número
            if (i < 10)
            {
                Console.Write(",");
            }
        }
    }

    // Función recursiva para calcular los términos de la serie
    public static int RecursivaSerie(int a)
    {
        // Primer caso base: si n es igual a 1, devuelve 1
        if (a == 1)
        {
            return 1;
        }
        // Segundo caso base: si a es igual a 2, devuelve 6
        if (a == 2)
        {
            return 6;
        }
        // Tercer caso: si a es par, estamos en la segunda secuencia (6, 5, 4, ...)
        if (a % 2 == 0)
        {
            return RecursivaSerie(a - 2) - 1;
        }
        // Cuarto caso: si a es impar, estamos en la primera secuencia (1, 2, 3, ...)
        else
        {
            return RecursivaSerie(a - 2) + 1;
        }
    }
}

