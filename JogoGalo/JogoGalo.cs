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

        public static void Jogadas()
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
                if (count % 2 != 0) {
                    switch (n)
                    { case "1":
                            n1 = "X";
                            Console.Clear();
                            ImagemJogoGalo(n1, n2, n3, n4, n5, n6, n7, n8, n9);
                            break;
                        case "2":
                            n2 = "X";
                            Console.Clear();
                            ImagemJogoGalo(n1, n2, n3, n4, n5, n6, n7, n8, n9);
                            break;
                        case "3":
                            n3 = "X";
                            Console.Clear();
                            ImagemJogoGalo(n1, n2, n3, n4, n5, n6, n7, n8, n9);
                            break;
                        case "4":
                            n4 = "X";
                            Console.Clear();
                            ImagemJogoGalo(n1, n2, n3, n4, n5, n6, n7, n8, n9);
                            break;
                        case "5":
                            n5 = "X";
                            Console.Clear();
                            ImagemJogoGalo(n1, n2, n3, n4, n5, n6, n7, n8, n9);
                            break;
                        case "6":
                            n6 = "X";
                            Console.Clear();
                            ImagemJogoGalo(n1, n2, n3, n4, n5, n6, n7, n8, n9);
                            break;
                        case "7":
                            n7 = "X";
                            Console.Clear();
                            ImagemJogoGalo(n1, n2, n3, n4, n5, n6, n7, n8, n9);
                            break;
                        case "8":
                            n8 = "X";
                            Console.Clear();
                            ImagemJogoGalo(n1, n2, n3, n4, n5, n6, n7, n8, n9);
                            break;
                        case "9":
                            n9 = "X";
                            Console.Clear();
                            ImagemJogoGalo(n1, n2, n3, n4, n5, n6, n7, n8, n9);
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
                            n1 = "O";
                            Console.Clear();
                            ImagemJogoGalo(n1, n2, n3, n4, n5, n6, n7, n8, n9);
                            break;
                        case "2":
                            n2 = "O";
                            Console.Clear();
                            ImagemJogoGalo(n1, n2, n3, n4, n5, n6, n7, n8, n9);
                            break;
                        case "3":
                            n3 = "O";
                            Console.Clear();
                            ImagemJogoGalo(n1, n2, n3, n4, n5, n6, n7, n8, n9);
                            break;
                        case "4":
                            n4 = "O";
                            Console.Clear();
                            ImagemJogoGalo(n1, n2, n3, n4, n5, n6, n7, n8, n9);
                            break;
                        case "5":
                            n5 = "O";
                            Console.Clear();
                            ImagemJogoGalo(n1, n2, n3, n4, n5, n6, n7, n8, n9);
                            break;
                        case "6":
                            n6 = "O";
                            Console.Clear();
                            ImagemJogoGalo(n1, n2, n3, n4, n5, n6, n7, n8, n9);
                            break;
                        case "7":
                            n7 = "O";
                            Console.Clear();
                            ImagemJogoGalo(n1, n2, n3, n4, n5, n6, n7, n8, n9);
                            break;
                        case "8":
                            n8 = "O";
                            Console.Clear();
                            ImagemJogoGalo(n1, n2, n3, n4, n5, n6, n7, n8, n9);
                            break;
                        case "9":
                            n9 = "O";
                            Console.Clear();
                            ImagemJogoGalo(n1, n2, n3, n4, n5, n6, n7, n8, n9);
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
