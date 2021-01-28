using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int N = 10;
            Chess_figure[] MAS = new Chess_figure[N];
            try
            {
                for (int i = 0; i < N + 1; i++)
                {
                    Chess_figure buff = new Chess_figure("Ladya");
                    MAS[i] = buff;
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Неправильный индекс массива");
            }
            catch (Exception ex)
            {
                string s;
                s = ex.Message;             // s="Аргумент=0"
                Console.WriteLine(s);
                Console.ReadKey();
                System.Environment.Exit(0);

            }

            //в объекте chess_figure, value>0
            Chess_figure a = new Chess_figure("Figure", -5);

        }
    }
}
