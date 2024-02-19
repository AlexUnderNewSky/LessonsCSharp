using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    internal class Homework
    {
        public void HomeworkCsharp()
        {
            
        }
    }
}



















/*
Homework 1: 1 task:
           Console.WriteLine("Please enter first value: ");
           int a = Convert.ToInt16(Console.ReadLine());
           Console.WriteLine("Please enter second value: ");
           int b = Convert.ToInt16(Console.ReadLine());

           int res = (a + b) / 2;

           Console.WriteLine(res);


Homework 1: 2 task:
           Console.WriteLine("Please enter first value: ");
           int a = Convert.ToInt16(Console.ReadLine());
           Console.WriteLine("Please enter second value: ");
           int b = Convert.ToInt16(Console.ReadLine());
           Console.WriteLine("Please enter third value: ");
           int c = Convert.ToInt16(Console.ReadLine());

           int resSum = a + b + c;
           int resProd = a * b * c;


Homework 1: 3 task:
           Console.WriteLine(resSum);
           Console.WriteLine(resProd);

           Console.WriteLine("Please enter the amount US Dollars: ");
           double a = Convert.ToDouble(Console.ReadLine());

           double resEuro = a * 0.93;

           Console.WriteLine(resEuro);
 
Homework 2: 1 task:
           Console.WriteLine("Please enter value: ");
            int a;
            a = int.Parse(Console.ReadLine());

            int temp = a % 2;

            bool res = temp == 0;

            if (res)
            {
                Console.WriteLine("Zaebis'");
            }
            else
            {
                Console.WriteLine("Nihuya");
            }

Homework 3: 1 task:
            while (true)
            {
                Console.Clear();
                double a, c;
                char b;

                try
                {
                    Console.WriteLine("Please enter fist value:");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Select a mathematical operation : '+', '-', '*', '/', '%'");
                    b = char.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter second value:");
                    c = double.Parse(Console.ReadLine());    
                }
                catch (Exception)
                {
                    Console.WriteLine("Failed to convert string to number");
                    Console.ReadLine();
                    continue;
                }

                //Console.WriteLine(a + " " + b + " " + c);

                double res;

                switch (b)
                {
                    case '+':
                        res = a + c;
                        Console.WriteLine(res);
                        break;
                    case '-':
                        res = a - c;
                        Console.WriteLine(res);
                        break;
                    case '*':
                        res = a * c;
                        Console.WriteLine(res);
                        break;
                    case '/':
                        if (a == 0 || c == 0)
                        {
                            Console.WriteLine("0 is unacceptable in division.");
                        }
                        else
                        {
                            res = a / c;
                            Console.WriteLine(res);
                        }
                        break;

                    case '%':
                        res = a % c;
                        Console.WriteLine(res);
                        break;
                    default:
                        Console.WriteLine("Something went wrong");
                        break;

                }
                Console.ReadLine();
            }

Homework 4: 1 task:
            Console.WriteLine("Please enter your start value: ");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your finish value: ");
            int limit = int.Parse(Console.ReadLine());

            int evenCount = 0;
            int oddCount = 0;

            while (count < limit)
            {
                count++;
                if(count % 2 == 0)
                {
                    evenCount++;
                }else
                {
                   oddCount++;
                }
            }
            Console.WriteLine("Even numbers are - " + evenCount);
            Console.WriteLine("Odd numbers are - " + oddCount);
 */

