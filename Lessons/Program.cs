﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;

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
        struct Point
        {
            public float x;
            public float y;
            public float z;
        }

        static void Foo(Point value)
        {
            
        }

        static void Bar(in Point value)
        {

        }
        static void Main(string[] args)
        {
            //new Homework().HomeworkCsharp();

            Point a = new Point();

            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < int.MaxValue; i++)
            {
                Foo(a);
            }

            sw.Stop();
            Console.WriteLine($"Foo {sw.ElapsedMilliseconds}");

            sw.Restart();

            for (int i = 0; i < int.MaxValue; i++)
            {
                Bar(a);
            }

            sw.Stop();

            Console.WriteLine($"Bar {sw.ElapsedMilliseconds}");

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


=====================================================================
 LESSON 23!!!!!!!!!!!!!!!!!!!


        bool accessAllowed;

            string storedPassword = "qwerty";
            string enteredPassword = Console.ReadLine();

            if (enteredPassword == storedPassword) 
            { 
                accessAllowed = true;
            }
            else
            {
                accessAllowed = false;
            }

            accessAllowed = enteredPassword == storedPassword ? true : false;

==============

            Console.WriteLine(accessAllowed);

            Console.ReadLine();

            int inputData = int.Parse(Console.ReadLine());

            int outputData = inputData < 0 ? 1 : inputData;

            Console.WriteLine(outputData);


            int[] myArray = new int[5];

=====================================================================
 LESSON 24!!!!!!!!!!!!!!!!!!!

            myArray[0] = 10;
            myArray[1] = 3;
            myArray[2] = 15;


            int a = myArray[0];

            Console.WriteLine(myArray[1]);

            Console.ReadLine();

=====================================================================
 LESSON 25!!!!!!!!!!!!!!!!!!!

            int[] myArray = Enumerable.Range(int.Parse(Console.ReadLine()),5).ToArray();

            Console.WriteLine(myArray[3]);


            Console.ReadLine();

=====================================================================
 LESSON 26,27!!!!!!!!!!!!!!!!!!!

            int[] myArray = { 111, 10, 4, 99, 49, 111, 77, 4, 42, 5 };


            int res = myArray.Where(i => i < 20).FirstOrDefault();
            var str = string.Join(" ", res);
            Console.WriteLine("Array = " + str);

            int[] result = myArray.Distinct().OrderBy(i => i).ToArray();

            var str = string.Join(" ", result);
            Console.WriteLine("Array = " + str);

            Console.ReadLine();


=====================================================================
 LESSON 30!!!!!!!!!!!!!!!!!!!

            //data_type [,] name_array

            int[,] myArray = new int[,]
            {
                {2,45,12,51,51 },
                {6, 7, 8, 3, 1 },
                {1, 5,65,78,13 }
            };



            Console.WriteLine(myArray[0, 2]);

            Console.ReadLine();

=====================================================================
 LESSON 31!!!!!!!!!!!!!!!!!!!


            int[,] myArray = new int[,]
            {
                {2,45,12,51,51 },
                {6,7,8,3,1},
                {1,5,65,78,13},
                {6,3,151,5,65 }
            };

            int height = myArray.GetLength(0);
            int witdth = myArray.GetLength(1);

            for (int y = 0; y < myArray.GetLength(0); y++)
            {
                for (int x = 0; x < myArray.GetLength(1); x++)
                {
                    Console.Write($"{myArray[y, x]} \t");
                }
                Console.WriteLine();
            }

            foreach (var item in myArray)
            {
                Console.Write($"{item} ");
            }

=====================================================================
 LESSON 32!!!!!!!!!!!!!!!!!!!


            string[,] myArray = new string[2, 3];
            //Random random = new Random();


            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.WriteLine($"Please enter Y: {i} and X: {j} value");
                    myArray[i, j] = Console.ReadLine();

                }
                
            }

            for (int y = 0; y < myArray.GetLength(0); y++)
            {
                for (int x = 0; x < myArray.GetLength(1); x++)
                {
                    Console.Write($"{myArray[y, x]} \t");
                }
                Console.WriteLine();
            }

          
            Console.ReadLine();

=====================================================================
 LESSON 33!!!!!!!!!!!!!!!!!!!

            /*int[][] myArray = new int[8][];

            myArray[0] = new int[6];
            myArray[1] = new int[3];
            myArray[2] = new int[10];
            myArray[3] = new int[8];
            myArray[4] = new int[11];
            myArray[5] = new int[5];
            myArray[6] = new int[12];
            myArray[7] = new int[9];

            Random rnd = new Random();
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    myArray[i][j] = rnd.Next(100);
                }
            }
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    Console.Write($"{myArray[i][j]} \t");
                }
                Console.WriteLine();
            }
            int[,] myArray2 = new int[10, 5];

            int myArrayRank = myArray.Rank;
            int myArrayRank2 = myArray2.Rank;

            int myArrayLength = myArray.Length;
            int myArrayLength2 = myArray2.Length;

 
=====================================================================
 LESSON 34!!!!!!!!!!!!!!!!!!!

 
            Random rnd = new Random();

            int[,,,] myArray = new int[4, 3, 5, 8];

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    for (int k = 0; k < myArray.GetLength(2); k++)
                    {
                        for (int q = 0; q < myArray.GetLength(3); q++)
                        {
                            myArray[i, j, k, q] = rnd.Next(100);
                        }
                    }
                }
            }

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                Console.WriteLine($"{i + 1} page");
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    for (int k = 0; k < myArray.GetLength(2); k++)
                    {
                        for (int q = 0; q < myArray.GetLength(3); q++)
                        {
                            Console.Write($"{myArray[i, j, k, q]} ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("==================");
            }
 
 
 
=====================================================================
 LESSON 35!!!!!!!!!!!!!!!!!!!

 
        static void Main(string[] args)
        {
            //new Homework().HomeworkCsharp();

            int a, b, c;
            
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            c = Sum(a, b);
            PrintResult(c);

            //Console.WriteLine(Sum(a, b));

            Console.WriteLine($"==============");



            Console.ReadLine();
        }
        static void PrintResult(int result)
        {
            Console.WriteLine($"Result of sum {result}");
        }
        static int Sum(int a, int b)
        {
            return a * b;
        }   
 
=====================================================================
 LESSON 37!!!!!!!!!!!!!!!!!!!
 
        static int b = 13;
        static void Foo()
        {
            int b = 11;
            Console.WriteLine($"{Program.b} and {b}");
        }
        static void Main(string[] args)
        {
            //new Homework().HomeworkCsharp();
            Foo();
            Console.ReadLine();
        }

=====================================================================
 LESSON 41!!!!!!!!!!!!!!!!!!!
 
            string str = null;

            string result = str ?? "default string";

            Console.WriteLine($"number of symbols in the string - {result.Length}");
 
=====================================================================
 LESSON 42!!!!!!!!!!!!!!!!!!!
 
        static int[] GetArray()
        {
            int[] myArray = null;
            return myArray;
        }
        static void Main(string[] args)
        {
            //new Homework().HomeworkCsharp();

            int[] myArray = GetArray();

            Console.WriteLine($"Sum of array elements {myArray?.Sum() ?? 0}");

            Console.ReadLine();
        } 


=====================================================================
 LESSON 45!!!!!!!!!!!!!!!!!!!
 
        struct Point
        {
            public float x;
            public float y;
            public float z;
        }

        static void Foo(Point value)
        {
            
        }

        static void Bar(in Point value)
        {

        }
        static void Main(string[] args)
        {
            //new Homework().HomeworkCsharp();

            Point a = new Point();

            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < int.MaxValue; i++)
            {
                Foo(a);
            }

            sw.Stop();
            Console.WriteLine($"Foo {sw.ElapsedMilliseconds}");

            sw.Restart();

            for (int i = 0; i < int.MaxValue; i++)
            {
                Bar(a);
            }

            sw.Stop();

            Console.WriteLine($"Bar {sw.ElapsedMilliseconds}");

        }
 */



