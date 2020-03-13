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
            while(u!=" ")
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
                            a= a - b2;
                            Console.WriteLine(a);
                            break;

                        case "*":
                            Console.WriteLine("Segundo número?");
                            double b3 = Convert.ToDouble(Console.ReadLine());
                            a= a * b3;
                            Console.WriteLine(a);
                            break;

                        case "/":
                            Console.WriteLine("Segundo número?");
                            double b4 = Convert.ToDouble(Console.ReadLine());
                            a= a / b4;
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
                if(op!=" ")
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

        #region tentativa 3
        public static void ExercicioCalc()
        {

        }

        private static double Soma(double a, double b)
        {
            return a + b;
        }

        private static double Subtrair(double a, double b)
        {
            return a - b;
        }

        private static double Multiplicacao(double a, double b)
        {
            return a * b;
        }

        private static double Divisao(double a, double b)
        {
            return a / b;
        }

        private static double Resto(double a, double b)
        {
            return a % b;
        }

        #endregion













    }
}
