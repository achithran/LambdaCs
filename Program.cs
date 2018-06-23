﻿using System;

namespace CSharp_Lambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            MathService mathServ = new MathService();
            mathServ.MathPerformed += (sender, e) => Console.WriteLine("Caluculation Result: " + e.Result);

            mathServ.MultiplyNumbers(43.598, 87.23);
        }
    }
}
