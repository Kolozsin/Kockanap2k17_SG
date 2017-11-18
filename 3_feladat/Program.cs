using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            string insertString = Console.ReadLine();
            string program = Console.ReadLine();
            long repeat = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            Exec(insertString,program,repeat,min,max);
        }

        private static void Exec(string insertString,string program,long repeat,int min,int max)
        {
            string output = "";
            string newinput = insertString;
            for (int i = 0; i < repeat; i++)
            {
                
                if(newinput.Length>max*2)
                {
                    break;
                }
                else
                {
                    newinput = ReplaceParameter(newinput, program);
                }
            }
            output = newinput;
            if (output.Length>=max)
            {
                Console.WriteLine(output.Substring(min-1,max-min+1));
            }
            else
            {
                int expand = max - output.Length;
                for (int i = 0; i < expand; i++)
                {
                    output += "-";
                }
                Console.WriteLine(output.Substring(min-1, max-min+1));
            }
        }


        public static string ReplaceParameter(string insertstring,string program)
        {
            return program.Replace("$", insertstring);
        }
    }
}
