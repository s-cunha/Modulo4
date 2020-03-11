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

        }


        #endregion



    }
}

