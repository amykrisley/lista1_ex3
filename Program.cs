﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1_ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int d;
            int a;
           
            Console.Write("informe o valor da diagonal: ");
            d = int.Parse(Console.ReadLine());
            a = (d * d)/2;
            Console.WriteLine("o valor  da área é:{0} ", a);
        }
    }
}
