﻿using ModelInClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new ExperimentalDbContext();
            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}
