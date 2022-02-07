using System;

namespace examen1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[] { 6, 7, 8, 9 };
            Console.WriteLine(suma(vector, vector.Length));
        }

        static int suma(int[] vector, int n)
        {
            if (n <= 0)
                return 0;
            return (suma(vector, n - 1) + vector[n - 1]);
        }
    }
}
