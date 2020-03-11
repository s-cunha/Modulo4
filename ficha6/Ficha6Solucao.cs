using System;

namespace Ficha6
{
    public class Ficha6Solucao
    {
        #region Exercicio1
        public static void Exercicio1()
        {
            Console.WriteLine("Introduz um nome.");
            var nome = Console.ReadLine();
            OlaNome(nome);

        }
        /// <summary>
        /// Escreve Olá
        /// </summary>
        /// <param name="nome">O nome a apresentar</param>
        private static void OlaNome(string nome)
        {
            Console.WriteLine("Olá, " + nome + "!");
        }

        #endregion

        #region Exercício2
        public static void Exercicio2()
        {
            Console.WriteLine("Introduz um numero.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduz um segundo numero.");
            int num2 = Convert.ToInt32(Console.ReadLine());

            SomaNum(num1, num2);
        }

        private static void SomaNum(int num1, int num2)
        {
            int num3 = num1 + num2;
            Console.WriteLine("A soma é " + num3);
        }
        #endregion

        #region Exercicio2Parse

        public static void Exercicio22()
        {
            Console.WriteLine("Introduz um numero.");
            var num1 = Console.ReadLine();
            Console.WriteLine("Introduz um segundo numero.");
            var num2 = Console.ReadLine();
            int num1c = ConvertNum(num1);
            int num2c = ConvertNum(num2);
            SomaNum2(num1c, num2c);
        }   

        public static int ConvertNum(string n)
        {
            var parseOk = int.TryParse(n, out int parsedNum);
            if (parseOk) //==true//
            {
                return parsedNum;
            }
            else
            {
                return -1;
            }

            //return int.Parse(n);
        }

        private static void SomaNum2(int num1, int num2)
        {
            int num3 = num1 + num2;
            Console.WriteLine("A soma é " + num3);
        }



        #endregion

        #region Exercicio3 Estrutura Rep
        public static void Exercicio3()
        { 
            SomaDez();
        }    
        private static void SomaDez()
        {
                int a = 0;
                int i;
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Introduz um numero.");
                int num = Convert.ToInt32(Console.ReadLine());
                a = a + num;
                Console.WriteLine("A soma é " + a);

            }
        }
        #endregion

        #region Exercicio3
        public static void Exercicio33()
        {
            Console.WriteLine("Introduz um numero.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduz um segundo numero.");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduz um terceiro numero.");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduz um quarto numero.");
            int num4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduz um quinto numero.");
            int num5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduz um sexto numero.");
            int num6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduz um sétimo numero.");
            int num7 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduz um oitavo numero.");
            int num8 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduz um nono numero.");
            int num9 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduz um décimo numero.");
            int num10 = Convert.ToInt32(Console.ReadLine());

            SomaDez1(num1, num2, num3, num4, num5, num6, num7, num8, num9, num10);
        }
        private static void SomaDez1(int n1,int n2,int n3,int n4,int n5,int n6,int n7,int n8,int n9,int n10)
        {
            int sum10 = n1 + n2 + n3 + n4 + n5 + n6 + n7 + n8 + n9 + n10;
            Console.WriteLine("A soma é " + sum10);
        }
        #endregion

        #region exercicio 3 outro
        
        public static int LereConverter()
        {
            Console.WriteLine("Numero?");
            var num = Console.ReadLine();
            var numParsed = ConvertNum(num);
            return numParsed;
        }

        public static void Exercicio333()
        {
            var total = LereConverter();
            total += LereConverter();
            total += LereConverter();
            total += LereConverter();
            total += LereConverter();
            total += LereConverter();
            total += LereConverter();
            total += LereConverter();
            total += LereConverter(); 
            total += LereConverter();
            Console.WriteLine(total);
        }
        #endregion

        #region Exercicio 4
        //solicitar dois numeros e trocar posiçoes e A=B e B=A
        public static void Exercicio4()
        {
            Console.WriteLine("Introduz um numero.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduz um segundo numero.");
            int num2 = Convert.ToInt32(Console.ReadLine());
            TrocaNum(num1, num2);
        }

        private static void TrocaNum(int a,int b)
        {
            int c;
            c = a;
            a = b;
            b = c;

            Console.WriteLine("A = "+ a +" e B = " + b);
        }

        #endregion

        #region Exercicio 5
        /* De uma forma geral, representar as operações:
         * (a) a+b*c
           (b) (d+e)%f
           (c) g+h*k/m
           (d) n+p/q*r-s%t
         */

        #region 5a

        public static void Exercicio5a()
        {
          

            Console.WriteLine("Introduza um número");
            var a = Console.ReadLine();
            Console.WriteLine("Introduza um número");
            var b = Console.ReadLine();
            Console.WriteLine("Introduza um número");
            var c = Console.ReadLine();
            
            var aparsed = ConvertNum(a);
            var bparsed = ConvertNum(b);
            var cparsed = ConvertNum(c);

            CalcNum(aparsed, bparsed, cparsed);
        }

        private static void CalcNum(int n1, int n2, int n3)
        {
            int d = n1 + n2 * n3;
            Console.WriteLine("O resultado é igual a " + d);
        }

        #endregion

        #region 5b
        
        
        
        public static void Exercicio5b()
        {
            Console.WriteLine("Introduza um número");
                        var a = Console.ReadLine();
            Console.WriteLine("Introduza um número");
                        var b = Console.ReadLine();
            Console.WriteLine("Introduza um número");
                        var c = Console.ReadLine();

            var aparsed = ConvertNum(a);
            var bparsed = ConvertNum(b);
            var cparsed = ConvertNum(c);

            CalcNum2(aparsed, bparsed, cparsed);
        }

        private static void CalcNum2(int a, int b, int c)
        {
            int d = (a + b) % c;
            Console.WriteLine("O resultado é igual a " + d);
        }


        #endregion

        #region 5c
        public static void Exercicio5c()
        {
            Console.WriteLine("Introduza um número");
            var a = Console.ReadLine();
            Console.WriteLine("Introduza um número");
            var b = Console.ReadLine();
            Console.WriteLine("Introduza um número");
            var c = Console.ReadLine();
            Console.WriteLine("Introduza um número");
            var d = Console.ReadLine();

            var aparsed = ConvertNum(a);
            var bparsed = ConvertNum(b);
            var cparsed = ConvertNum(c);
            var dparsed = ConvertNum(d);

            CalcNum3(aparsed, bparsed, cparsed, dparsed);
        }

        private static void CalcNum3(int a, int b, int c, int d)
        {
            int e = a+(b*c)/d;
            Console.WriteLine("O resultado é igual a " + e);
        }
        #endregion

        #region 5d
        public static void Exercicio5d()
        {
            Console.WriteLine("Introduza um número");
            var a = Console.ReadLine();
            Console.WriteLine("Introduza um número");
            var b = Console.ReadLine();
            Console.WriteLine("Introduza um número");
            var c = Console.ReadLine();
            Console.WriteLine("Introduza um número");
            var d = Console.ReadLine();
            Console.WriteLine("Introduza um número");
            var e = Console.ReadLine();
            Console.WriteLine("Introduza um número");
            var f = Console.ReadLine();

            var aparsed = ConvertNum(a);
            var bparsed = ConvertNum(b);
            var cparsed = ConvertNum(c);
            var dparsed = ConvertNum(d);
            var eparsed = ConvertNum(e);
            var fparsed = ConvertNum(f);

            CalcNum4(aparsed, bparsed, cparsed, dparsed, eparsed, fparsed);
        }

        private static void CalcNum4(int a, int b, int c, int d, int e, int f)
        {
            int g = a + (b/c)*d - e%f;
            Console.WriteLine("O resultado é igual a " + g);
        }
        #endregion
        #endregion

        #region Exercicio 6
        // Tabuada até 10 do numero

        public static void Exercicio6()
        {
            Console.WriteLine("Introduz um numero.");
            var num = Console.ReadLine();
            var numpar = ConvertNum(num);
            Tabuada10(numpar);

        }
        private static void Tabuada10(int n)
        {
            Console.WriteLine("1 * " + n + " é igual a " + n * 1);
            Console.WriteLine("2 * " + n + " é igual a " + n * 2);
            Console.WriteLine("3 * " + n + " é igual a " + n * 3);
            Console.WriteLine("4 * " + n + " é igual a " + n * 4);
            Console.WriteLine("5 * " + n + " é igual a " + n * 5);
            Console.WriteLine("6 * " + n + " é igual a " + n * 6);
            Console.WriteLine("7 * " + n + " é igual a " + n * 7);
            Console.WriteLine("8 * " + n + " é igual a " + n * 8);
            Console.WriteLine("9 * " + n + " é igual a " + n * 9);
            Console.WriteLine("10 * " + n + " é igual a " + n * 10);
        }



        #endregion

        #region Exercicio 7
        // média de 2 numeros

        public static void Exercicio7()
        {
            Console.WriteLine("Introduz um numero.");
            int num1 = ConvertNum(Console.ReadLine());
            Console.WriteLine("Introduz um segundo numero.");
            int num2 = ConvertNum(Console.ReadLine());
            CalcMedia(num1, num2);

        }
        private static void CalcMedia(int a, int b)
        {
            Console.WriteLine("A média é " + (a + b) / 2);
        }



        #endregion

        #region Exercicio 8
        // media de 5 numeros

        public static void Exercicio8()
        {
            Console.WriteLine("Introduz um numero.");
            int num1 = ConvertNum(Console.ReadLine());
            Console.WriteLine("Introduz um segundo numero.");
            int num2 = ConvertNum(Console.ReadLine());
            Console.WriteLine("Introduz um terceiro numero.");
            int num3 = ConvertNum(Console.ReadLine());
            Console.WriteLine("Introduz um quarto numero.");
            int num4 = ConvertNum(Console.ReadLine());
            Console.WriteLine("Introduz um quinto numero.");
            int num5 = ConvertNum(Console.ReadLine());

            CalcMedia(num1, num2, num3,num4, num5);

        }
        private static void CalcMedia(int a, int b, int c, int d, int e )
        {
            Console.WriteLine("A média é " + (a + b + c + d + e) / 5);
        }


        #endregion

        #region Exercicio 9
        public static void Exercicio9()
        {
            var total = LereConverter();
            total += LereConverter();
            total += LereConverter();
            total += LereConverter();
            total += LereConverter();
            total += LereConverter();
            total += LereConverter();
            total += LereConverter();
            total += LereConverter();
            total += LereConverter();
            Console.WriteLine("A média é igual a "+total/10);
        }
        #endregion

        #region Exercicio 10

        public static void Exercicio10()
        {
            Console.WriteLine("Intruduz um caracter.");
            var a = Console.ReadLine();
            Tabela3x3(a);
        }
        private static void Tabela3x3(string a)
        {
            Console.WriteLine(a + " " + a + " " + a);
            Console.WriteLine(a + " " + a + " " + a);
            Console.WriteLine(a + " " + a + " " + a);
        }

        #endregion

        #region Exercicio 11

        public static void Exercicio11()
            //pedir nome preço e quantidade de produtos
        {

            var total = Compra();
            total += Compra();
            total += Compra();
        
            Console.WriteLine("O total é " + total);
        }
        private static decimal Compra()
        {
                Console.WriteLine("Introduz o nome do produto");
                var nome = Console.ReadLine();

                Console.WriteLine("Introduz o preço do produto");
                decimal preco = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Introduz a quantidade do produto");
                decimal quantidade = Convert.ToDecimal(Console.ReadLine());

                decimal r = preco * quantidade;
                Console.WriteLine("O total do produto " + nome + " é " + r);
                return r;
        }
        #endregion

        #region Ficha 6 parte 2.1

        public static void Exercicio2_1()
        {
            Console.WriteLine("Diz-me algo que eu não saiba.");
            var a = Console.ReadLine();
            Console.WriteLine("Eu já sabia que " + a);
        }

        #endregion

        #region Exercicio 2.2
        public static void Exercicio2_2()
        {
            Console.WriteLine("Introduz um numero.");
            var num1 = Console.ReadLine();
            Console.WriteLine("Introduz um segundo numero.");
            var num2 = Console.ReadLine();

            Console.WriteLine("O primeiro número é " + num1 + " e o segundo número é " + num2);

        }
        #endregion

        #region Exercicio 2.3
        
        public static void Exercicio2_3()
        {
            Console.WriteLine("Introduza a temperatura.");
            decimal temp = Convert.ToDecimal(Console.ReadLine());
            TempsDif(temp);
        }
        private static void TempsDif(decimal t)
        {
            decimal tempf = t * (9 / 5) + 32;
            decimal tempk = t + Convert.ToDecimal("273,15");
            Console.WriteLine("A temperatura " + t + "ºC é " + tempf + "ºF e " + tempk + "ºK.");
        }
        #endregion

        #region Exercicio 3.1
        public static void Exercicio3_1()
        {
            Console.WriteLine("Quantas horas?");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Quantos minutos?");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Quantos segundos?");
            int s = Convert.ToInt32(Console.ReadLine());

            SegundosTotais(h, m, s);

        }

        private static void SegundosTotais ( int a, int b, int c)
        {
            var total = a * 3600 + b * 60 + c;
            Console.WriteLine(a + ":" + b + ":" + c + " é equivalente a " + total + " segundos.");
        }
        #endregion

        #region Exercicio 3.2

        public static void Exercicio3_2()
        {
            Console.WriteLine("Qual é o raio?");
            double r = Convert.ToDouble(Console.ReadLine());
            PerimetroArea(r);

        }
        private static void PerimetroArea(double raio)
        {
            double PI = 3.14; //Convert.ToDouble("3,14");
            double perimetro = 2 * PI * raio;
            double area = PI * raio*raio;
            Console.WriteLine("A área do circulo é " + area + " e o perimetro é " + perimetro);
        }

        #endregion

    }
}
