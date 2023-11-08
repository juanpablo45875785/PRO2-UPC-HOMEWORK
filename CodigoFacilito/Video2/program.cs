using System;
using System.Collections.Generic;
using System.Linq;
using system.Text;
using System.Threading.Tasks;

namespace Video2
{
    class program
    {
        static void Main(string[] args)
        {
            int i = 0,
            decimal x = 0.0m;
            float f = 0.0f;
            double d = 0.0D
            string cadena = "hola mundo";
            bool bandera = false;
            DateTime fecha = DateTime.MinValue;
            Console.WriteLine("Es el valor de i es: {0}", i);
            Console.WriteLine("Es el valor de x es: {0:C}", x);
            Console.WriteLine("Es el valor de f es: {0:F2}", f);
            Console.WriteLine("Es el valor de d es: {0:F2}", d);
            Console.WriteLine("Es el valor de cadena es: " + cadena);
            Console.WriteLine("Es el valor de bandera es: " + bandera.ToString());
            Console.WriteLine("Es el valor de fecha es: " + fecha.ToShortDateString());
            Console.ReadKey();


        } 
    }
}