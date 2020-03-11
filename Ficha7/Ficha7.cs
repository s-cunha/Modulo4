using System;

namespace Ficha7
{
    public class Ficha7
    {
        // Resolver utilizando estruturas de controlo

        #region Exercicio 1.1

        public static void Exercicio1_1()
        {
            Console.WriteLine("Introduza um número.");
            double n = Convert.ToDouble(Console.ReadLine());
            PassouOuNao(n);
        }

        private static void PassouOuNao(double a)
        {
            double cond = Convert.ToDouble("9,44");
            if (a > cond)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Passou.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Chumbou.");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        #endregion

        #region Exercicio 1.2

        // solicitar altura e peso e retornar BMI e classificação

        public static void Exercicio1_2()
        {
            Console.WriteLine("Introduza peso.");
            double peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduza altura.");
            double altura = Convert.ToDouble(Console.ReadLine());

            ResultadoBMI(peso, altura);
        }
        private static void ResultadoBMI(double p, double h)
        {
            double bmi = (p * p) / h;
            double a = Convert.ToDouble("18,5");
            double b = Convert.ToDouble("24,9");
            double c = Convert.ToDouble("29,9");

            if (bmi < a)
            {
                Console.WriteLine("Abaixo do peso");
            } else if(a<bmi&&bmi<b){
                Console.WriteLine("Peso Normal");
            } else if (b < bmi && bmi < c)
            {
                Console.WriteLine("Acima do peso");
            } else
            {
                Console.WriteLine("Obesidade");
            }
        }


        #endregion

        #region Exercício 1.3

        public static void Exercicio1_3()
        {
            Console.WriteLine("Introduza um número.");
            var num = Convert.ToInt32(Console.ReadLine());
            Multip37(num);
        }
        private static void Multip37( int n)
        {
            if(n%3 == 0 && n%7==0)
            {
                Console.WriteLine("O número " + n + " é multiplo de 3 e de 7");
            } else if (n % 3 == 0 && n % 7 != 0)
            {
                Console.WriteLine("O número " + n + " é multiplo de 3 mas não de 7");
            } else if (n % 3 != 0 && n % 7 == 0)
            {
                Console.WriteLine("O número " + n + " não é multiplo de 3 mas é multiplo de 7");
            } else
            {
                Console.WriteLine("O número " + n + " não é multiplo de 3 nem de 7");
            }
        }

        #endregion

        #region Exercicio 1.4

        //numero entre 30 e 50

        public static void Exercicio1_4()
        {
            Console.WriteLine("Introduz um número.");
            int num = Convert.ToInt32(Console.ReadLine());
            Entre3050(num);
        }
        private static void Entre3050(int n)
        {
            if (n >= 30 && n <= 50)
            {
                Console.WriteLine(n + " encontra-se entre 30 e 50, inclusive.");
            } else
            {
                Console.WriteLine(n + " não se encontra entre 30 e 50, inclusive.");
            }
        }


        #endregion

        #region exemplo aula

        public static void exemploaula()
        {
            Console.WriteLine("Introduza um valor");
            var val = Console.ReadLine();

            Console.WriteLine("Introduza um caracter");
            var cha = Console.Read();

            Console.WriteLine("Introduza uma tecla");
            var tec = Console.ReadKey();

            Console.WriteLine($"\n Valor {val} \n Caracter {cha} \n Tecla {tec}");

        }


        #endregion

        #region Exercício 1.5

        // solicitar numero e verificar se este se encontra entre 10 e 20, exclusive


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

        public static int LereConverter()
        {
            Console.WriteLine("Numero?");
            var num = Console.ReadLine();
            var numParsed = ConvertNum(num);
            return numParsed;
        }


        public static void Exercicio1_5()
        {
            var n = LereConverter();
            Entre1020(n);
        }

        private static void Entre1020(int a)
        {
            if (a > 10 && a < 20)
            {
                Console.WriteLine(a + " encontra-se entre 10 e 20, exclusive.");
            }
            else
            {
                Console.WriteLine(a + " não se encontra entre 10 e 20, exclusive.");
            }

        }

        #endregion

        #region Exercício 1.6

        public static void Exercicio1_6()
        {
            Console.WriteLine("Para que piso?");
            int piso = Convert.ToInt32(Console.ReadLine());
            Elevador(piso);
        }

        private static void Elevador(int p)
        {
            switch (p)
            {
                case -2:
                    Console.WriteLine("Piso -2");
                    break;

                case -1:
                    Console.WriteLine("Piso -1");
                    break;
                case 0:
                    Console.WriteLine("Piso 0");
                    break;
                case 1:
                    Console.WriteLine("Piso 1");
                    break;
                case 2:
                    Console.WriteLine("Piso 2");
                    break;
                case 3:
                    Console.WriteLine("Piso indisponível");
                    break;
                case 4:
                    Console.WriteLine("Piso 4");
                    break;
                case 5:
                    Console.WriteLine("Piso indisponível");
                    break;
                case 6:
                    Console.WriteLine("Piso 6");
                    break;
                default:
                    Console.WriteLine("Piso indisponível");
                    break;

            }


        }

        #endregion

        #region Exercicio 1.7
        // solicitar 10 numeros e apresentar a sua soma - uma resposta para cada estrutura de repetição
        #region Repetição término

        public static void Exercicio1_7_a()
        { 
            int j = 0;
            int b = 0;

            do
            {
                Console.WriteLine("Introduza um número.");
                int a = Convert.ToInt32(Console.ReadLine());
                b += a;
                j++;
            }
            while (j < 10);
            { 
                Console.WriteLine(b);
                
            }
        }

        #endregion

        #region Repetição continuação

        public static void Exercicio1_7_b()
        {
            int j = 0;
            int b = 0;
    
            while (j < 10)
            {
                Console.WriteLine("Introduza um número");
                int a = Convert.ToInt32(Console.ReadLine());
                
                b += a;
                j++;
            }
            Console.WriteLine(b);
        }

        #endregion

        #region Repetição intervalo

        public static void Exercicio1_7_c()
        {
            int b = 0;
            int i;

            for (i = 0;i < 10; i++)
            {
                Console.WriteLine("Introduza um número.");
                int a = Convert.ToInt32(Console.ReadLine());
                b = b + a;
            }
            Console.WriteLine(b);
        }

        #endregion


        #endregion

        #region Exercicio 1.8
        //Solicitar o nome, preço e quantidade de cinco produtos
        //Apresentar o valor total de cada produto e total da compra

        public static void Exercicio1_8()
        {
            double count = 0;
            double total = 0;

            do
            {
                Console.WriteLine("Introduz nome do produto.");
                var nome = Console.ReadLine();
                Console.WriteLine("Introduz preço do produto.");
                double preço = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Introduz quantidade do produto.");
                int quantidade = Convert.ToInt32(Console.ReadLine());

                var r = preço * quantidade;
                Console.WriteLine("O total do produto é " + r);
                count++;
                total = total + r;

            }
            while (count < 5);
            {
               Console.WriteLine("O total global é " + total);
            }
        }


        #endregion

        #region Exercicio 1.9
        //Introduzir números até que seja inserido 0

        public static void Exercicio1_9()
        {
            double count = 0;
            double a;
            int j = 0;
            do
            {
                Console.WriteLine("Introduza um número.");
                a = Convert.ToDouble(Console.ReadLine());
                count = count + a;
                j++;
            }
            
            while (a != 0);
            {

            }
            Console.WriteLine("A média é " + (count / (j-1)));
            
        }


        #endregion

        #region Exercicio 1.10
        //solicitar dois números e uma operação
        //apresentar o resultado da operação

        public static void Exercicio1_10()
        {
            Console.WriteLine("Introduza um número.");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduza um segundo número.");
            double b= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduza uma operação.");
            var op = Console.ReadLine();

            switch (op)
            {
                case "+":
                    Console.WriteLine("O resultado é "+ (a+b));
                    break;
                case "-":
                    Console.WriteLine("O resultado é " + (a-b));
                    break;
                case "*":
                    Console.WriteLine("O resultado é " + a * b);
                    break;
                case "/":
                    Console.WriteLine("O resultado é " + a / b);
                    break;
                case "%":
                    Console.WriteLine("O resultado é " + a % b);
                    break;

            }

        }





        #endregion

        #region Exercicio 1.11

        public static void Exercicio1_11(){
            int q;
            Console.WriteLine("Introduz um caracter.");
            char a = Convert.ToChar(Console.ReadLine());
            for (q = 0; q < 3; q++) {Console.WriteLine(a + " " + a + " " + a);}
        }
        #endregion

        #region Exercicio 1.12
        public static void Exercicio1_12()
        {
            Console.WriteLine("Introduza um caracter");
            char a = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Introduza um número.");
            int n = Convert.ToInt32(Console.ReadLine());

            CriarMatriz(a, n);

        }

        private static void CriarMatriz(char letra, int num)
        {
            int i;
            int j;

            for (i = 0; i < num; i++)
            {
                for (j = 0; j < num; j++)
                {
                    Console.Write(letra+" ");
                }
                Console.WriteLine("\n");
            }

        }


        #endregion

        #region Exercicio 1.13

        public static void Exercicio1_13()
        {
            Console.WriteLine("Introduza um caracter");
            char a = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Introduza um número.");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduza um número.");
            int m = Convert.ToInt32(Console.ReadLine());

            CriarMatriz2(a, n, m);
        }

        private static void CriarMatriz2(char letra, int num1, int num2)
        {
            int i;
            int j;

            for (i = 0; i < num2; i++)
            {
                for (j = 0; j < num1; j++)
                {
                    Console.Write(letra + " ");
                }
                Console.WriteLine("\n");
            }
        }



        #endregion

        #region Exercicio 2.1

        public static void Exercicio2_1()
        {

            
            Console.WriteLine("Introduz a temperatura.");
            double temp = Convert.ToDouble(Console.ReadLine());
            var escala = "";

            while (escala != "C" && escala != "K" && escala != "F")
            {
                Console.WriteLine("Em que escala? C, K ou F");
                escala = Console.ReadLine();

            }
            switch (escala)
            {
                case "C":
                    Console.WriteLine(temp + "ºC é equivalente a " + (temp + 273.15) + " ºK e " + (temp * (9 / 5) + 32) + "ºF");
                    break;
                case "F":
                    Console.WriteLine(temp + "ºF é equivalente a " + ((temp - 32) * (5 / 9)) + " ºC e " + (temp + 459.67) * (5 / 9) + "ºK");
                    break;
                case "K":
                    Console.WriteLine(temp + "ºK é equivalente a " + (temp - 273.15) + " ºC e " + (temp * (9 / 5) - 459.67) + "ºF");
                    break;
            }

        }




        #endregion

        #region Exercicio 2.2

        public static void Exercicio2_2()
        {
            Console.WriteLine("Qual é o limite?");
            int num = Convert.ToInt32(Console.ReadLine());
            int count;
            for (count = 0; count < num; count++)
            {
                if (count % 2 == 1)
                {
                    Console.WriteLine(count);
                }
            }
        }

        #endregion

        #region Exercicio 2.3

        public static void Exercicio2_3()
        {
            string caracteres = "";
            string caracter = "";

            do
            {
                Console.WriteLine("Introduz um número, ou enter para terminar");
                string c = Console.ReadLine();
                caracter = c;
                caracteres = caracteres + caracter;
            }
            while (caracter != "");
            {
                Console.WriteLine(caracteres);
            }
        }


        #endregion

        #region Exercicio 3.1

        public static void Exercicio3_1()
        {
            Console.WriteLine("Introduz um número.");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine(n*3);
            }
            else
            {
                Console.WriteLine(n * 2);
            }
        }

        #endregion

        #region Exercicio 3.2

        public static void Exercicio3_2()
        {
            Console.WriteLine("Qual a dimensão do triangulo?");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;

            while (n > 0)
            {
                n--;
                int a = 0;
                while (a != n)
                {
                    Console.Write(" ");
                    a++;
                }
                int b = 0;
                while (b != i)
                {
                    Console.Write("*");
                    b++;
                }
                i += 2;
                Console.Write("\n");
            }
        }

        #endregion


















    }
}

