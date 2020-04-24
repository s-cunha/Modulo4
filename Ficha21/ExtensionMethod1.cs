using System;
using System.Collections.Generic;
using System.Text;

namespace Ficha21
{
    public static class ExtensionMethod1
    {
        public static int UmaExtensao(this string arg)
        {
            return arg.Length;
            
        }

        public static int SomaArray(this int[] array1)
        {
            var count = 0;
            for(var i = 0; i < array1.Length; i++)
            {
                count = count + array1[i];
            }
            return count;
        }

        public static void EntreDoisValores(this int n,int a,int b)
        {
            if (a < n&&n<b) { Console.WriteLine("Está dentro dos dois valores"); }
            else { Console.WriteLine("Está fora dos dois valores"); }
        }


        public static string RetornaMes(this DateTime date)
        {
            //Com base na data atual, apresentar o nome do mês
            var mes = date.Month;
            switch (mes)
            {
                case 1:
                    return "Janeiro";
                    
                case 2:
                    return "Fevereiro";
                    
                case 3:
                    return "Março";
                    
                case 4:
                    return "Abril";
                    
                case 5:
                    return "Maio";
                    
                case 6:
                    return "Junho";
                   
                case 7:
                    return "Julho";
                  
                case 8:
                    return "Agosto";
                    
                case 9:
                    return "Setembro";
                   
                case 10:
                    return "Outubro";
               
                case 11:
                    return "Novembro";
                   
                case 12:
                    return "Dezembro";
                default:
                    return "Inválido";
            }

        }
    }
}
