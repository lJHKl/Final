using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename;
            string s;
            String[] ss;
            DirectoryInfo dir = new DirectoryInfo(@"C:\tests");
            FileSystemInfo[] files = dir.GetFileSystemInfos();
            for(int i=0; i<files.Length; i++)
            {
                filename=files[i].Name;
                s=File.ReadAllText(filename);
                ss = s.Split(' ');
                for (int j = 0; j < ss.Count(); j++)
                    if (int.Parse(ss[j]) % 2 != 0 && int.Parse(ss[j]) % 3 != 0 && int.Parse(ss[j]) % 5 != 0 && int.Parse(ss[j]) % 7 != 0 && int.Parse(ss[j]) % 11 != 0)
                        Console.WriteLine(filename);
            }
        }
    }
}
