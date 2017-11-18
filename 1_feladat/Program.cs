using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string bracket = Console.ReadLine();
                string temp = "";
                for (int j = 0; j < bracket.Length; j++)
                {
                    if (temp == "" && !(Char.IsLetter(bracket[j]) || Char.IsDigit(bracket[j]) || bracket[j] == ' '))
                    {
                        temp += bracket[j];
                    }
                    else
                    {
                        if (!(Char.IsLetter(bracket[j]) || Char.IsDigit(bracket[j]) || bracket[j] == ' '))
                        {
                            if (Correct(bracket[j], temp[temp.Length - 1]))
                            {
                                temp = temp.Remove(temp.Length-1);
                            }
                            else
                            {
                                temp += bracket[j];
                            }
                        }
                    }
                   
                }
                if (temp.Length == 0)
                {
                    Console.WriteLine("CORRECT");
                }
                else
                {
                    Console.WriteLine("INCORRECT");
                }
            }
        }
        public static bool Correct(char s, char compare)
        {

            if (((compare == '{' || compare =='}') && (s == '}' || s == '{'))||
                ((compare == '(' || compare == ')')  &&( s == ')' ||  s == '('))||
                ((compare == '<' || compare == '>') &&( s == '>' || s == '<'))||
                ((compare == '[' || compare ==']') && (s == ']' || s == '['))
                )

            {
                return true;
            }
            return false;
        }

    }
}
