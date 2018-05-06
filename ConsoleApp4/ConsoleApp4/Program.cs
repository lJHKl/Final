using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool kek = false;
            int c = 0;
            string s = Console.ReadLine();
            string[] ss = s.Split(' ');
            Console.WriteLine(ss.Count());
            for(int i=0; i<ss.Count(); i++)
            {
                for(int j=0; j<ss[i].Length/2; j++)
                {
                    if (ss[i][j] == ss[i][ss[i].Length - j - 1]) kek = true;
                    else kek = false;
                }
                if (kek) c = c + 1;
            }
            Console.WriteLine(c);
        }
    }
}
