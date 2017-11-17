using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4thexc
{

    class Program
    {
        
        static void Main(string[] args)
        {
            int N, H, W;
            N = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            string[] s1 = s.Split(' ');
            H = int.Parse(s1[0]);
            W = int.Parse(s1[1]);
            string[,] Place = new string[H, W];

            string[] s2 = new string[H];

            for (int i = 0; i < H; i++)
            {
                s2[i] = Console.ReadLine();
                s1 = s2[i].Split(';');  
                for (int j = 0; j < W; j++)
                {
                    Place[i, j] = s1[j];
                }
            }

            for (int i = 0; i < N; i++)
            {
                Place = Turn(Place);
            }

            for (int i = 0; i < H; i++)
            {
                for (int j = 0; j < W; j++)
                {
                    if(Place[i,j] == "-1")
                        Console.Write(" ");
                    else
                        Console.Write(Place[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static string[,] Turn(string[,] place)
        {
            int H = place.GetLength(0);
            int W = place.GetLength(1);
            string[,] newPlace = new string[H, W];

            for (int i = 0; i < H; i++)
            {
                for (int j = 0; j < W; j++)
                {
                    if (place[i, j] == "1")
                    {
                        newPlace[i, j] = "0";
                    }
                    if (place[i, j] == "0")
                        newPlace[i, j] = "-1";
                    if (place[i, j] == "-1")
                    {
                        int ss = 0;
                        try
                        {
                            ss += int.Parse(place[i - 1, j]);
                        }
                        catch (IndexOutOfRangeException)
                        {

                        };
                        try
                        {
                            ss += int.Parse(place[i + 1, j]);
                        }
                        catch (IndexOutOfRangeException)
                        {

                        };
                        try
                        {
                            ss += int.Parse(place[i, j - 1]);
                        }
                        catch (IndexOutOfRangeException)
                        {

                        };
                        try
                        {
                            ss += int.Parse(place[i, j + 1]);
                        }
                        catch (IndexOutOfRangeException)
                        {

                        };

                        if (ss == 2)
                            newPlace[i, j] = "1";
                        else
                            newPlace[i, j] = "0";
                    }
                }
            }
            return newPlace;
        }


    }
}
