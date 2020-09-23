﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerzioKezelesHF
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tizSzam = new int[10];
            double szum = 0;
            for (int i = 1; i <= tizSzam.Length; i++)
            {
                Console.Write("Adja meg a {0} számot: ", i);
                try
                {
                    tizSzam[i-1] = int.Parse(Console.ReadLine());
                    szum += tizSzam[i-1];
                }
                catch (Exception)
                {
                    Console.WriteLine("Hibás értéket adott meg!");
                }
            }
            Console.WriteLine("A beírt számok átlaga: {0}", szum/tizSzam.Length);
            Console.ReadKey();
        }
    }
}
