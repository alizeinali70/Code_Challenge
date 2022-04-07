using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge
{
    internal class Program
    {
        static int SimpleAdding(int num)
        {

            // code goes here
            int sum = 0;
            for (int i = num; i > 0; i--)
            {
                sum = sum + i;
            }
            num = sum;
            return num;

        }


        static string covertToinit(string name)
        {
            Console.WriteLine("your name: " + name);
            string[] res = name.Split(' ');
            name = res[0].ToString().Substring(0, 1).ToUpper() + "." + res[1].ToString().Substring(0, 1).ToUpper();
            return name;
        }

        static void Main(string[] args)
        {
        }
    }
}
