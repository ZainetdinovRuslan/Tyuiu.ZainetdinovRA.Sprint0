﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.ZainetdinovRA.Sprint0.Task5.V0.Lib
{
    public class DataService
    {
        public static int Addition(int a, int b)
        {
            return a + b;
        }

        public static int Subtraction (int a, int b) 
        { 
            return a - b; 
        }

        public static int Multiplication (int a, int b)
        {
            return a * b;
        }

        public static int Division (int a, int b)
        {
            if (b == a)
            {
                Console.WriteLine("Variable b = {0} division by zero is not allowed", b);
                return -1;
            }
            else
            {
                return a / b;
            }
        }
    }
}
