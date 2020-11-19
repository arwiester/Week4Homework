using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Use a while loop to print all whole numbers from 1 to n
            Console.WriteLine("Use a while loop to print all whole numbers from 1 to n");
             int i = 1;
             Console.WriteLine("Please enter a number:");
             int n = int.Parse(Console.ReadLine());
             while (i <= n)
             {
                 Console.WriteLine($"The count is: {i}");
                 i++;
             }
             Console.ReadKey();

            //Use a while loop to print all whole numbers in reverse from n2 to 1
            Console.WriteLine("Use a while loop to print all whole numbers in reverse from n2 to 1");
             int j = 1;
             Console.WriteLine("Please enter a number:");
             int n2 = int.Parse(Console.ReadLine());
             while (j <= n2)
             {
                 Console.WriteLine($"The count is: {n2}");
                 n2--;
             }
             Console.ReadKey();

            // Use a while loop to print all the alphabets from a - z
            Console.WriteLine("Use a while loop to print all the alphabets from a - z");
            char k = 'A';
            Console.WriteLine("The Alphabets from A to Z are: \n");
            while (k <= 'Z')
            {
                Console.WriteLine(k);
                k++;
            }
            Console.ReadLine();

            //Use a while loop to print all even numbers between 1 and 100
            Console.WriteLine("Use a while loop to print all even numbers between 1 and 100");
            int counter = 2;
            Console.WriteLine("All the even number from 1-100 are: ");
            while (counter <= 100)
            {
                Console.WriteLine($"{counter}");
                counter = counter + 2;
            }
            Console.ReadLine();

            //Use a while loop to print all odd numbers between 1 and 100
            Console.WriteLine("Use a while loop to print all odd numbers between 1 and 100");
            int counter2 = 1;
            Console.WriteLine("All the odd number from 1-100 are: ");
            while (counter2 <= 100)
            {
                Console.WriteLine($"{counter2}");
                counter2 = counter2 + 2;
            }
            Console.ReadLine();

            //Use a while loop to print the sum of all the whole numbers from 1 - n
            Console.WriteLine("Use a while loop to print the sum of all the whole numbers from 1 - l");
            double l = 1;
            double sum = 0;
            Console.WriteLine("Please enter a number:");
            double n3 = double.Parse(Console.ReadLine());
            while (l <= n3)
            {
                sum = sum + l;
                l++;
            }
            Console.WriteLine($"The sum of all numbers is {sum}");

            Console.ReadLine();

            //Given the number n, use a while loop to print the multiplication table up to p.
            Console.WriteLine("Given the number p, use a while loop to print the multiplication table up to p");
            double p = 1;
            //double sum2 = 0;
            Console.WriteLine("Please enter a number:");
            double n4 = double.Parse(Console.ReadLine());
            while (p <= n4)
            {
                Console.WriteLine($"{n4} * {p} = {n4 * p}");
                p++;
            }
            Console.ReadLine();           

        }
    }
}
