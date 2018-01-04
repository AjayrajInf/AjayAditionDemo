using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajaytest
{
    public class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            //Commnet added

            Program prog = new Program();
            Console.WriteLine("The Output for Addition is :" + prog.Addition(2, 7));
            Console.WriteLine("The Output for Multiplication is :" + prog.Multiplication(2, 7));
            Console.ReadLine();
          


        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Addition(int a, int b)
        {
            return a + b;
        }
        public int Multiplication(int a, int b)
        {
            return a * b;
        } 

    }
}
