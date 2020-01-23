using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11_12
{
    class Program
    {
        static void Main(string[] args)
        {

            // Exercise 11
            Console.WriteLine("ax^2 + bx + c = 0");
            Console.Write("Insert a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Insert b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Insert c: ");
            double c = double.Parse(Console.ReadLine());
            double d = ((b * b) - (4 * a * c));
            if (d > 0)
            {
                Console.WriteLine("D = b^2 - 4ac = {0} \nThe equation has 2 real roots.", d);
                Console.WriteLine("x1 = {0:f}", ((-b + (Math.Sqrt((b * b) - (4 * a * c)))) / (2 * a)));
                Console.WriteLine("x2 = {0:f}", ((-b - (Math.Sqrt((b * b) - (4 * a * c)))) / (2 * a)));
            }

            else if (d == 0)
            {
                Console.WriteLine("D = b^2 - 4ac = {0} \nThe real roots are the same.", d);
                Console.WriteLine("x = {0:f}", ((-b + (Math.Sqrt((b * b) - (4 * a * c)))) / (2 * a)));
            }

            else
            {
                Console.WriteLine("D = b^2 - 4ac = {0} \nThe equation has 2 complex roots. ", d);
                Console.WriteLine("x1 = {0:f} + {1:f}i", (-b / (2 * a)), Math.Sqrt(-1 * d) / (2 * a));
                Console.WriteLine("x2 = {0:f} - {1:f}i", (-b / (2 * a)), Math.Sqrt(-1 * d) / (2 * a));
            }


            // Exercise 12a
            Console.WriteLine("How much money you have?");
            double raha = double.Parse(Console.ReadLine());
            Console.WriteLine("How much does a movie ticket cost?");
            double leffa = double.Parse(Console.ReadLine());
            Console.WriteLine("How much does a one-way bus ticket cost?");
            double bussi = double.Parse(Console.ReadLine());
            if (raha >= leffa && (raha - leffa) >= (2 * bussi))
            {
                Console.WriteLine("You can go to the cinema and back with bus");
            }
            else if (raha >= leffa && (raha - leffa) >= bussi)
            {
                Console.WriteLine("You can go to the cinema with bus and walk back home.");
            }
            else if (raha >= leffa)
            {
                Console.WriteLine("You can go to the cinema and back by walking.");
            }
            else
            {
                Console.WriteLine("You will stay at home and watch the tv");
            }

            //12b
            string numeroArvosana = "";
            Console.Write("Write: failed, fair, good or excellent: ");
            string sanaArvosana = Console.ReadLine();

            switch (sanaArvosana)
            {
                case "failed":
                    numeroArvosana = "0";
                    break;
                case "fair":
                    numeroArvosana = "1 or 2";
                    break;
                case "good":
                    numeroArvosana = "3 or 4";
                    break;
                case "excellent":
                    numeroArvosana = "5";
                    break;
                default:
                    numeroArvosana = "nothing";
                    break;
            }
            Console.WriteLine("Equals " + numeroArvosana);


            // 12c
            Console.Write("Input the first number: ");
            double numero1 = double.Parse(Console.ReadLine());
            Console.Write("Input the second number: ");
            double numero2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Choose calculation");
            Console.WriteLine("1. addition");
            Console.WriteLine("2. subtraction");
            Console.WriteLine("3. muliplication");
            Console.WriteLine("4. division");

            char valinta = Console.ReadLine()[0];

            switch (valinta)
            {
                case '1': //addition
                    Console.WriteLine("{0} + {1} = {2}", numero1, numero2, (numero1 + numero2));
                    break;
                case '2': // subtraction
                    Console.WriteLine("{0} - {1} = {2}", numero1, numero2, (numero1 - numero2));
                    break;
                case '3': // multiplication
                    Console.WriteLine("{0} * {1} = {2}", numero1, numero2, (numero1 * numero2));
                    break;
                case '4': // division
                    Console.WriteLine("{0} / {1} = {2}", numero1, numero2, (numero1 / numero2));
                    break;
                default:
                    break;
            }


            //12 d
            Console.WriteLine("A = P(1 + rt)");
            Console.Write("Insert principal value: ");
            double principal = double.Parse(Console.ReadLine());
            Console.Write("Insert interest value (%): ");
            double interest = double.Parse(Console.ReadLine()) / 100;
            double i = 0; //years, starting from 0

        Here:
            double Amount = principal * (1.0 + (interest * i++));
            Console.WriteLine("A = " + Amount);
            goto Here;

        }
    }
}