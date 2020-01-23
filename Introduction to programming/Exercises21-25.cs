using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise21_25
{
    class Program
    {
        enum Kortit { k2 = 2, k3, k4, k5, k6, k7, k8, k9, k10, J, Q, K, A }; // 24b.
        enum Vuodenajat { talvi, kevät, kesä, syksy }; // 24c.

        private static void Warning() // 25a.
        {
            Console.WriteLine("The weather is bad today.");
        }

        private static char First(string s) // 25b.
        {
            return System.Convert.ToChar(s[0]);
        }

        static void Main(string[] args)
        {
            //21. Create an array with integers. The length of the array is 4. The values of the array are asked
            // from the user inside for loop.Print the values of the array in reversed way

            int i21;
            int[] arr = new int[4]; // 4 pituinen

            // Arvo käyttäjältä
            for (i21 = 0; i21 < 4; i21++)
            {
                Console.Write("Enter an integer: ");
                //Arvot talteen
                arr[i21] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

            //Tulostus takaperin
            for (i21 = arr.Length - 1; i21 >= 0; i21--)
            {
                Console.WriteLine(arr[i21]);
            }
            Console.WriteLine();


            // 22.Calculate the average of the array of real numbers without built-in C# method.
            double[] numerot;
            numerot = new double[4];
            Console.WriteLine("Give four real numbers:");
            numerot[0] = double.Parse(Console.ReadLine());
            numerot[1] = double.Parse(Console.ReadLine());
            numerot[2] = double.Parse(Console.ReadLine());
            numerot[3] = double.Parse(Console.ReadLine());

            double summa = 0;

            foreach (double x in numerot)
            {
                summa += x;
            }

            //23.If we have an integer array, whose name is tau, then we can get the smallest element of the
            // array by writing tau.Min().Test this method.
            int[] tau = { 6, 39, 918, 343, 2, 443, 23, 56 };
            Console.WriteLine(tau.Min());

            //24a.Find methods that calculate the greatest value, the sum and the average of elements.
            // Apply them in Main method.
            tau.Max();
            tau.Sum();
            tau.Average();

            //24b.Make a new enum type that describes the values(e.g. 2 .. 10, J, Q, K, A) of game cards.
            //Create a variable of that enum type and print the value of the variable as enum type and
            // integer.

            Kortit kortit = Kortit.k3;
            Console.WriteLine(kortit + " " + (int)kortit);

            //24c.Make a new enum type that describes the seasons of the year.Try this type in Main
            // method.Write all the seasons to the Console by using type casting.
            foreach (string str in Enum.GetNames(typeof(Vuodenajat)))
            {
                Console.WriteLine(str);
            }

            //24d. Create an array of the seasons.Write the items of the array to Console

            string[] seasons = { "kesä", "syksy", "kevät", "talvi" };
            for (int i = 0; i < seasons.Length; i++)
            {
                Console.WriteLine(seasons[i]);
            }

            //25a. Write a method the name of which is Warning. The method has no parameters and it does
            // not return anything.The method writes to the Console the text: The weather is bad today.
            Warning();

            /* 25b. Main method has a method call
            char c = First("abc");
            Method, the name of which is First returns the first character of the string that is a parameter.
            Write the code that defines method First. */

            char c = First("abc");
            Console.WriteLine(c);
        }
    }
}