using System;
using System.Collections.Generic;
//using static Ficha21.ExtensionMethod1;


namespace Ficha21
{
    public static class Ficha21
    {
        #region exercicio1
        //Cria um método de extensão para somar todos os valores de um array de inteiros
        public static void exercicio1()
        {
            int[] array = { 1, 2, 3, 4, 2, 3, 6 };
            Console.WriteLine(array.SomaArray());
        }
        #endregion
        #region exercicio2
        //Cria um método de extensão que verifica se um valor está entre dois valores

        public static void exercicio2()
        {
            int n = 3;
            int a = 4;
            int b = 7;
            int c = 2;

            n.EntreDoisValores(a, b);
            n.EntreDoisValores(c, b);
        }
        #endregion
        #region exercicio 3
        //Cria um método de extensão que retorna o nome do mês de uma data

        public static void exercicio3()
        {
            Console.WriteLine("Qual a data? AAAA MM DD");
            var data = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(data.RetornaDiaSemana());
        }
        #endregion
        #region exercicio 4
        //Cria um método de extensão que retorna o nome do dia da semana de uma data

        public static DayOfWeek RetornaDiaSemana(this DateTime date)
        {
            var dayName = date.DayOfWeek;
            return dayName;
        }
        public static void exercicio4()
        {
            Console.WriteLine("Qual a data? AAAA MM DD");
            var data = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(data.RetornaDiaSemana());
        }
        #endregion

        #region exercicio 5
        //Cria um método de extensão verifica se um caracter é vogal

        public static bool SeEVogal(this char a)
        {
            if (a == 'a'){ return true;}
            if (a == 'e') { return true; }
            if (a == 'i') { return true; }
            if (a == 'o') { return true; }
            if (a == 'u') { return true; }
            else { return false; }
        }
        public static void exercicio5()
        {
            Console.WriteLine("Letra?");
            char a = Convert.ToChar(Console.ReadLine());
            if (a.SeEVogal() == true) { Console.WriteLine("é vogal"); }
            else { Console.WriteLine("não é vogal"); }
        }

        #endregion
        #region exercicio 6
        //Cria um método de extensão verifica se um caracter é consoante
        public static bool SeEConsoante(this char a)
        {
            if (a == 'a') { return false; }
            if (a == 'e') { return false; }
            if (a == 'i') { return false; }
            if (a == 'o') { return false; }
            if (a == 'u') { return false; }
            else { return true; }
        }
        public static void exercicio6()
        {
            Console.WriteLine("Letra?");
            char a = Convert.ToChar(Console.ReadLine());
            if (a.SeEConsoante() == true) { Console.WriteLine("é consoante"); }
            else { Console.WriteLine("não é consoante"); }
        }
        #endregion
        #region exercicio 7
        //Cria um método de extensão que retorna as vogais de uma string
        public static List<char> RetornaVogais(this string palavra)
        {
            List<char> vogais = new List<char>();
            foreach(char a in palavra)
            {
                bool b = a.SeEVogal();
                if (b == true) { vogais.Add(a); }
            }
            return vogais;
        }
        public static void exercicio7()
        {
            Console.WriteLine("Palavra?");
            string palavra = Console.ReadLine();
            var lista = palavra.RetornaVogais();
            for (var i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }
            
        }
        #endregion
        #region exercicio 8 
        //Cria um método de extensão que retorna as consoantes de uma string
        public static List<char> RetornaConsoantes(this string palavra)
        {
            List<char> consoantes = new List<char>();
            foreach (char a in palavra)
            {
                bool b = a.SeEConsoante();
                if (b == true) { consoantes.Add(a); }
            }
            return consoantes;
        }
        public static void exercicio8()
        {
            Console.WriteLine("Palavra?");
            string palavra = Console.ReadLine();
            var lista = palavra.RetornaConsoantes();
            for (var i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }

        }
        #endregion

        #region exercicio 9
        //Cria um método de extensão que retorna os números de uma string 
        //(atenção aos números com mais que um caracter)

        public static List<int> RetornaInt(this string frase)
        {
            List<int> lista = new List<int>();
            string[] palavras = frase.Split(" ");
                foreach (string a in palavras)
                {
                    bool numOuNao = int.TryParse(a, out int numero);
                    if (numOuNao)
                    {
                    lista.Add(numero);
                    }
                }
            return lista;
        }
        public static void exercicio9()
        {
            string frase = "Eram 120 lobos a correr 3 metros de 43";
            List<int> lista = frase.RetornaInt();
            foreach(int n in lista)
            {
                Console.WriteLine(n);
            }
        }


        #endregion
    }
}
