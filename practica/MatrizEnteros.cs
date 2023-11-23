public class MatrizEnteros
{
    public int[,] M;        // Elemento de la Matriz
    public int fila;         // Cantidad de filas
    public int columna;      // Cantidad de columnas

    // Constructor vacío
    public MatrizEnteros()
    {
        M = new int[0, 0];
        fila = 0;
        columna = 0;
    }

    // Constructor que recibe la cantidad de filas (cantX) y columnas (cantY)
    public MatrizEnteros(int cantX, int cantY)
    {
        // Dimensionar la matriz
        M = new int[cantX, cantY];
        columna = cantX;
        fila = cantY;
    }
    // Método para mostrar el contenido de la matriz
    public void MostrarMatriz()
    {
        for (int x = 0; x < columna; x++)
        {
            for (int y = 0; y < fila; y++)
            {
                Console.Write(M[y, x] + "\t");
            }
            Console.WriteLine();
        }
    }

    // Método para insertar un elemento en una posición específica de la matriz
    public void Insertar(int posX, int posY, int ele)
    {
        M[posX, posY] = ele;
    }

    // Métodos para llenar la matriz con diferentes patrones

    // Llenar la matriz con valores incrementales
    public void LlenarMatriz_v1()
    {
        int dato = 1;
        for (int x = 0; x < columna; x++)
        {
            for (int y = 0; y < fila; y++)
            {
                M[x, y] = dato++;
            }
        }
    }

    // Llenar la matriz con valores decrementales
    public void LlenarMatriz_v2()
    {
        int dato = 16;
        for (int x = 0; x < columna; x++)
        {
            for (int y = 0; y < fila; y++)
            {
                M[x, y] = dato--;
            }
        }
    }

    // Llenar la matriz con un valor decreciente por fila
    public void LlenarMatriz_v3()
    {
        int dato = 4;
        for (int x = 0; x < columna; x++)
        {
            for (int y = 0; y < fila; y++)
            {
                M[x, y] = dato;
            }
            dato--;
        }
    }


}
