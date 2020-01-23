using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. tehtävä
            Console.WriteLine("\t \\o");
            Console.WriteLine("\t |\\");
            Console.WriteLine("\t / \\");

            // 3. tehtävä
            // Määritellään muuttujat
            int a = 25;
            double b = 35.3;
            double c = a * b;
            //Laskutoimitus ja muuttujat kirjoitettuina
            Console.WriteLine("a = 25\nb = 35.3\nc = ?\n");
            Console.WriteLine("a * b = c");
            Console.WriteLine("a * b = " + c);
            Console.WriteLine("c = " + c);

            // 4. tehtävä
            Console.WriteLine("(10 * 13) / 3 = " + (10 * 13) / 3.0);

            // 5. tehtävä
            Console.WriteLine("using System;\n");
            Console.WriteLine("namespace FirstProgram");
            Console.WriteLine("{");
            Console.WriteLine("\tclass Program");
            Console.WriteLine("\t{");
            Console.WriteLine("\t\t// Main is a main program");
            Console.WriteLine("\t\tstatic void Main(string[] args)");
            Console.WriteLine("\t\t{");
            Console.WriteLine("\t\t\tConsole.WriteLine(\"Hello C#\"); //Semicolon is in the end of a line");
            Console.WriteLine("\t\t}");
            Console.WriteLine("\t}");
            Console.WriteLine("}");

            //Tehtävä 6
            // Muuttujat
            int a = 5, b = 8, summa = a + b;
            // Lasku käyttämällä +
            Console.WriteLine("Number " + a + " added to number " + b + " is " + summa);
            // Lasku käyttämällä {n}
            Console.WriteLine("Number {0} added to number {1} is {2}", a, b, summa);

            // Tehtävä 7
            double a1 = -2, b1 = 5, c1 = 3;
            Console.WriteLine("ax^2 + bx + c = 0");
            Console.WriteLine("D = b^2 - 4ac = {0}^2 - 4 * {1} * {2} = {3}", (b1 * b1), a1, c1, (b1 * b1) - (4 * a1 * c1));


            // Tehtävä 8
            Console.WriteLine("Input 3 grades to get their average");
            Console.WriteLine("Input the 1st grade");
            double grade1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Input the 2nd grade");
            double grade2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Input the 3rd grade");
            double grade3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Calculating the average");
            Console.WriteLine("{0} + {1} + {2} = {3:f1}", grade1, grade2, grade3, (grade1 + grade2 + grade3) / 3);

            // Tehtävä 9
            Console.WriteLine("How many inches?");
            double inches = double.Parse(Console.ReadLine());
            Console.WriteLine("Your inches in centimetres = {0:f1} cm", inches * 2.54);

            // Tehtävä 10
            Console.WriteLine("int requires " + sizeof(int) + " B = " + sizeof(int) * 8 + " b");
            Console.WriteLine("short requires " + sizeof(short) + " B = " + sizeof(short) * 8 + " b");
            Console.WriteLine("double requires " + sizeof(double) + " B = " + sizeof(double) * 8 + " b");
            Console.WriteLine("decimal requires " + sizeof(decimal) + " B = " + sizeof(decimal) * 8 + " b");
            Console.WriteLine("bool requires " + sizeof(bool) + " B = " + sizeof(bool) * 8 + " b");

            // >> int requires 4 B = 32 b
            // >> short requires 2 B = 16 b
            // >> double requires 8 B = 64 b
            // >> decimal requires 16 B = 128 b
            // >> bool requires 1 B = 8 b

        }
    }
}