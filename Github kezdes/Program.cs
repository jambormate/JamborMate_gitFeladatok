﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Github_kezdes
{
    internal class Program
    {
        static void f01(int[] args)
        {
            Random random = new Random();
            for (int i = 0; i < args.Length; i++)
            {
                args[i] = random.Next(1, 50);
            }
        }
        static int f02(int[] args)
        {
            int szamlalo = 0;
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] %2 == 0) 
                {  
                    szamlalo++; 
                }
            }
            return szamlalo;
        }

        static double f03(int[] args)
        {
            double atlag = 0;
            for (int i = 0; i < args.Length; i++)
            {
                atlag += args[i]; 
            }
            return atlag/args.Length;
        }

        static int[] f04(int[] args)
        {
            int[] paratlanok = new int[10];
            for (int i = 0; i < paratlanok.Length; i++)
            {
                if (args[i] %2 == 0)
                {
                    paratlanok[i] = args[i]+1;
                }
                else
                {
                    paratlanok[i] = args[i];
                }
            }
            return paratlanok;
            
        }

        static void Main(string[] args)
        {
            int[] args1 = new int[10];
            f01(args1);
            Console.WriteLine(f02(args1));
            Console.WriteLine(f03(args1));
            Console.WriteLine(f04(args1));
            for (int i = 0; i < f04(args1).Length; i++)
            {
                Console.WriteLine(f04(args1)[i]);
            }
        }
    }
}
