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
            String[] NAMES = { "Пешка", "Конь", "Слон", "Ладья", "Ферзь" };
            Chess_figure[] MAS = new Chess_figure[10];

            for (int i = 0; i < 10; i++)
            {
                MAS[i] = new Chess_figure();
                switch (i % 5)
                {
                    case 0: { MAS[i].Init(1, NAMES[i % 5]); }; break;
                    case 1: { MAS[i].Init(3, NAMES[i % 5]); }; break;
                    case 2: { MAS[i].Init(3, NAMES[i % 5]); }; break;
                    case 3: { MAS[i].Init(5, NAMES[i % 5]); }; break;
                    case 4: { MAS[i].Init(9, NAMES[i % 5]); }; break;
                }

            }



            int N = 10;
            for (int i = 0; i < N; i++)
            {
                MAS[i].Display();
            }



            for (int i = 0; i < N; i++)
            {

                String a = MAS[i].Name;

                for (int j = i + 1; j < N + 1; j++)
                {
                    String b = MAS[j].Name;
                    if (String.Compare(a, b) == 0)
                    {
                        for (int z = j; z < N - 1; z++)
                        {
                            MAS[z] = MAS[z + 1];
                        }
                        N -= 1;
                    }
                }
            }

            Console.WriteLine("\n\nМассив после обработки\n\n");
            for (int i = 0; i < N; i++)
            {
                MAS[i].Display();
            }




            Console.WriteLine("\n\n");
            Chess_figure fig1 = new Chess_figure();
            fig1.Init(3, "Slon");
            Chess_figure fig2 = new Chess_figure();
            fig2.Init(3, "Queen");


            String str;
            //Параметр не инициолизирован
            fig1.getNameout(out str);
            Console.WriteLine("out    ");
            Console.WriteLine(str);

            //Параметр инициолизирован
            fig2.getNameref(ref str);
            Console.WriteLine("ref    ");
            Console.WriteLine(str);






            //Перегрузка операторов
            Chess_figure Queen = new Chess_figure();
            Chess_figure Ladya = new Chess_figure();
            Chess_figure Slon = new Chess_figure();

            Ladya.Init(5, "Ладья");
            Console.WriteLine("\n\n");
            Console.WriteLine("Ладья");
            Ladya.Display();


            Slon.Init(5, "Слон");
            Console.WriteLine("\n\n");
            Console.WriteLine("Слон");
            Slon.Display();

            Console.WriteLine("\n\n");
            Console.WriteLine("Слон + Ладья");
            Queen = Ladya + Slon;
            Queen.Display();

            Queen++;
            Console.WriteLine("\n\n");
            Queen.Display();


        }
    }
}
