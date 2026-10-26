using System;
using System.Collections.Generic;
using System.Text;

namespace P02_PruebasUnitarias
{
    public static class Funciones
    {
        public static long CalcularFactorial(int n)
        {
            if (n < 0)
            {
                return -1;
            }

            long factorial = 1;

            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
        public static bool EsContrasenyaValida(string? contrasenya)
        {
            if (string.IsNullOrEmpty(contrasenya))
            {
                return false;
            }

            if (contrasenya.Length < 8)
            {
                return false;
            }

            if (!contrasenya.Contains('#'))
            {
                return false;
            }

            return true;
        }
    }
}
