using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajaytest
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Program prog = new Program();
            Console.WriteLine("The Output for Addition is :" + prog.Addition(2, 7));
            Console.ReadLine();//test



        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private int Addition(int a, int b)
        {
            return a + b;
        }

    }
}
