using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[2] Imprimir la raíz cuadrada de los 10 primeros números enteros");
                Console.WriteLine("[3] Resta de dos números");
                Console.WriteLine("[4] Multiplicación de dos números");
                Console.WriteLine("[5] División de dos números");
                Console.WriteLine("[6] Mostrar los 10 primeros números primos.");
                Console.WriteLine("[7] Convertir de Grados Celsius a Grados Fahrenheit");
                Console.WriteLine("[8] Convertir de Grados Fahrenheit a Grados Celsius");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingresar una opción y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer número");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma (a,b));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Ingrese el primer número");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La resta de {0} y {1} es {2}", c, d, Resta(c, d));
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Ingrese el primer número");
                        int f = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int g = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La multiplicación de {0} y {1} es {2}", f, g, Multiplicacion(f, g));
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Ingrese el primer número");
                        int h = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int i = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La división de {0} y {1} es {2}", h, i, Division(h, i));
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.WriteLine("Diez primeros números primos");
                        Primos();
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.WriteLine("Ingrese el número que desea convertir");
                        int j = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("{0} Grados Celsius es igual a {1} Grados Fahrenheit", j, ConversionCF(j));
                        Console.ReadKey();
                        break;
                    case "8":
                        Console.WriteLine("Ingrese el número que desea convertir");
                        int k = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("{0} Grados Fahrenheit es igual a {1} Grados Celsius", k, ConversionFC(k));
                        Console.ReadKey();
                        break;
                }
            } while (!opcion.Equals("0"));
        }

        //Función para calcular la suma de 2 números enteros
        static int Suma(int a, int b)
        {
            return a + b;
        }
        //Procedimiento que imprime la raíz cuadrada de los 10 primeros números
        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raíz cuadrada de {0} es : {1}", i, Math.Sqrt(i));
            }
        }
        //Resta
        static int Resta(int c, int d)
        {
            return c - d;
        }
        //Multiplicación
        static int Multiplicacion(int f, int g)
        {
            return f * g;
        }
        //División
        static int Division(int h, int i)
        {
            return h / i;
        }
        //Primos
        static void Primos()
        {
            int n = 2;
            int total = 1;
            while(total <= 10)
            {
                bool esPrimo = true;
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }
                if (esPrimo)
                {
                    Console.WriteLine(n);
                    total++;
                }
                n++;
            }
        }
        //Conversión C a F
        static double ConversionCF(int j)
        {
            double F = ((9 * j) / 5) + 32;
            return F;
        }
        //Conversión de F a C
        static double ConversionFC(int k)
        {
            double C = ((k - 32) * 5) / 9;
            return C;
        }
}
}
