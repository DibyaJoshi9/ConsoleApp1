using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            int Sum = p.Add(10, 20);
            Console.WriteLine("Sum ={0}", Sum);

        }
        public int Add(int F, int S)
        {
            return F + S;



        }
    }

}