using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise26_30
{
    class Program
    {
        // 26.Write a method, which returns the last character of the string that is a parameter.
        private static char Last(string s)
        {
            int k = s.Length - 1;
            return System.Convert.ToChar(s[k]);
        }

        // 27.Write a method f(x, y, z), which returns the value(x+y + z)/ 3.0, that is, it calculates the
        // average of its parameters.
        private static double Lasku(double x, double y, double z)
        {
            return ((x + y + z) / 3.0);
        }

        // 28.Write a method Combine so that for example Combine(”qwerty”, ”asdf”) -> ”qwertyasdf”.
        // The following arrow character->means return from the method.
        private static string Combine(string s2, string s3)
        {
            return (s2 + s3);
        }

        // 29.Realize Combine method on such way that two parameters are integers. For example
        // Combine(23, 15)-> ”2315”.
        private static int Combine2(int i1, int i2)
        {
            int sum;
            return sum = Convert.ToInt32("" + i1 + i2);
        }

        private static void Initials(string v1, string v2) // 30a
        {
            Console.WriteLine(v1[0] + "." + v2[0] + ".");
        }


        static void Main(string[] args)
        {
            // 30a.Write a method, the name of which is Initials.Method acts as follows.E.g.
            // Initials(”Mickey”, ”Mouse”) -> ”M.M.”. Print your own initials by using this method.

            Initials("Hanna", "Vohlonen");

            // 30c.A method has an integer array as a parameter.The method returns a new integer array,
            // where the items are multiplied by 2.
            int[] tau = { 7, 4, 1 };
            int[] tauUusi = Tuplaa(tau);
            foreach (var item in tauUusi)
            {
                Console.Write(item + " ");
            }
        }
        // 30b.A method has an integer array as a parameter.The method does not return anything, but
        // it changes the values of the array so that any number is multiplied by 2.

        private static void TuplaaTaulukko(int[] tau1)
        {
            for (int i = 0; i < tau1.Length; i++)
            {
                tau1[i] = 2 * tau1[i];
            }
        }

        private static int[] Tuplaa(int[] tau2) // 30c
        {
            int[] uusi = new int[tau2.Length];
            for (int i = 0; i < tau2.Length; i++)
            {
                uusi[i] = 2 * tau2[i];
            }
            return uusi;
        }
    }
}

