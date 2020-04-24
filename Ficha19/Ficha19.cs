using System;

namespace Ficha19
{
    public class Ficha19
    {//biblioteca math

        #region exercicio 1
        //Calcular a área e o perímetro de círculo, sabendo o raio.

        public static void exercicio1()
        {
            Console.WriteLine("Raio?");
            var raio = Convert.ToInt32(Console.ReadLine());

            var area = Math.PI * (Math.Pow(raio, 2));
            var perimetro = raio * 2 * Math.PI;

            Console.WriteLine($"A área é {area} e o perímetro é {perimetro}");
        }

        #endregion

        #region exercicio 2
        //Apresenta um número arredondado para cima

        public static void exercicio2()
        {
            Console.WriteLine("Número?");
            var num = Convert.ToDouble(Console.ReadLine());

            var numArredondado = Math.Ceiling(num);
            Console.WriteLine($"O número arredondado para cima é {numArredondado}");

        }

        #endregion

        #region exercicio 3
        //Apresenta um número arredondado para baixo
        public static void exercicio3()
        {
            Console.WriteLine("Número?");
            var num = Convert.ToDouble(Console.ReadLine());

            var numArredondado = Math.Truncate(num);
            Console.WriteLine($"O número arredondado para baixo é {numArredondado}");

        }

        #endregion

        #region exercicio 4

        //Apresenta um número arrendondado
        public static void exercicio4()
        {
            Console.WriteLine("Número?");
            var num = Convert.ToDouble(Console.ReadLine());

            var numArredondado = Math.Round(num);
            Console.WriteLine($"O número arredondado é {numArredondado}");

        }

        #endregion

        #region exercicio 5
        //Apresenta o quadrado de um número

        public static void exercicio5()
        {
            Console.WriteLine("Número?");
            var num = Convert.ToDouble(Console.ReadLine());

            var numQuadrado = Math.Pow(num, 2);
            Console.WriteLine($"O número ao quadrado é {numQuadrado}");

        }


        #endregion

        #region exercicio 6
        //Apresenta a raiz quadrada de um número
        public static void exercicio6()
        {
            Console.WriteLine("Número?");
            var num = Convert.ToDouble(Console.ReadLine());

            var numRaiz = Math.Sqrt(num);
            Console.WriteLine($"A raiz quadrada do número é {numRaiz}");

        }
        #endregion

        #region exercicio 7
        //Apresenta o logaritmo de um número
        public static void exercicio7()
        {
            Console.WriteLine("Número?");
            var num = Convert.ToDouble(Console.ReadLine());

            var numLog = Math.Log(num);
            Console.WriteLine($"O logaritmo do número é {numLog}");

        }
        #endregion
        #region exercicio 8
        //Apresenta um valor em gaus (ex: 90º) em radianos
        public static void exercicio8()
        {
            Console.WriteLine("Número?");
            var num = Convert.ToDouble(Console.ReadLine());

            var numRadianos = num*(Math.PI/180);
            Console.WriteLine($"O número em graus radianos é {numRadianos}");

        }
        #endregion
        #region exercicio 9
        //Apresenta o valor absoluto de um número (ex: |-1| = 1 e |1| = 1)
        public static void exercicio9()
        {
            Console.WriteLine("Número?");
            var num = Convert.ToDecimal(Console.ReadLine());

            var numAbs = Math.Abs(num);
            Console.WriteLine($"O número absoluto é {numAbs}");

        }
        #endregion
        #region exercicio 10
        //Verifica se um valor é negativo ou não
        public static void exercicio10()
        {
            Console.WriteLine("Número?");
            var num = Convert.ToDecimal(Console.ReadLine());

            if (num < 0){ Console.WriteLine("É negativo."); }
            else { Console.WriteLine("É positivo."); }

        }
        #endregion


    }
}
