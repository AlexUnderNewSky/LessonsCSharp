﻿using System;
using System.Collections.Generic;

/*
!!!!!!!!!!!!!! Change format , to . and . to , !!!!!!!!
using System.Globalization;
!!!!!!!!
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/



namespace Lessons
{
    internal class Program
    {

        static void Main(string[] args)
        {
            new Homework().HomeworkCsharp();

            
        }

    }
}






























/*
LESSON 1!!!!!!!!!!!!!!!!!!!

            String a = "Hello World!";
            Console.WriteLine(a + "FUCKING WORLD");

            Console.WriteLine("Привет ЁБАННЫЙ МИР!!!");
            Console.WriteLine("Please, enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please, enter b: ");
            int b = Convert.ToInt32(Console.ReadLine());

=====================================================================
LESSON 2!!!!!!!!!!!!!!!!!!!

            if (a >= 1 && a <= 10)
            {
                a = 15;
            }
            else
            {
                Console.WriteLine("A is not empty!");
            }

            Console.WriteLine("a = " + a + " b = " + b);

=====================================================================
 LESSON 3!!!!!!!!!!!!!!!!!!!

            bool variableFalse = false;

            bool variableTrue = true;

            Console.WriteLine(variableFalse);

            Console.WriteLine(variableTrue);

=====================================================================
 LESSON 4!!!!!!!!!!!!!!!!!!!

            Console.WriteLine("Please, enter b: ");
            int b = Convert.ToInt16(Console.ReadLine());
            int a = 0;
            if (b > 10)
            {
                a = 1;
            }
            else { a = 5; }

            Console.WriteLine(a);

            a = 55;
            Console.WriteLine(a);

=====================================================================
 LESSON 5!!!!!!!!!!!!!!!!!!!

            string data;

            data = Console.ReadLine();

            Console.WriteLine("Салам " + data);

=====================================================================
 LESSON 6!!!!!!!!!!!!!!!!!!!

            string str;

            int a, b;

            Console.WriteLine("Enter first value: ");

            str = Console.ReadLine(); 

            a = Convert.ToInt16(str);

            Console.WriteLine("Enter second value: ");

            str = Console.ReadLine();

            b = Convert.ToInt16(str);

            int result = a + b;

            Console.WriteLine("Sum of numbers = " + result);
            ///////////
            string str = "1.9";

            double a = Convert.ToDouble(str);

            Console.WriteLine(a);

=====================================================================
 LESSON 7!!!!!!!!!!!!!!!!!!!

            string str = "1";
            try
            {
                int a = int.Parse(str);
                Console.WriteLine(a);
                Console.WriteLine("Success convertation!");
            }
            catch (Exception)
            {

                Console.WriteLine("Fuck you!");
            }

string str = "7";

            int a;

            bool result = int.TryParse(str, out a);

            if (result)
            {
                Console.WriteLine("Operation success, a = " + a);
            }
            else
            {
                Console.WriteLine("Operation failed!");
            }

=====================================================================
 LESSON 8!!!!!!!!!!!!!!!!!!!

            int a = 10;
            int b = 3;
            int c = 5;

            int result = a + b + c;

            if (a % 2 == 0)
            {
                result = "even number";
            }
            else
            {
                result = "odd number";
            }


            Console.WriteLine(result);

=====================================================================
 LESSON 9, 10!!!!!!!!!!!!!!!!!!!

            int result = 5 * 4 / 2;

            Console.WriteLine(result);

=====================================================================
 LESSON 11!!!!!!!!!!!!!!!!!!!

            int a = 0;

            while (a < 2)
            {
                ++a;
                Console.WriteLine(a);
            }

            //Console.WriteLine(a);

=====================================================================
 LESSON 12!!!!!!!!!!!!!!!!!!!

            int a = 5;
            int b= 4;

            Console.WriteLine(a == b);

=====================================================================
 LESSON 13!!!!!!!!!!!!!!!!!!!

            Console.WriteLine("Please enter first value: ");
            double a = Convert.ToDouble(Console.ReadLine());

            if (a >= 10)
            {   
                Console.WriteLine("DADA");
            }
            else
            {
                Console.WriteLine("NENE");
            }

=====================================================================
 LESSON 14!!!!!!!!!!!!!!!!!!!

bool isInfected = false;

            if (!isInfected)
            {
                Console.WriteLine("He's good");
            }



            int fanSpeed = 3000;

            bool isHightTemperature = true;

            bool isNoCooling = true;

            bool hasNoCooling = fanSpeed <= 0;

            if (isHightTemperature && isNoCooling)
            {
                Console.WriteLine("Your CPU may be damaged!");
            }
            else if (!isNoCooling && isHightTemperature)
            {
                Console.WriteLine("Cooler is broken");
            }
            else
            { 
                Console.WriteLine("You are dead"); 
            }


=====================================================================
 LESSON 15!!!!!!!!!!!!!!!!!!!

            Console.WriteLine("Please enter 'a' value");
            string a = Console.ReadLine();

            switch (a)
            {
                case "+":
                    Console.WriteLine("You entered plus");
                    break;
                case "-":
                    Console.WriteLine("You entered minus");
                    break;
                default:
                    Console.WriteLine("You entered undefined symbol");
                    break;
            }

=====================================================================
 LESSON 16!!!!!!!!!!!!!!!!!!!

            int count = 0;
                        int limit  = int.Parse(Console.ReadLine());

                        while (count < limit)
                        {
                            count++;
                            Console.WriteLine(count);
                        }

=====================================================================
 LESSON 17!!!!!!!!!!!!!!!!!!!

            int count = 0;

                        do
                        {
                            count++;
                            Console.WriteLine(count);
                        } while (count < 5);



=====================================================================
 LESSON 18!!!!!!!!!!!!!!!!!!!

            int limit = int.Parse(Console.ReadLine());

            int test = 0;
            int i = 0;

            for (int i = 0; i <= limit; i++)
            {
                Console.WriteLine(i);
                test += i;
            }

            Console.WriteLine(test);

            while (i <= limit)
            {
                Console.WriteLine(i);
                i++;
            }

=====================================================================
 LESSON 19!!!!!!!!!!!!!!!!!!!

             int limit = int.Parse(Console.ReadLine());

             for (int i = 0; i <= limit; i++)
             {
                Console.WriteLine(i);
             }


             for (int i = 0; i < 5;) 
             {
                 i++;
                 Console.WriteLine(i);
             }


            for (int i = 0, j = 5; i < 10 && j < 12; i++, j++)
            {
                Console.WriteLine("i: " + i);
                Console.WriteLine("j: " + j);
            }

            for (int i = 0, j = 5; i < 5 && j > 0; i++, j--)
            {
                Console.WriteLine("i: " + i);
                Console.WriteLine("j- " + j);
            }

            Console.ReadLine();


            int i = 0;

            for (; i < 3; i++) 
            {
                Console.WriteLine("for_1: " + i);
            }
            for (; i < 5; i++)
            {
                Console.WriteLine("for_2: " + i);
            }

             for (;;) 
             {
                 Console.WriteLine("For is working");
                 System.Threading.Thread.Sleep(300);
                 break;
             }
             Console.ReadLine();

=====================================================================
 LESSON 21!!!!!!!!!!!!!!!!!!!


            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();     


=====================================================================
 LESSON 22!!!!!!!!!!!!!!!!!!!

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("cycle 1, iteration : " + i);
                for (int j = 1; j <= 4; j++) 
                {
                    Console.WriteLine("\tcycle 2, iteration : " + j);
                    for (int k = 0; k <= 2; k++)
                    {
                        Console.WriteLine("\t\tcycle 3, iteration : " + k);
                    }
                }    
            }
            
            Console.ReadLine();

=====================

            Console.Write("Enter height of square: ");
            int height = int.Parse(Console.ReadLine());

            Console.Write("Enter width of square: ");
            int width = int.Parse(Console.ReadLine());

            for (int j = 0; j < height; j++)
            {

                for (int i = 0; i < width; i++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

=====================
Example 1
         static int[,] GetRandomArray(int rows, int columns) 
        {
            Random random = new Random();
            var result = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = random.Next(100);
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            //new Homework().HomeworkCsharp();

            int rows = 5; 
            int columns = 10;
            var myArray = GetRandomArray(rows, columns);

            for (int i = 0;i < rows; i++) 
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{myArray[i,j]}\t");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
            
        }
 */


