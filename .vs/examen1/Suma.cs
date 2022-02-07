using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen1
{
    class Suma
    {
            public static int suma(int[] vector, int n)
            {
                if (n <= 0)
                    return 0;
                return (suma(vector, n - 1) + vector[n - 1]);
            }
    }
}
