class Program
{
    static void Main(string[] args)
    {
        MatrizCadenas MC = new MatrizCadenas(8, 8);
        MC.CargarMatrizDefault();

        // Insertar torres en la columna 0 y 7
        for (int i = 0; i < 8; i += 7)
        {
            MC.Insertar(i, 0, "Torre  B"); // Torre blanca
            MC.Insertar(i, 7, "Torre  N"); // Torre negra
        }

        // Insertar caballos en la columna 1 y 6
        for (int i = 1; i < 8; i += 5)
        {
            MC.Insertar(i, 0, "CaballoB"); // Caballo blanco
            MC.Insertar(i, 7, "CaballoN"); // Caballo negro
        }

        // Insertar alfiles en la columna 2 y 5
        for (int i = 2; i < 8; i += 3)
        {
            MC.Insertar(i, 0, "Alfil  B"); // Alfil blanco
            MC.Insertar(i, 7, "Alfil  N"); // Alfil negro
        }

        // Insertar reinas en la columna 3 y 6
        for (int i = 3; i < 8; i += 5)
        {
            MC.Insertar(i, 0, "Reina  B"); // Reina blanca
            MC.Insertar(i, 7, "Reina  N"); // Reina negra
        }

        // Insertar reyes en la columna 4 y 7
        for (int i = 4; i < 8; i += 6)
        {
            MC.Insertar(i, 0, "Rey    B"); // Rey blanco
            MC.Insertar(i, 7, "Rey    N"); // Rey negro
        }

        // Insertar peones en la fila 6 y 1
        for (int i = 0; i < 8; i++)
        {
            MC.Insertar(i, 1, "Peón   B"); // Peón blanco
            MC.Insertar(i, 6, "Peón   N"); // Peón negro
        }

        // Mover los peones negros
        MC.MoverBlackPeon(2, 6);
        MC.MoverBlackPeon(5, 6);
        MC.MoverBlackPeon(5, 5);
        MC.MoverBlackAlfil(2, 7 , 2, true);
        MC.MostrarMatriz();
    }
}


