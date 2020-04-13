using System;

namespace JogoGalo
{
    public class JogoGalo
    {

        public static void ImagemJogoGalo(string a, string b, string c, string d, string e, string f, string g, string h, string i)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("                   ");
            Console.Write("   " + a + " ");
            Console.Write(" | ");
            Console.Write(" " + b + " ");
            Console.Write(" | ");
            Console.WriteLine(" " + c + "   ");

            Console.WriteLine("   _____________   ");
            Console.WriteLine("                   ");

            Console.Write("   " + d + " ");
            Console.Write(" | ");
            Console.Write(" " + e + " ");
            Console.Write(" | ");
            Console.WriteLine(" " + f + "   ");

            Console.WriteLine("   _____________   ");
            Console.WriteLine("                   ");

            Console.Write("   " + g + " ");
            Console.Write(" | ");
            Console.Write(" " + h + " ");
            Console.Write(" | ");
            Console.WriteLine(" " + i + "   ");

            Console.WriteLine("                   ");

            Console.ResetColor();
            Console.WriteLine("Introduza o número correspondente à sua escolha.");
        }

        public static void StartJogoGalo()
        {
            var n1 = "1";
            var n2 = "2";
            var n3 = "3";
            var n4 = "4";
            var n5 = "5";
            var n6 = "6";
            var n7 = "7";
            var n8 = "8";
            var n9 = "9";
            ImagemJogoGalo(n1, n2, n3, n4, n5, n6, n7, n8, n9);

            int count = 1;
            for (count = 1; count < 10; count++)
            {
                var n = Console.ReadLine();
                
                
                    if (count % 2 != 0)
                    {
                        switch (n)
                        {
                            case "1":

                            if (n1 != "X" && n1 != "O") { n1 = "X"; }
                            else { count = count - 1; }
                            Console.Clear();
                                ImagemJogoGalo(n1, n2, n3, n4, n5, n6, n7, n8, n9);
                                if (n1 == n2 && n2 == n3 || n1 == n4 && n4 == n7 || n1 == n5 && n1 == n9)
                                {
                                    Console.WriteLine("O X ganhou!");
                                    return;
                                }
                                break;
                            case "2":
                            if (n2 != "X" && n2 != "O") { n2 = "X"; }
                            else { count = count - 1; }
                            Console.Clear();
                                ImagemJogoGalo(n1, n2, n3, n4, n5, n6, n7, n8, n9);
                                if (n2 == n1 && n2 == n3 || n2 == n5 && n5 == n8)
                                {
                                    Console.WriteLine("O X ganhou!");
                                    return;
                                }
                                break;
                            case "3":
                            if (n3 != "X" && n3 != "O") { n3 = "X"; }
                            else { count = count - 1; }
                            Console.Clear();
                                ImagemJogoGalo(n1, n2, n3, n4, n5, n6, n7, n8, n9);
                                if (n3 == n2 && n2 == n1 || n3 == n6 && n6 == n9 || n3 == n5 && n5 == n7)
                                {
                                    Console.WriteLine("O X ganhou!");
                                    return;
                                }
                                break;
                            case "4":
                            if (n4 != "X" && n4 != "O") { n4 = "X"; }
                            else { count = count - 1; }
                            Console.Clear();
                                ImagemJogoGalo(n1, n2, n3, n4, n5, n6, n7, n8, n9);
                                if (n4 == n1 && n4 == n7 || n4 == n5 && n5 == n6)
                                {
                                    Console.WriteLine("O X ganhou!");
                                    return;
                                }
                                break;
                            case "5":
                            if (n5 != "X" && n5 != "O") { n5 = "X"; }
                            else { count = count - 1; }
                            Console.Clear();
                                ImagemJogoGalo(n1, n2, n3, n4, n5, n6, n7, n8, n9);
                                if (n1 == n5 && n5 == n9 || n2 == n5 && n5 == n8 || n3 == n5 && n5 == n7 || n4 == n5 && n5 == n6)
                                {
                                    Console.WriteLine("O X ganhou!");
                                    return;
                                }
                                break;
                            case "6":
                            if (n6 != "X" && n6 != "O") { n6 = "X"; }
                            else { count = count - 1; }
                            Console.Clear();
                                ImagemJogoGalo(n1, n2, n3, n4, n5, n6, n7, n8, n9);
                                if (n3 == n6 && n6 == n9 || n6 == n5 && n5 == n4)
                                {
                                    Console.WriteLine("O X ganhou!");
                                    return;
                                }
                                break;
                            case "7":
                            if (n7 != "X" && n7 != "O") { n7 = "X"; }
                            else { count = count - 1; }
                            Console.Clear();
                                ImagemJogoGalo(n1, n2, n3, n4, n5, n6, n7, n8, n9);
                                if (n7 == n4 && n4 == n1 || n7 == n8 && n8 == n9|| n7==n5 && n5==n3 )
                                {
                                    Console.WriteLine("O X ganhou!");
                                    return;
                                }
                                break;
                            case "8":
                            if (n8 != "X" && n8 != "O") { n8 = "X"; }
                            else { count = count - 1; }
                            Console.Clear();
                                ImagemJogoGalo(n1, n2, n3, n4, n5, n6, n7, n8, n9);
                                if (n8 == n5 && n5 == n2 || n7 == n8 && n8 == n9)
                                {
                                    Console.WriteLine("O X ganhou!");
                                    return;
                                }
                                break;
                            case "9":
                            if (n9 != "X" && n9 != "O") { n9 = "X"; }
                            else { count = count - 1; }
                            Console.Clear();
                                ImagemJogoGalo(n1, n2, n3, n4, n5, n6, n7, n8, n9);
                                if (n9 == n6 && n6 == n3 || n9 == n8 && n8 == n7)
                                {
                                    Console.WriteLine("O X ganhou!");
                                    return;
                                }
                                break;

                            default:
                                Console.Clear();
                                ImagemJogoGalo(n1, n2, n3, n4, n5, n6, n7, n8, n9);
                                Console.WriteLine("Por favor, escolha um número válido.");
                                break;


                        }

                    }
                    else
                    {
                        switch (n)
                        {
                            case "1":
                            if (n1 != "X" && n1 != "O") { n1 = "O"; }
                            else { count = count - 1; }
                            Console.Clear();
                                ImagemJogoGalo(n1, n2, n3, n4, n5, n6, n7, n8, n9);
                                if (n1 == n2 && n2 == n3 || n1 == n4 && n4 == n7 || n1 == n5 && n1 == n9)
                                {
                                    Console.WriteLine("O O ganhou!");
                                    return;
                                }
                                break;
                            case "2":
                            if (n2 != "X" && n2 != "O") { n2 = "O"; }
                            else { count = count - 1; }
                            Console.Clear();
                                ImagemJogoGalo(n1, n2, n3, n4, n5, n6, n7, n8, n9);
                                if (n1 == n2 && n2 == n3 || n2 == n5 && n5 == n8)
                                {
                                    Console.WriteLine("O O ganhou!");
                                    return;
                                }
                                break;
                            case "3":
                            if (n3 != "X" && n3 != "O") { n3 = "O"; }
                            else { count = count - 1; }
                            Console.Clear();
                                ImagemJogoGalo(n1, n2, n3, n4, n5, n6, n7, n8, n9);
                                if (n1 == n2 && n2 == n3 || n3 == n6 && n6 == n9 || n3 == n5 && n5 == n7)
                                {
                                    Console.WriteLine("O O ganhou!");
                                    return;
                                }
                                break;
                            case "4":
                            if (n4 != "X" && n4 != "O") { n4 = "O"; }
                            else { count = count - 1; }
                            Console.Clear();
                                ImagemJogoGalo(n1, n2, n3, n4, n5, n6, n7, n8, n9);
                                if (n1 == n4 && n4 == n7 || n4 == n5 && n5 == n6)
                                {
                                    Console.WriteLine("O O ganhou!");
                                    return;
                                }
                                break;
                            case "5":
                            if (n5 != "X" && n5 != "O") { n5 = "O"; }
                            else { count = count - 1; }
                            Console.Clear();
                                ImagemJogoGalo(n1, n2, n3, n4, n5, n6, n7, n8, n9);
                                if (n1 == n5 && n5 == n9 || n2 == n5 && n5 == n8 || n3 == n5 && n5 == n7 || n4 == n5 && n5 == n6)
                                {
                                    Console.WriteLine("O O ganhou!");
                                    return;
                                }
                                break;
                            case "6":
                            if (n6 != "X" && n6 != "O") { n6 = "O"; }
                            else { count = count - 1; }
                            Console.Clear();
                                ImagemJogoGalo(n1, n2, n3, n4, n5, n6, n7, n8, n9);
                                if (n3 == n6 && n6 == n9 || n6 == n5 && n5 == n4)
                                {
                                    Console.WriteLine("O O ganhou!");
                                    return;
                                }
                                break;
                            case "7":
                            if (n7 != "X" && n7 != "O") { n7 = "O"; }
                            else { count = count - 1; }
                            Console.Clear();
                                ImagemJogoGalo(n1, n2, n3, n4, n5, n6, n7, n8, n9);
                                if (n7 == n4 && n4 == n1 || n7 == n8 && n8 == n9||n7==n5&&n5==n3)
                                {
                                    Console.WriteLine("O O ganhou!");
                                    return;
                                }
                                break;
                            case "8":
                            if (n8 != "X" && n8 != "O") { n8 = "O"; }
                            else { count = count - 1; }
                            Console.Clear();
                                ImagemJogoGalo(n1, n2, n3, n4, n5, n6, n7, n8, n9);
                                if (n8 == n5 && n5 == n2 || n7 == n8 && n8 == n9)
                                {
                                    Console.WriteLine("O O ganhou!");
                                    return;
                                }
                                break;
                            case "9":
                            if (n9 != "X" && n9 != "O") { n9 = "O"; }
                            else { count = count - 1; }
                            Console.Clear();
                                ImagemJogoGalo(n1, n2, n3, n4, n5, n6, n7, n8, n9);
                                if (n9 == n6 && n6 == n3 || n9 == n8 && n8 == n7)
                                {
                                    Console.WriteLine("O O ganhou!");
                                    return;
                                }
                                break;
                            default:
                                Console.Clear();
                                ImagemJogoGalo(n1, n2, n3, n4, n5, n6, n7, n8, n9);
                                Console.WriteLine("Por favor, escolha um número válido.");
                                break;

                        }
                    }

                Console.Clear();
                ImagemJogoGalo(n1, n2, n3, n4, n5, n6, n7, n8, n9);
            } 
        }
        
        
        
        
        
        
    }
}
