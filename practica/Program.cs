    public class Matrices
    {
        public static void Main (string[] args){

            MatrizEnteros Matriz = new MatrizEnteros(4 , 4);
            Console.WriteLine("---------------------------");
            Matriz.M[0, 0]  = 1;
            Matriz.M[0, 1] = 3;
            Matriz.M[0, 2] = 2;
            Matriz.M[0, 3] = 1;
            Matriz.M[1, 0] = 3;
            Matriz.M[1, 1] = 5;
            Matriz.M[1, 2] = 4;
            Matriz.M[1, 3] = 3;
            Matriz.Insertar(2, 0, 5);
            Matriz.Insertar(3, 2 , 4);
            Matriz.M[2, 0] =5;
            Matriz.M[2, 1] =6;
            Matriz.M[2, 2] =5;
            Matriz.M[2, 3] =6;
            Matriz.M[3, 0] =7;
            Matriz.M[3, 1] =2;
            Matriz.M[3, 2] =3;
            Matriz.M[3, 3] =5;
            Matriz.MostrarMatriz();
            Console.WriteLine("---------------------------");
        }
    }
