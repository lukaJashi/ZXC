using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ZXC
{
    internal class Program
    {
        static void Main(string[] args)
        {
         

            for (int ZXC = 1000; ZXC > 0; ZXC -=7)
            {
                Console.WriteLine(ZXC + "-7" + "=" + (ZXC-7) );



                Thread.Sleep(10);
            }
               
                
            for (int i = 1000; i > 0; i -=7)
            {
                Console.WriteLine("nobody hears you nobody hears you nobody hears you nobody hears you nobody hears you nobody hears you");

            
                Thread.Sleep(50);
            }

                Console.ReadLine();
        }

    }
}