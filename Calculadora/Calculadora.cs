using System;

namespace Calculadora
{
    public class Calculadora
    {
        

        #region tentativa 1

        public static void FazCalculadora()
        {
            Console.WriteLine("Introduza um número.");
            string u = Console.ReadLine();
            var g = double.TryParse(u, out double a);
            while (u != " ")
            {
                if (g)
                {


                    Console.WriteLine("Operador?");
                    var op = Console.ReadLine();
                    switch (op)
                    {
                        case "+":
                            Console.WriteLine("Segundo número?");
                            double b1 = Convert.ToDouble(Console.ReadLine());
                            a = a + b1;
                            Console.WriteLine(a);
                            break;

                        case "-":
                            Console.WriteLine("Segundo número?");
                            double b2 = Convert.ToDouble(Console.ReadLine());
                            a = a - b2;
                            Console.WriteLine(a);
                            break;

                        case "*":
                            Console.WriteLine("Segundo número?");
                            double b3 = Convert.ToDouble(Console.ReadLine());
                            a = a * b3;
                            Console.WriteLine(a);
                            break;

                        case "/":
                            Console.WriteLine("Segundo número?");
                            double b4 = Convert.ToDouble(Console.ReadLine());
                            a = a / b4;
                            Console.WriteLine(a);
                            break;

                        case "%":
                            Console.WriteLine("Segundo número?");
                            double b5 = Convert.ToDouble(Console.ReadLine());
                            a = a % b5;
                            Console.WriteLine(a);
                            break;

                        default:
                            Console.WriteLine("Introduza um operador (+, -, *, / ou %).");
                            break;
                    }


                }
                else
                {
                    Console.WriteLine("Selecione um número ou espaço para terminar.");
                }
            }






        }


        #endregion

        #region tentativa dois


        public static void FazCalc()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("                                   ");


            Console.Write("    ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("                           ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("    ");

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("                                   ");
            Console.Write("    ");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Write(" 7 ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Write(" 8 ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Write(" 9 ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Write(" / ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Write(" % ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("    ");


            Console.WriteLine("                                   ");
            Console.Write("    ");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Write(" 4 ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Write(" 5 ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Write(" 6 ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Write(" - ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Write(" x ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("    ");


            Console.WriteLine("                                   ");
            Console.Write("    ");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Write(" 1 ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Write(" 2 ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Write(" 3 ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Write(" + ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Write(" = ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("    ");
            Console.WriteLine("                                   ");
            Console.ResetColor();

            var final = false;
            var fim = string.Empty;
            while (fim != "!")
            {
                Calcula();
            }

            //Environment.Exit(0);
        }

        public static void Calcula()
        {

            Console.WriteLine("Introduza um número.");
            var num1Parsed = double.TryParse(Console.ReadLine(), out double num1);

            Console.WriteLine("Introduza um operador ou espaço para terminar.");
            var op = Console.ReadLine();
            if (op != " ")
            {
                Console.WriteLine("Introduza um segundo número.");
                var num2Parsed = double.TryParse(Console.ReadLine(), out double num2);

                FazConta(num1, op, num2);
            }

        }

        public static void FazConta(double n1, string oper, double n2)
        {
            double r;
            switch (oper)
            {
                case "+":
                    r = n1 + n2;
                    Console.WriteLine(r);
                    break;

                case "-":
                    r = n1 - n2;
                    Console.WriteLine(r);
                    break;

                case "*":
                    r = n1 * n2;
                    Console.WriteLine(r);
                    break;

                case "/":
                    r = n1 / n2;
                    Console.WriteLine(r);
                    break;

                case "%":
                    r = n1 % n2;
                    Console.WriteLine(r);
                    break;

                default:
                    Console.WriteLine("Inválido");
                    break;
            }
        }

        #endregion

        #region tentativa 3 - OK
        #region funçao imagem
        public static void ImagemCalc(string a)
        {
            //Console.Clear();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("                                   ");


            Console.Write("    ");
            Console.BackgroundColor = ConsoleColor.White;



            var l = a.Length;
            for (int i = 0; i < (27 - l); i++)
            {
                Console.Write(" ");
            }
            Console.Write(a);


            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("    ");

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("                                   ");
            Console.Write("    ");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Write(" 7 ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Write(" 8 ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Write(" 9 ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Write(" / ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Write(" % ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("    ");


            Console.WriteLine("                                   ");
            Console.Write("    ");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Write(" 4 ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Write(" 5 ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Write(" 6 ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Write(" - ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Write(" x ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("    ");


            Console.WriteLine("                                   ");
            Console.Write("    ");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Write(" 1 ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Write(" 2 ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Write(" 3 ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Write(" + ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("   ");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Write(" = ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("    ");

            Console.WriteLine("                                   ");

            Console.Write("                       ");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Write(" ON/OFF ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("    ");
            Console.WriteLine("                                   ");
            Console.ResetColor();
            Console.WriteLine("Introduza o valor de uma das teclas apresentadas ou X para sair.");
        }
        #endregion

        public static void ExercicioCalc()
        {

            ImagemCalc("");
            

            var num = Console.ReadLine();
            var g = double.TryParse(num, out double a);

            while (num != "X"&&num!="OFF")
            {
                Console.Clear();
                ImagemCalc(Convert.ToString(a));


                if (Convert.ToString(a) != "X"&& Convert.ToString(a) != "OFF")
                {
                    var op = Console.ReadLine();
                    switch (op)
                    {
                        case "X":
                            return;

                        case "+":
                            Console.Clear();
                            ImagemCalc(Convert.ToString(a) + "+");
                            var c = Console.ReadLine();

                            if (c != "X"&& c != "OFF")
                            {
                                double.TryParse(c, out double b1);
                                Console.Clear();
                                ImagemCalc(Convert.ToString(a) + "+" + Convert.ToString(b1));
                                a = a + b1;
                            }
                            else { return; }
                            break;

                        case "-":
                            Console.Clear();
                            ImagemCalc(Convert.ToString(a) + "-");
                            var c2 = Console.ReadLine();

                            if (c2 != "X" && c2 != "OFF")
                            {
                                double.TryParse(c2, out double b1);
                                Console.Clear();
                                ImagemCalc(Convert.ToString(a) + "-" + Convert.ToString(b1));
                                a = a - b1;
                            }
                            else { return; }
                            break;

                        case "x":
                            Console.Clear();
                            ImagemCalc(Convert.ToString(a) + "x");
                            var c3 = Console.ReadLine();

                            if (c3 != "X" && c3 != "OFF")
                            {
                                double.TryParse(c3, out double b1);
                                Console.Clear();
                                ImagemCalc(Convert.ToString(a) + "x" + Convert.ToString(b1));
                                a = a * b1;
                            }
                            else { return; }
                            break;

                        case "/":
                            Console.Clear();
                            ImagemCalc(Convert.ToString(a) + "/");
                            var c4 = Console.ReadLine();

                            if (c4 != "X" && c4 != "OFF")
                            {
                                double.TryParse(c4, out double b1);
                                if (b1 == 0)
                                {
                                    b1 = b1 + 1;
                                }
                                Console.Clear();
                                ImagemCalc(Convert.ToString(a) + "/" + Convert.ToString(b1));
                                a = a / b1;
                            }
                            else { return; }
                            break;

                        case "%":
                            Console.Clear();
                            ImagemCalc(Convert.ToString(a) + "%");
                            var c5 = Console.ReadLine();

                            if (c5 != "X" && c5 != "OFF")
                            {
                                double.TryParse(c5, out double b1);
                                if (b1 == 0)
                                {
                                    b1 = b1 + 1;
                                }
                                Console.Clear();
                                ImagemCalc(Convert.ToString(a) + "%" + Convert.ToString(b1));
                                a = a % b1;
                            }
                            else { return; }
                            break;

                        default:

                            Console.Clear();
                            ImagemCalc(Convert.ToString(a));
                            break;
                    }

                    var igual = Console.ReadLine();
                    if (igual == "=")
                    {

                        Console.Clear();
                        ImagemCalc(Convert.ToString(a));

                    }


                }


            }



            #endregion













        }
    }
}
