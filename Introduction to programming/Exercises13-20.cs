using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13_20
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 13 Print with for loop 30 times: Good Good Good …
            int kerrat = 30; // Toistokerrat 30 kpl
            for (int i = 0; i <= kerrat; i++)
            {
                Console.WriteLine("Good");
            }

            // Exercise 14 Print even numbers from 2 to 100 with for loop.
            for (int i = 2; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }

            // Exercise 15 Print numbers 100, 90, 80…10 with for loop on the same line separated by comma. Notice that after the last element there is no comma.
            for (int i = 100; i >= 10; i -= 10)
            {
                if (i == 10)
                {
                    Console.Write(i);
                    break;
                }
                Console.Write(i + ", ");
            }
            Console.WriteLine();

            // Exercise 16 Ask a word from the user. Print this word reversed and spaced.
            Console.Write("Type a word: "); // Sana käyttäjältä
            string sana = (Console.ReadLine());
            string käännettySana = "";
            for (int i = sana.Length - 1; i >= 0; i--)
            {
                käännettySana += sana[i] + " ";
            }
            Console.WriteLine(käännettySana);

            // Exercise 17 (multiplication table)
            for (int i = 0; i <= 10; i++)
            {
                Console.Write(i + "\t");
                for (int j = 1; j <= 10; j++)
                {
                    if (i > 0)
                        Console.Write(i * j + "\t");
                    else
                        Console.Write(j + "\t");
                }
                Console.Write("\n");
            }

            // Exercise 18a (Ympyrän piiri)
            double piiri;
            do
            {
                Console.Write("Anna ympyrän säde: ");
                double säde = double.Parse(Console.ReadLine());
                piiri = (2 * säde * Math.PI);
                Console.WriteLine("Ympyrän piiri on 2 * pii * {0} = {1}", säde, (2 * Math.PI * säde));
            } while (piiri != 0);


            //19. Throw a dice until we have the value 6. Print thrown values to the Console.
            // Luodaan satunnaislukugeneraattori
            Random satu = new Random();

            int silmäluku = 0;
            while (silmäluku != 6)
            {
                // Heitetään noppaa
                silmäluku = satu.Next(1, 7); // ottaa huomioon 1-6
                Console.WriteLine(silmäluku);
            }


            //20. The user gives a word. For example, if the given word is “program” the following lines are printed
            Console.Write("Anna sana: "); // Sana käyttäjältä
            string sana = Console.ReadLine();

            for (int i20 = 0; i20 <= sana.Length - 1; i20++)
            {
                for (int j20 = 0; j20 <= i20; j20++)
                    if (j20 == i20)
                    {
                        // Jos muuttujat yhtä suuret --> rivinvaihto
                        Console.WriteLine(sana[j20]);
                    }
                    else
                    {
                        Console.Write(sana[j20]);
                    }
            }

        }
    }
}
