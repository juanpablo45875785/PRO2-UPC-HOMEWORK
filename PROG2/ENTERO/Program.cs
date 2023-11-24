
    using System;

class Program
{
    static void Main()
    {
        ImprimirSerieRecursiva(2, 6);
    }

    static void ImprimirSerieRecursiva(int numeroA, int numeroB)
    {
        if (numeroA <= numeroB)
        {
            Console.Write(numeroA + ", ");
            Console.Write(numeroB + ", ");
            ImprimirSerieRecursiva(numeroA + 1, numeroB - 1);
        }
    }
}
