﻿using System;
using BuilderPattern.Functional;
using BuilderPattern.GenericFluent;
using BuilderPattern.Html;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Html Test---");
            HtmlTester.Test();
            Console.WriteLine("---Generic Fluent Test---");
            GenericFluentTester.Test();
            Console.WriteLine("---Functional Test---");
            FunctionalTester.Test();
        }
    }
}