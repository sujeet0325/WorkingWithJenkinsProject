﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithJenkinsProject
{
    internal class Program
    {
        public void Display()
        {
            Console.WriteLine("Welcome")
        }
        static void Main(string[] args)
        {
            Program p= new Program();
            p.Display();
            Console.ReadLine();
        }
    }
}
