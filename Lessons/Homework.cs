﻿using System;
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

            int evenCount = 0, oddCount = 0, evenSum = 0, oddSum = 0;

            while (count <= limit)
            {
                if (count % 2 == 0)
                {
                    evenCount++;
                    evenSum += count;
                }
                else
                {
                    oddCount++;
                    oddSum =+ count;
                }
                count++;
            }
            Console.WriteLine("Even numbers are - " + evenCount + " | Their sum - " + evenSum);
            Console.WriteLine("Odd  numbers are - " + oddCount + " | Their sum - " + oddSum);

Homework 5: 1 task:
            Моя жижа))
====================
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 1 && i > 0; j++)
                {
                    Console.Write("#");
                    for (int k = 1; k < 2 && i > 1; k++)
                    {
                        Console.Write("#");
                        for (int l = 2; l < 3 && i > 2; l++)
                        {
                            Console.Write("#");
                            for (int n = 3; n < 4 && i > 3; n++)
                            {
                                Console.Write("#");
                                continue;
                            }
                        }
                    }
                }

                Console.WriteLine("#");
            }
====================
            Полу-моя жижа((
            Console.WriteLine("Enter heigt : ");
            int height = int.Parse(Console.ReadLine());
            int width = 1;
            for (int i = 0; i < height; i++)
            {

                for (int j = 0; j < width; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine("");
                width++;

            }

            Console.WriteLine("");

            int width2 = height;
            for (int i = 0; i < height; i++)
            {

                for (int j = 0; j < width2; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine("");
                width2--;

            }

            Console.WriteLine("");

            for (int i = 0; i < height; i++)
            {
                for (int j = height; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

             Console.WriteLine("");


            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = i; j < height; j++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }

            Console.ReadLine();

 */

