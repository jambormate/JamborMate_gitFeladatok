using System;
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
        static void Main(string[] args)
        {
            int[] args1 = new int[10];
            f01(args1);
        }
    }
}
