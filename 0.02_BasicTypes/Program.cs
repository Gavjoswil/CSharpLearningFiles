﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02_BasicTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte myByte = 255; //range: 0 - 255

            int number1 = 15;
            int number2 = 5;
            int number3 = 10;

            float myFloat = 3.14f;

            double myDouble = 2.54;

            decimal myDecimal = 3.14159M;

            char myLetter = 'A';

            string myName = "Gavin";// Holds up to 2 gigs

            bool myTruth = true;

            Console.WriteLine(myName);

            //Declaration
            // <type> <variableName> = <optional initializer>;
            int age;
            string country;
            //Initialization
            age = 41;
            Console.WriteLine(age);
            age = 42;
            Console.WriteLine(age);
            Console.ReadLine();
        }
    }
}
