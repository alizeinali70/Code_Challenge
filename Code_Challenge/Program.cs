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
            //string[] S3 = new string[] { };

            List<string> s3 = new List<string>();



            foreach (var item1 in s1)
            {
                foreach(var item2 in s2)
                {
                    if (item1 == item2)
                    {
                        s3.Add(item1);
                        
                        break;
                    }
                    else
                    {
                        s3.Add(item1);
                        break;
                    }
                }
                

            }
            s3.Append(s2.ToString());
            return s3;
        }
        static void Main(string[] args)
        {

            Console.WriteLine(string.Join("\t", MergStrings()));
            Console.ReadLine();
        }
    }
}
