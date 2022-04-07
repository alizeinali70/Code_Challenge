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

        static string FirstTwoLetter(string name)
        {
            Console.WriteLine("your name: " + name);
            string[] res = name.Split(' ');
            name = res[0].ToString().Substring(0, 1).ToUpper() + "." + res[1].ToString().Substring(0, 1).ToUpper();
            return name;
        }

        static List<string> MergStrings()
        {
            string[] s1 = { "ali", "reza", "hassan" };
            string[] s2 = { "ali", "reza", "majid" };
            var t = new List<string>();
            var a = "";
            foreach (var item2 in s2)
            {
                t.Add(s1.Where(x => x.Contains(item2)).FirstOrDefault());
               a= item2.Remove(0,item2.Length);
            }


            List<string> s4 = new List<string>();




            return s4;
        }
        static void Main(string[] args)
        {

            Console.WriteLine(string.Join("\t", MergStrings()));
            Console.ReadLine();
        }
    }
}
