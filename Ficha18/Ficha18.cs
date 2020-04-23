using System;

namespace Ficha18
{
    public class Ficha18
    {

        //Datas

        #region exercicio 1

        public static void exercicio1()
        {
            //Contar o número de anos bissextos entre dois anos (valor inteiro). Procurar por IsLeapYear
            Console.WriteLine("Primeiro ano?");
            var ano1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Segundo ano?");
            var ano2 = Convert.ToInt32( Console.ReadLine());
            AnoBissexto(ano1, ano2);

        }
        public static void AnoBissexto(int data1, int data2)
        {
            var countAnoBissexto = 0;
            for(var i = data1; i <= data2; i++)
            {
                if (DateTime.IsLeapYear(i))
                {
                    countAnoBissexto++;

                }
            }
            Console.WriteLine(countAnoBissexto);
        }

        #endregion

        #region exercicio 2
        //Solicitar um dia, um mês e um ano, e apresentar o dia da semana. Se a data não for válida, deve
        //ser apresentado uma mensagem de erro.

        public static void exercicio2()
        {
            Console.WriteLine("Dia?");
            var dia = Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Mês?");
            var mes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ano?");
            var ano = Convert.ToInt32(Console.ReadLine());

            DateTime data = new DateTime(ano, mes, dia);
            Console.WriteLine($"Este dia é {data.DayOfWeek}");
        }


        #endregion

        #region exercicio 3

        public static void exercicio3()
        {
            //Com base na data atual, apresentar o nome do mês
            var mes = DateTime.Now.Month;
            switch (mes)
            {
                case 1:
                    Console.WriteLine("Janeiro");
                    break;
                case 2:
                    Console.WriteLine("Fevereiro");
                    break;
                case 3:
                    Console.WriteLine("Março");
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    break;
                case 5:
                    Console.WriteLine("Maio");
                    break;
                case 6:
                    Console.WriteLine("Junho");
                    break;
                case 7:
                    Console.WriteLine("Julho");
                    break;
                case 8:
                    Console.WriteLine("Agosto");
                    break;
                case 9:
                    Console.WriteLine("Setembro");
                    break;
                case 10:
                    Console.WriteLine("Outubro");
                    break;
                case 11:
                    Console.WriteLine("Novembro");
                    break;
                case 12:
                    Console.WriteLine("Dezembro");
                    break;
            }

        }

        #endregion

    }
}
