﻿using System;
using StatePattern.Canvas;
using StatePattern.TrafficLight;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---PersonTest---");
            CanvasTester.Test();
            Console.WriteLine("\n\n---TrafficLightTest---");
            TrafficLightTester.Test();

            Console.ReadKey();
        }
    }
}
