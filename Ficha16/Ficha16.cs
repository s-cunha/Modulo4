using System;
using System.Collections.Generic;

namespace Ficha16
{
    public class Ficha16
    {
        //Listas

        #region exercicio 1
            /// <summary>
            /// Solicitar 10 valores e armazená-los numa lista.
            /// No final deverão ser listados todos os elementos.
            /// </summary>
        public static void exercicio1()
        {
            List<int> numbers = new List<int>();
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Número?");
                var n = Convert.ToInt32(Console.ReadLine());
                numbers.Add(n);
                Console.Clear();
            }
            for(int i = 0; i < numbers.Count; i++)
            {
                
                Console.WriteLine(numbers[i]);
            }
            

        }


        #endregion

        #region exercicio 2
        ///Solicitar 10 valores e armazená-los numa lista
        ///No final, deverão ser listados, por ordem inversa
        
        public static void exercicio2()
        {
            List<int> num2 = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Número?");
                var n = Convert.ToInt32(Console.ReadLine());
                num2.Add(n);
                Console.Clear();
            }
            for(int i= (num2.Count-1); i >= 0; i--)
            {
                Console.WriteLine(num2[i]);
            }
        }


        #endregion

        #region exercicio3

        ///Solicitar 10 numeros e armazená-los numa lista
        ///Apresentar a soma dos 10 números
        
        public static void exercicio3()
        {
            List<int> numeros = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Número?");
                var n = Convert.ToInt32(Console.ReadLine());
                numeros.Add(n);
                Console.Clear();
            }
            var count = 0;
            for (int i = 0; i < numeros.Count; i++)
            {
                
                var a = numeros[i];
                count = count + a;

            }
            Console.WriteLine(count);
        }

        #endregion

        #region exercicio4

        ///Criar um algoritmo que apresente a contagem de todos os elementos repetidos numa lista
        ///
        public static void exercicio4()
        {
            List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 2, 3 ,5};

            var count = 0;

            for(var i = 0; i < numeros.Count; i++)
            {
                for(var j = i + 1; j < numeros.Count; j++)
                {
                    if (numeros[i] == numeros[j])
                    {
                        count++;
                        break;
                    }
                }
            }
            Console.WriteLine(count);

        }

        #endregion

        #region exercicio 5

        ///Criar um algoritmo que apresente todos os elementos únicos numa lista.
        ///
        public static void exercicio5()
        {
            List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 2, 3, 5 };
            NumerosUnicos(numeros);

             static void NumerosUnicos(List<int> nums)
            {
                var repeated = new int[nums.Count];
                var repeatedIndex = 0;

                //elementos repetidos

                for (var i = 0; i < nums.Count; i++)
                {
                    for (var j = i + 1; j < nums.Count; j++)
                    {
                        if (nums[i] == nums[j])
                        {
                            repeated[repeatedIndex] = nums[i];
                            repeatedIndex++;
                            break;
                        }

                    }
                }

                //elementos únicos

                //var unique = new int[nums.Count];
                List<int> unique = new List<int>() { };
                var uniqueIndex = 0;

                for (var i = 0; i < nums.Count; i++)
                {
                    var same = false;
                    for (var j = 0; j < repeatedIndex; j++)
                    {
                        if (nums[i] == repeated[j])
                        {
                            same = true;
                            break;
                        }
                    }
                    if (!same)
                    {
                        unique.Add(nums[i]);
                        uniqueIndex++;
                    }
                }
                for (var i = 0; i < uniqueIndex; i++)
                {
                    Console.WriteLine(unique[i]);
                }
            }

            //List<int> repetidos = new List<int>() {};
            //var indexRepetidos = 0;

            //for (var i = 0; i < numeros.Count; i++)
            //{
            //    for (var j = i + 1; j < numeros.Count; j++)
            //    {
            //        if (numeros[i] == numeros[j])
            //        {
            //            repetidos.Add(numeros[i]);
            //            indexRepetidos++;
            //            break;
            //        }
            //    }
            //}


            //List<int> unicos = new List<int>() { };
            //var count = 0;

            //for (var i = 0; i < numeros.Count; i++)
            //{
            //    var same = false;

            //    for (var j = i + 1; j < indexRepetidos; j++)
            //    {
            //        if (numeros[i] == repetidos[j])
            //        {
            //            same = true;

            //            break;
            //        }
            //    }
            //    if (!same)
            //    {
            //        unicos.Add(numeros[i]);
            //        count++;
            //    }
            //}
            //for(var i = 0; i < count; i++)
            //{ 
            //    Console.WriteLine(unicos[i]);
            //}
            //Console.WriteLine();
            //for (var i = 0; i < indexRepetidos; i++)
            //{
            //    Console.WriteLine(repetidos[i]);
            //}

        }

        #endregion

        #region exercicio 6
        //Criar um algoritmo para encontrar o menor e o maior valor numa lista.

        public static void exercicio6()
        {
            List<int> numeros = new List<int>() { 8, 7, 34, 2, 5, 90, 6 };
            MaximoEMinimo(numeros);
        }
        public static void MaximoEMinimo(List<int> num)
        {
            int minimo=100;
            int maximo=0;

            for(var i = 0; i < num.Count; i++)
            {
                if (num[i] <= minimo)
                {
                    minimo = num[i];
                }
            }
            for (var i = 0; i < num.Count; i++)
            {
                if (num[i] >= maximo)
                {
                    maximo = num[i];
                }
            }

            Console.WriteLine($"O maximo é {maximo} e o minimo é {minimo}");
        }


        #endregion
    }
}
