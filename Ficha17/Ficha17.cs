using System;

namespace Ficha17
{
    public class Ficha17
    {
        /// Manipulação de strings
        /// 
        #region exercicio1
        //Solicitar uma string e um índice. Apresentar o caracter correspondente ao índice com base na string.
        public static void exercicio1()
        {
            Console.WriteLine("Brinquedo preferido?");
            var res = Console.ReadLine();
            string brinquedo = res;
            var a = brinquedo[3];
            Console.WriteLine(a);
        }

        #endregion

        #region exercicio2

        //Solicitar duas strings e compará-las caracter a caracter
        public static void exercicio2()
        {
            Console.WriteLine("Primeira palavra?");
            var pal1 = Console.ReadLine();
            Console.WriteLine("Segunda palavra?");
            var pal2 = Console.ReadLine();
            var @length = Math.Min(pal1.Length, pal2.Length);
            var iguais = true;
            for (var i=0; i < length; i++)
            {
                
                if (pal1[i] != pal2[i])
                {
                    iguais = false;
                }
            }
            if (!iguais)
            {
                Console.WriteLine("As duas palavras são diferentes.");
            }
            else
            {
                Console.WriteLine("As duas palavras são iguais.");
            }

            //var res = pal1.Equals(pal2);
            //if (res == true)
            //{
            //    Console.WriteLine("As duas palavras são iguais.");
            //}
            //else
            //{
            //    Console.WriteLine("As duas palavras são diferentes.");
            //}
        }

        #endregion

        #region exercicio 3
        //Solicitar uma string e apresentar a contagem de palavras
        public static void exercicio3()
        {
            Console.WriteLine("Frase?");
            var frase = Console.ReadLine();

            var count = 0;
            foreach(string pal in frase.Split(" "))
            {
                count++;
            }
            Console.WriteLine(count);
        }

        #endregion

    }
}
