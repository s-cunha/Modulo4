﻿using System;
using Common;
using static Common.InputRequest;

namespace Ficha9
{
    public class Ficha9
    {

        #region Exercicio 1.1

        public static void Exercicio1_1()
        {
            //solicitar 3 números e apresentar o seu produto
            int i;
            int a=1;
            for (i = 0; i < 3; i++)
            {
                Console.WriteLine("Introduza o número.");
                int num = Convert.ToInt32(Console.ReadLine());
                a = a * num;
                
            }
            Console.WriteLine("O resultado do produto é " + a);
        }
        #endregion

        #region exercicio12.1

        public static void CalcularProdutodeTresNumeros()
        {
            double total = 1.0;
            for (int counter=0; counter < 3; counter++)
            {
                var currentNumber = RequestDouble("Introduza um número.");
                total *= currentNumber;
            }
            Console.WriteLine($"O total é {total}");
        }


        #endregion


        #region Exercicio 1.2

        public static void Exercicio1_2()
        {
            //solicitar 2 numeros e apresentar valores para cada operação aritmetica

            Console.WriteLine("Introduza o primeiro número.");
            double num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduza o segundo número.");
            double num2 = Convert.ToInt32(Console.ReadLine());

            FazOperaçoes(num1, num2, out double soma, out double subtraçao, out double multiplicaçao, out double divisao);

        }

        private static void FazOperaçoes(double n1, double n2, out double soma, out double subtraçao, out double multiplicaçao, out double divisao)
        {
            soma = n1 + n2;
            subtraçao = n1 - n2;
            multiplicaçao = n1 * n2;
            divisao = (n1 / n2);

            Console.WriteLine($"O resultado da soma é {soma} da subtração {subtraçao} da multiplicação {multiplicaçao} e divisão {divisao}");
         
        }

        #endregion

        #region Exercicio 12.2

        public static void ApresentarOperacoesParaDoisNumeros()
        {
            var firstNumber = RequestDouble("Introduza o primeiro número.");
            var secondNumber = RequestDouble("Introduza o segundo número.");

            Console.WriteLine($"{firstNumber}+{secondNumber}={(firstNumber + secondNumber)}");
            Console.WriteLine($"{firstNumber}-{secondNumber}={(firstNumber - secondNumber)}");
            Console.WriteLine($"{firstNumber}*{secondNumber}={(firstNumber * secondNumber)}");
            Console.WriteLine($"{firstNumber}/{secondNumber}={(firstNumber / secondNumber)}");
            Console.WriteLine($"{firstNumber}%{secondNumber}={(firstNumber % secondNumber)}");

        }

        #endregion

        #region Exercicio 1.3

        //Solicitar três números e apresentar o resultado de (x+y).z and x.y + y.z

        public static void Exercicio1_3()
        {
            int i;
            int num1=0;
            int num2=0;
            int num3=0;

            for (i = 0; i < 3; i++)
            {
                
                if (i == 0)
                {
                    Console.WriteLine("Introduz um número.");
                    num1 = Convert.ToInt32(Console.ReadLine());
                }
                else if(i==1) 
                {
                    Console.WriteLine("Introduz um número.");
                    num2 = Convert.ToInt32(Console.ReadLine());
                }
                else if (i==2)
                {
                    Console.WriteLine("Introduz um número.");
                    num3 = Convert.ToInt32(Console.ReadLine());  
                }
            }

            int r1 = (num1 + num2) * num3;
            int r2 = num1 * num2 + num2 * num3;
            Console.WriteLine("O primeiro resultado é " + r1);
            Console.WriteLine("O segundo resultado é " + r2);





        }




        #endregion

        #region 12.4

        public static void ApresentarNumerosPrimos()
        {
            Console.WriteLine("Introduza um número.");
            var num = int.Parse(Console.ReadLine());

            for(var i = 2; i <= num; i++)
            {
                var isPrime = true;
                for ( var j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break; //se determinado numero for falso para aqui, nao volta a ver se é divisivel por outro (ex.6, divisivel por 3 e 2)
                    }
                }

                if (isPrime) Console.WriteLine(i + " ");
            }



        }

        #endregion

        #region Exercicio 1.4
        //Solicitar um número e apresentar todos os números primos até ao indicado.

        public static void Exercicio1_4()
        {
            Console.WriteLine("Qual é o número?");
            var n = Convert.ToInt32(Console.ReadLine());
            var primos = "";
            var isPrime = true;

            for (int i = 2; i < n; i++)
            {
                if (n == 2)
                {
                    primos += n.ToString() + "\n";
                }
                else
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                        }
                    }
                    if (isPrime == true)
                    {
                        primos += i.ToString() + "\n";
                    }
                }
                isPrime = true;
            }
            Console.WriteLine(primos);

        }




        #endregion

        #region Exercicio 1.5

        public static void Exercicio1_5()
        {
            Console.WriteLine("Hello?");
            var resp = Console.ReadLine();
            if (resp == "Is it me you're looking for?") ;
            {
                Console.WriteLine("I can see it in your eyes.");
            }
        }

        #endregion

        #region Exercicio 1.6
        //Solicitar uma quantidade de itens e distribuí-los entre duas pessoas através das expressões “Um pra mim” e “Um pra ti”




        #endregion




        #region Exercicio 1.16

        public static void Exercicio1_6()
        {
            int min = 1;
            int max = 100;
            bool fim = false;
            Console.WriteLine("Pense num número entre 1 e 100");

            while (fim == false)
            {
                var half = (min + max) / 2;

                if (half == (max - 1))
                {
                    Console.WriteLine("É " + half + "?");
                    var resp = Console.ReadLine();
                    if (resp == "S")
                    {
                        fim = true;
                    }
                    else if (resp == "N")
                    {
                        Console.WriteLine("É " + (half + 1) + "?");
                        var resp2 = Console.ReadLine();

                        if (resp2 == "S")
                        {
                            fim = true;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("É maior que " + half + "?");
                    var resp = Console.ReadLine();
                    if (resp == "S")
                    {
                        min = half;
                    }
                    else if (resp == "N")
                    {
                        max = half;
                    }
                    else
                    {
                        Console.WriteLine("Responda S ou N");
                    }


                }


            }

        }

        #endregion


        #region Exercicio 12.16

        public static void Ex16()
        {

            Console.WriteLine("Pense num número.");
            Console.WriteLine("Precione enter para continuar.");
            Console.ReadLine();
            int min = 1;
            int max = 100;
            bool numeroCerto = false;

            while (!numeroCerto)
            {
                Console.WriteLine();
                var avg = (int)(Math.Floor((double)(min + max) / 2)); //cast da divisão
                var intConf = max - min;
                var keyOk = false;

                if (intConf <2) 
                {
                    for(int i = min; i < (max + 1); i++)
                    {
                        Console.WriteLine($"É {i}?");
                        
                        var key = Console.ReadKey().Key;
                        if(key==ConsoleKey.Y || key == ConsoleKey.S)
                        {
                            numeroCerto = true;
                            break;
                        }
                        Console.WriteLine(" ");
                    }
                }
                if (!numeroCerto)
                {
                    while (!keyOk)
                    {
                        Console.WriteLine($"O número é inferior a {avg}?");
                        switch (Console.ReadKey().Key)
                        {
                            case ConsoleKey.Y:
                            case ConsoleKey.S:
                                keyOk = true;
                                max = (avg - 1);
                                break;
                            case ConsoleKey.N:
                                keyOk = true;
                                min = avg;
                                break;
                            default:
                                break;
                        }
                    }
                }
                
            }
        }



        #endregion


    }
}
