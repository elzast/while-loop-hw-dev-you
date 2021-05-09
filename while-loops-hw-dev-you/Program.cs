using System;

namespace while_loops_hw_dev_you
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problems all working! Comment/uncomment sections of code to see!  I have commented out all but one so the console was clearer to read. 
            //The letter ‘n’ represents user input.
            //Use a while loop to print all whole numbers from 1 to n
            //Console.WriteLine("Enter a number");
            //int n = int.Parse(Console.ReadLine());
            //int i = 1;
            //while (i<=n) {
            //    Console.WriteLine(i);
            //    i++;
            //}
            //
            //Use a while loop to print all whole numbers in reverse from n to 1
            //while (i<=n)
            //{
            //    Console.WriteLine(n);
            //    n--;
            //}
            //
            //Use a while loop to print all the alphabets from a - z
            //int i = -1;
            //while (i < 25)
            //{
            //    i++;
            //    Console.Write(Convert.ToChar(i + (int)'a') + " , ");
            //}

            //Use a while loop to print all even numbers between 1 and 100
            //int i = 1;


            //while (i >= 1 && i <= 100)
            //{
            //    i++;

            //    if (i % 2 == 0)

            //        Console.WriteLine(i);
            //}
            //Use a while loop to print all odd numbers between 1 and 100
            //
            //**bug : list returning one more than expected.
            //int i = 0;
            //while (i >= 0 && i <= 100)
            //{
            //    i++;

            //    if (i % 2 == 1)

            //        Console.WriteLine(i);
            //}
            //Use a while loop to print the sum of all the whole numbers from 1 - n
            //Given the number n, use a while loop to print the multiplication table up to n.
            //Example: n = 5
            //5 * 1 = 5
            //5 * 2 = 10
            //5 * 3 = 15
            //5 * 4 = 20
            //5 * 5 = 25
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            while (i <= n - 1)
            {
                i++;
                int iProd = n * i;
                Console.WriteLine(iProd);
            };

        }
    }
}
