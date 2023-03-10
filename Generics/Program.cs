﻿namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to generics programming");
            Console.WriteLine("------------------------------------");
            int[] intArray = { 20, 30, 40 };
            double[] doubleArray = { 12.7, 56.8, 89.2 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };
            string[] stringArray = { "HOW", "ARE", "YOU" };

            Console.WriteLine("Please choose option of program to execute");
            Console.WriteLine("1: PrintArray \n2: PrintArrayUsingGenericMethod \n3: PrintArrayUsingGenericClass \n4. FindMaximumIntergerNumber \n5. FindMaximumFloatNumber");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    PrintArray.ToPrint(intArray);
                    PrintArray.ToPrint(doubleArray);
                    PrintArray.ToPrint(charArray);
                    Console.ReadLine();
                    break;
                case 2:
                    GenericPrintArray.ToPrint<int>(intArray);
                    GenericPrintArray.ToPrint<double>(doubleArray);
                    GenericPrintArray.ToPrint<char>(charArray);
                    GenericPrintArray.ToPrint<string>(stringArray);
                    break;
                case 3:
                    GenericClass<int> intObj = new GenericClass<int>(intArray);
                    intObj.ToPrint();
                    GenericClass<double> doubleObj = new GenericClass<double>(doubleArray);
                    doubleObj.ToPrint();
                    GenericClass<char> charObj = new GenericClass<char>(charArray);
                    charObj.ToPrint();
                    GenericClass<string> stringObj = new GenericClass<string>(stringArray);
                    stringObj.ToPrint();
                    break;
                case 4:
                    Console.WriteLine("Enter 3 Integer Numbers");
                    int a = Convert.ToInt32(Console.ReadLine());
                    int b = Convert.ToInt32(Console.ReadLine());
                    int c = Convert.ToInt32(Console.ReadLine());
                    MaximumIntegerNumber.FindMaxValue(a, b, c);
                    break;
                case 5:
                    //float p=0.0f , q=0.0f , r=0.0f ,result=0.0f;
                    Console.WriteLine("Enter 3 Float Numbers");
                    float p = float.Parse(Console.ReadLine());
                    float q = float.Parse(Console.ReadLine());
                    float r = float.Parse(Console.ReadLine());
                    float result = MaximumFloatNumber.FindMaxValue(p, q, r);
                    Console.WriteLine("{0} is greatest among {1} {2} {3}", result, p, q, r);
                    break;
                default:
                    Console.WriteLine("Choose the correct option");
                    break;
            }
            Console.ReadLine();
        }
    }
}