using System;

namespace Ficha15
{
    public class Ficha15

    {
        #region Exercicio 1

        public static void exercicio1()
        {
           
            int[] array = new int[10];
            
            for (int i = 0; i < 10; i++)
            {
                Console.Clear();
                Console.WriteLine("Número?");
                var a = Convert.ToInt32(Console.ReadLine());
                array[i] = a;
                
            }
            Console.Clear();
            for (int j = 0; j < 10; j++)
            {
                
                Console.WriteLine(array[j]);
            }
            
        }


        #endregion

        #region exercicio 2

        public static void exercicio2()
        {

            int[] array = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Clear();
                Console.WriteLine("Número?");
                var a = Convert.ToInt32(Console.ReadLine());
                array[i] = a;

            }
            Console.Clear();
            for (int j = 9; j > -1; j--)
            {

                Console.WriteLine(array[j]);
            }

        }

        #endregion

        #region exercicio 3

        public static void exercicio3()
        {

            int[] array = new int[10];
            var sum = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Clear();
                Console.WriteLine("Número?");
                var a = Convert.ToInt32(Console.ReadLine());
                array[i] = a;
                sum = sum + a;

            }
            Console.Clear();
            Console.WriteLine(sum);

        }

        #endregion

        #region exercicio 4

        public static void exercicio4()
        {

            int[] array = new int[10];
            int[] array2 = new int[12];

            for (int i = 0; i < 10; i++)
            {
                Console.Clear();
                Console.WriteLine("Número?");
                var a = Convert.ToInt32(Console.ReadLine());
                array[i] = a;

            }
            Console.Clear();

            for (int j=0; j < 10; j++)
            {
                array2[j] = array[j];
            }

            for(int h = 0; h < 12; h++)
            {
                Console.WriteLine(array2[h]);
            }
        }

        #endregion

        #region exercicio 5

        public static void exercicio5()
        {
            Console.WriteLine("Quantas posições?");
            int n=Convert.ToInt32( Console.ReadLine());
            var count = 0;
            int[] array = new int[n];



            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                if (array[i] != 0) { count = count + 1; }
            }
            Console.Clear();
            
            Console.WriteLine("Este array tem " + count + " elementos.");
        }

        #endregion

        #region exercicio 6

        public static void exercicio6()
        {
            
            //criaçao de array
            Console.WriteLine("Número de posições do vetor?");
            var n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Clear();
                Console.WriteLine("Número?");
                var a = Convert.ToInt32(Console.ReadLine());
                array[i] = a;

            }
            Console.Clear();


            //contagem de elementos repetidos
            
            int[] array2 = new int[array.Length];
            var count = 0;

            for ( var j = 0; j < array.Length; j++)
            {
                for(var h = j + 1; h < array.Length; h++)
                {
                    if (array[j] == array[h])
                    {
                        array2[count] = array[h];
                        count++;
                        break;
                    }
                    
                }
            }
            
            Console.WriteLine(count);

        }



        #endregion

        #region exercicio 7

        public static void exercicio7()
        {
            int[] array = new int[] { 1, 2, 1, 2, 3, 4 };

            NumerosUnicos(array);

        }
        public static void NumerosUnicos(int[] array)
        {
            var repeated = new int[array.Length];
            var repeatedIndex = 0;

            //elementos repetidos

            for (var i =0; i < array.Length; i++)
            {
                for(var j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        repeated[repeatedIndex] = array[i];
                        repeatedIndex++;
                        break;
                    }

                }
            }

            //elementos únicos

            var unique = new int[array.Length];
            var uniqueIndex = 0;

            for(var i =0; i < array.Length; i++)
            {
                var same = false;
                for(var j = 0; j < repeatedIndex; j++)
                {
                    if (array[i] == repeated[j])
                    {
                        same = true;
                        break;
                    }
                }
                if (!same)
                {
                    unique[uniqueIndex] = array[i];
                    uniqueIndex++;
                }
            }
            for(var i=0; i < uniqueIndex; i++)
            {
                Console.WriteLine(unique[i]);
            }
        }

        #endregion

        #region exercicio 8

        //Criar um algoritmo que organize os elementos de um array



        #endregion

    }
}
