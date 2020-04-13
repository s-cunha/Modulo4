using System;

namespace JogoForca
{
    public class JogoForca
    {

        public static void ImagemForca(int a)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("  O Jogo da Forca   ");

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.White;


            if (a == 1)
            {
                Console.WriteLine("                    ");
                Console.WriteLine("     ----------     ");
                Console.WriteLine("     |        |     ");
                Console.WriteLine("     |              ");
                Console.WriteLine("     |              ");
                Console.WriteLine("     |              ");  
                Console.WriteLine("  --------          ");
                Console.ResetColor();
            }

            if (a == 2)
            {
                Console.WriteLine("                    ");
                Console.WriteLine("     ----------     ");
                Console.WriteLine("     |        |     ");
                Console.WriteLine("     |        O     ");
                Console.WriteLine("     |              ");
                Console.WriteLine("     |              ");  
                Console.WriteLine("  --------          ");
                Console.ResetColor();
            }

            if (a == 3)
            {
                Console.WriteLine("                    ");
                Console.WriteLine("     ----------     ");
                Console.WriteLine("     |        |     ");
                Console.WriteLine("     |        O     ");
                Console.WriteLine("     |        |     ");
                Console.WriteLine("     |              ");  
                Console.WriteLine("  --------          ");
                Console.ResetColor();
            }

            if (a == 4)
            {
                Console.WriteLine("                    ");
                Console.WriteLine("     ----------     ");
                Console.WriteLine("     |        |     ");
                Console.WriteLine("     |        O     ");
                Console.WriteLine("     |       /|     ");
                Console.WriteLine("     |              ");
                Console.WriteLine("  --------          ");
                Console.ResetColor();
            }

            if (a == 5)
            {
                Console.WriteLine("                    ");
                Console.WriteLine("     ----------     ");
                Console.WriteLine("     |        |     ");
                Console.WriteLine("     |        O     ");
                Console.WriteLine("     |       /|\\    ");
                Console.WriteLine("     |              ");
                Console.WriteLine("  --------          ");
                Console.ResetColor();
            }

            if (a == 6)
            {
                Console.WriteLine("                    ");
                Console.WriteLine("     ----------     ");
                Console.WriteLine("     |        |     ");
                Console.WriteLine("     |        O     ");
                Console.WriteLine("     |       /|\\    ");
                Console.WriteLine("     |       /      ");
                Console.WriteLine("  --------          ");
                Console.ResetColor();
            }

            if (a == 7)
            {

                Console.WriteLine("                    ");
                Console.WriteLine("     ----------     ");
                Console.WriteLine("     |        |     ");
                Console.WriteLine("     |        O     ");
                Console.WriteLine("     |       /|\\    ");
                Console.WriteLine("     |       / \\    ");
                Console.WriteLine("  --------          ");
                Console.ResetColor();

            }

        }

        public static void StartForca()
        {
            ImagemForca(1);

            int indice = 1;

            var a = "_ ";
            var b = "_ ";
            var c = "_ ";
            var d = "_ ";
            var e = "_ ";
            var f = "_ ";
            var g = "_ ";

            var palavra = "";
            Console.WriteLine("Escolha um número de 1 a 10 para começar.");
            var escolha = Console.ReadLine();

            if (escolha == "1") { palavra = "flor"; }
            if (escolha == "2") { palavra = "caneca"; }
            if (escolha == "3") { palavra = "regador"; }
            if (escolha == "4") { palavra = "livro"; }
            if (escolha == "5") { palavra = "revista"; }
            if (escolha == "6") { palavra = "ferro"; }
            if (escolha == "7") { palavra = "cobalto"; }
            if (escolha == "8") { palavra = "sal"; }
            if (escolha == "9") { palavra = "pimenta"; }
            if (escolha == "10") { palavra = "caneta"; }

            Console.Clear();
            ImagemForca(1);

            for (var i = 0; i < palavra.Length; i++)
            {
                Console.Write("_ ");
            }
            Console.WriteLine("");
            Console.WriteLine("Escolha uma letra.");

            

            switch (palavra)
            {
                case "flor":
                  
                    while (a=="_ "||b=="_ " || c == "_ " || d == "_ ")
                    {
                        
                        Console.Clear();
                        ImagemForca(indice);
                        Console.WriteLine(a + b + c + d);
                        Console.WriteLine("Escolha uma letra.");


                        var letra = Console.ReadLine();

                        

                        if (letra == "f")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            a = "f ";
                            Console.WriteLine(a + b + c + d);
                        }
                        if (letra == "l")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            b = "l ";
                            Console.WriteLine(a + b + c + d);
                        }
                        if (letra == "o")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            c = "o ";
                            Console.WriteLine(a + b + c + d);
                        }
                        if (letra == "r")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            d = "r ";
                            Console.WriteLine(a + b + c + d);
                        }
                        if (letra!="f"&& letra != "l" && letra != "o" && letra != "r")
                        {
                            indice = indice + 1;
                            Console.Clear();
                            ImagemForca(indice);
                            Console.WriteLine("Escolha uma letra.");

                            if (indice >= 7)
                            {
                                Console.Clear();
                                ImagemForca(7);
                                Console.WriteLine("Perdeu.");
                                return;
                            }
                        }
                    }
                    Console.WriteLine("Ganhou!");
                    break;

                case "caneca":

                    while (a == "_ " || b == "_ " || c == "_ " || d == "_ " || e == "_ " || f == "_ ")
                    {
                        Console.Clear();
                        ImagemForca(indice);
                        Console.WriteLine(a + b + c + d + e + f);
                        Console.WriteLine("Escolha uma letra.");


                        var letra = Console.ReadLine();
                        if (letra == "c")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            a = e = "c ";
                            Console.WriteLine(a + b + c + d + e + f);
                        }
                        if (letra == "a")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            b= f = "a ";
                            Console.WriteLine(a + b + c + d + e + f);
                        }
                        if (letra == "n")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            c = "n ";
                            Console.WriteLine(a + b + c + d + e + f);
                        }
                        if (letra == "e")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            d = "e ";
                            Console.WriteLine(a + b + c + d + e + f);
                        }
                        if (letra != "c" && letra != "a" && letra != "n" && letra != "e")
                        {
                            indice = indice + 1;
                            Console.Clear();
                            ImagemForca(indice);
                            Console.WriteLine("Escolha uma letra.");

                            if (indice >= 7)
                            {
                                Console.Clear();
                                ImagemForca(7);
                                Console.WriteLine("Perdeu.");
                                return;
                            }
                        }
                    }
                    Console.WriteLine("Ganhou!");
                    break;

                case "regador":

                    while (a == "_ " || b == "_ " || c == "_ " || d == "_ "||e == "_ " || f == "_ " || g == "_ ")
                    {
                        Console.Clear();
                        ImagemForca(indice);
                        Console.WriteLine(a + b + c + d + e + f + g);
                        Console.WriteLine("Escolha uma letra.");


                        var letra = Console.ReadLine();
                        if (letra == "r")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            a = g = "r ";
                            Console.WriteLine(a + b + c + d + e + f + g);
                        }
                        if (letra == "e")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            b = "e ";
                            Console.WriteLine(a + b + c + d + e + f + g);
                        }
                        if (letra == "g")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            c = "g ";
                            Console.WriteLine(a + b + c + d + e + f + g);
                        }
                        if (letra == "a")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            d = "a ";
                            Console.WriteLine(a + b + c + d + e + f + g);
                        }
                        if (letra == "d")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            e = "d ";
                            Console.WriteLine(a + b + c + d + e + f + g);
                        }
                        if (letra == "o")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            f = "o ";
                            Console.WriteLine(a + b + c + d + e + f + g);
                        }
                        if (letra != "r" && letra != "e" && letra != "g" && letra != "a" && letra != "d" && letra != "o")
                        {
                            indice = indice + 1;
                            Console.Clear();
                            ImagemForca(indice);
                            Console.WriteLine("Escolha uma letra.");

                            if (indice >= 7)
                            {
                                Console.Clear();
                                ImagemForca(7);
                                Console.WriteLine("Perdeu.");
                                return;
                            }
                        }
                    }
                    Console.WriteLine("Ganhou!");
                    break;

                case "livro":

                    while (a == "_ " || b == "_ " || c == "_ " || d == "_ " || e == "_ ")
                    {
                        Console.Clear();
                        ImagemForca(indice);
                        Console.WriteLine(a + b + c + d + e);
                        Console.WriteLine("Escolha uma letra.");


                        var letra = Console.ReadLine();
                        if (letra == "l")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            a = "l ";
                            Console.WriteLine(a + b + c + d + e);
                        }
                        if (letra == "i")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            b = "i ";
                            Console.WriteLine(a + b + c + d + e);
                        }
                        if (letra == "v")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            c = "v ";
                            Console.WriteLine(a + b + c + d + e);
                        }
                        if (letra == "r")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            d = "r ";
                            Console.WriteLine(a + b + c + d + e);
                        }
                        if (letra == "o")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            e = "o ";
                            Console.WriteLine(a + b + c + d + e);
                        }
                        if (letra != "l" && letra != "i" && letra != "v" && letra != "r" && letra != "o")
                        {
                            indice = indice + 1;
                            Console.Clear();
                            ImagemForca(indice);
                            Console.WriteLine("Escolha uma letra.");

                            if (indice >= 7)
                            {
                                Console.Clear();
                                ImagemForca(7);
                                Console.WriteLine("Perdeu.");
                                return;
                            }
                        }
                    }
                    Console.WriteLine("Ganhou!");
                    break;

                case "revista":

                    while (a == "_ " || b == "_ " || c == "_ " || d == "_ " || e == "_ " || f == "_ " || g == "_ ")
                    {
                        Console.Clear();
                        ImagemForca(indice);
                        Console.WriteLine(a + b + c + d + e + f + g);
                        Console.WriteLine("Escolha uma letra.");


                        var letra = Console.ReadLine();
                        if (letra == "r")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            a = "r ";
                            Console.WriteLine(a + b + c + d + e + f + g);
                        }
                        if (letra == "e")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            b = "e ";
                            Console.WriteLine(a + b + c + d + e + f + g);
                        }
                        if (letra == "v")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            c = "v ";
                            Console.WriteLine(a + b + c + d + e + f + g);
                        }
                        if (letra == "i")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            d = "i ";
                            Console.WriteLine(a + b + c + d + e + f + g);
                        }
                        if (letra == "s")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            e = "s ";
                            Console.WriteLine(a + b + c + d + e + f + g);
                        }
                        if (letra == "t")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            f = "t ";
                            Console.WriteLine(a + b + c + d + e + f + g);
                        }
                        if (letra == "a")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            g = "a ";
                            Console.WriteLine(a + b + c + d + e + f + g);
                        }
                        if (letra != "r" && letra != "e" && letra != "v" && letra != "i" && letra != "s" && letra != "t" && letra != "a")
                        {
                            indice = indice + 1;
                            Console.Clear();
                            ImagemForca(indice);
                            Console.WriteLine("Escolha uma letra.");

                            if (indice >= 7)
                            {
                                Console.Clear();
                                ImagemForca(7);
                                Console.WriteLine("Perdeu.");
                                return;
                            }
                        }
                    }
                    Console.WriteLine("Ganhou!");
                    break;

                case "ferro":

                    while (a == "_ " || b == "_ " || c == "_ " || d == "_ " || e == "_ ")
                    {
                        Console.Clear();
                        ImagemForca(indice);
                        Console.WriteLine(a + b + c + d+e);
                        Console.WriteLine("Escolha uma letra.");


                        var letra = Console.ReadLine();
                        if (letra == "f")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            a = "f ";
                            Console.WriteLine(a + b + c + d + e);
                        }
                        if (letra == "e")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            b = "e ";
                            Console.WriteLine(a + b + c + d + e);
                        }
                        if (letra == "r")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            c=d = "r ";
                            Console.WriteLine(a + b + c + d + e);
                        }
                        if (letra == "o")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            e = "o ";
                            Console.WriteLine(a + b + c + d + e);
                        }
                        if (letra != "f" && letra != "e" && letra != "r" && letra != "o")
                        {
                            indice = indice + 1;
                            Console.Clear();
                            ImagemForca(indice);
                            Console.WriteLine("Escolha uma letra.");

                            if (indice >= 7)
                            {
                                Console.Clear();
                                ImagemForca(7);
                                Console.WriteLine("Perdeu.");
                                return;
                            }
                        }
                    }
                    Console.WriteLine("Ganhou!");
                    break;

                case "cobalto":

                    while (a == "_ " || b == "_ " || c == "_ " || d == "_ " || e == "_ " || f == "_ " || g == "_ ")
                    {
                        Console.Clear();
                        ImagemForca(indice);
                        Console.WriteLine(a + b + c + d + e + f + g);
                        Console.WriteLine("Escolha uma letra.");


                        var letra = Console.ReadLine();
                        if (letra == "c")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            a = "c ";
                            Console.WriteLine(a + b + c + d + e + f + g);
                        }
                        if (letra == "o")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            b = g = "o ";
                            Console.WriteLine(a + b + c + d + e + f + g);
                        }
                        if (letra == "b")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            c = "b ";
                            Console.WriteLine(a + b + c + d + e + f + g);
                        }
                        if (letra == "a")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            d = "a ";
                            Console.WriteLine(a + b + c + d + e + f + g);
                        }
                        if (letra == "l")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            e = "l ";
                            Console.WriteLine(a + b + c + d + e + f + g);
                        }
                        if (letra == "t")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            f = "t ";
                            Console.WriteLine(a + b + c + d + e + f + g);
                        }
                        if (letra != "c" && letra != "o" && letra != "b" && letra != "a" && letra != "l" && letra != "t")
                        {
                            indice = indice + 1;
                            Console.Clear();
                            ImagemForca(indice);
                            Console.WriteLine("Escolha uma letra.");

                            if (indice >= 7)
                            {
                                Console.Clear();
                                ImagemForca(7);
                                Console.WriteLine("Perdeu.");
                                return;
                            }
                        }
                    }
                    Console.WriteLine("Ganhou!");
                    break;

                case "sal":

                    while (a == "_ " || b == "_ " || c == "_ ")
                    {
                        Console.Clear();
                        ImagemForca(indice);
                        Console.WriteLine(a + b + c);
                        Console.WriteLine("Escolha uma letra.");


                        var letra = Console.ReadLine();
                        if (letra == "s")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            a = "s ";
                            Console.WriteLine(a + b + c);
                        }
                        if (letra == "a")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            b = "a ";
                            Console.WriteLine(a + b + c);
                        }
                        if (letra == "l")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            c = "l ";
                            Console.WriteLine(a + b + c);
                        }
                      
                        if (letra != "s" && letra != "l" && letra != "a" )
                        {
                            indice = indice + 1;
                            Console.Clear();
                            ImagemForca(indice);
                            Console.WriteLine("Escolha uma letra.");

                            if (indice >= 7)
                            {
                                Console.Clear();
                                ImagemForca(7);
                                Console.WriteLine("Perdeu.");
                                return;
                            }
                        }
                    }
                    Console.WriteLine("Ganhou!");
                    break;

                case "pimenta":

                    while (a == "_ " || b == "_ " || c == "_ " || d == "_ " || e == "_ " || f == "_ " || g == "_ ")
                    {
                        Console.Clear();
                        ImagemForca(indice);
                        Console.WriteLine(a + b + c + d + e+ f +g);
                        Console.WriteLine("Escolha uma letra.");


                        var letra = Console.ReadLine();
                        if (letra == "p")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            a = "p ";
                            Console.WriteLine(a + b + c + d + e + f + g);
                        }
                        if (letra == "i")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            b = "i ";
                            Console.WriteLine(a + b + c + d + e + f + g);
                        }
                        if (letra == "m")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            c = "m ";
                            Console.WriteLine(a + b + c + d + e + f + g);
                        }
                        if (letra == "e")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            d = "e ";
                            Console.WriteLine(a + b + c + d + e + f + g);
                        }
                        if (letra == "n")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            e = "n ";
                            Console.WriteLine(a + b + c + d + e + f + g);
                        }
                        if (letra == "t")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            f = "t ";
                            Console.WriteLine(a + b + c + d + e + f + g);
                        }
                        if (letra == "a")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            g = "a ";
                            Console.WriteLine(a + b + c + d + e + f + g);
                        }
                        if (letra != "p" && letra != "i" && letra != "m" && letra != "e" && letra != "n" && letra != "t" && letra != "a")
                        {
                            indice = indice + 1;
                            Console.Clear();
                            ImagemForca(indice);
                            Console.WriteLine("Escolha uma letra.");

                            if (indice >= 7)
                            {
                                Console.Clear();
                                ImagemForca(7);
                                Console.WriteLine("Perdeu.");
                                return;
                            }
                        }
                    }
                    Console.WriteLine("Ganhou!");
                    break;

                case "caneta":

                    while (a == "_ " || b == "_ " || c == "_ " || d == "_ " || e == "_ " || f == "_ ")
                    {
                        Console.Clear();
                        ImagemForca(indice);
                        Console.WriteLine(a + b + c + d + e + f);
                        Console.WriteLine("Escolha uma letra.");


                        var letra = Console.ReadLine();
                        if (letra == "c")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            a = "c ";
                            Console.WriteLine(a + b + c + d + e + f);
                        }
                        if (letra == "a")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            b = f = "a ";
                            Console.WriteLine(a + b + c + d + e + f);
                        }
                        if (letra == "n")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            c = "n ";
                            Console.WriteLine(a + b + c + d + e + f);
                        }
                        if (letra == "e")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            d = "e ";
                            Console.WriteLine(a + b + c + d + e + f);
                        }
                        if (letra == "t")
                        {
                            Console.Clear();
                            ImagemForca(indice);
                            e = "t ";
                            Console.WriteLine(a + b + c + d + e + f);
                        }
                        if (letra != "c" && letra != "a" && letra != "n" && letra != "e" && letra != "t")
                        {
                            indice = indice + 1;
                            Console.Clear();
                            ImagemForca(indice);
                            Console.WriteLine("Escolha uma letra.");

                            if (indice >= 7)
                            {
                                Console.Clear();
                                ImagemForca(7);
                                Console.WriteLine("Perdeu.");
                                return;
                            }
                        }
                    }
                    Console.WriteLine("Ganhou!");
                    break;
            }
        }
    }
}
