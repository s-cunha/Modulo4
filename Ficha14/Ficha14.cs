using System;

namespace Ficha14
{
    public class Ficha14
    {
        #region exercicio1

        public static void exercicio1()
        {
            Console.WriteLine("Qual é o número de números naturais?");
            var n = int.Parse(Console.ReadLine());
            PrimeirosNumerosNaturais(n);
        }

        public static void PrimeirosNumerosNaturais(int limit,int counter = 1)
        {
            Console.WriteLine(counter);
            if (counter < limit)
            {
                PrimeirosNumerosNaturais(limit, counter+1);
            }
        }

        #endregion
    }
}
