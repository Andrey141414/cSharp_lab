using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Chess_figure
    {
        private String[] NAMES = { "Пешка", "Конь", "Слон", "Ладья", "Ферзь" };

        private String name;
        public String Name
        {
            //Можем получить значение вне класса 
            get
            {
                return name;
            }
            //Не можем присвоить значение вне класса 
            private set
            {
                name = value;
            }
        }

        public int value;
        public bool pawn;

        public static Chess_figure operator +(Chess_figure a,Chess_figure b)
        {
            Chess_figure c = new Chess_figure();
            c.name = a.name + b.name;
            c.value = a.value + b.value;
            c.pawn = true;
            return c;
        }

        public static Chess_figure operator ++(Chess_figure a)
        {
            Chess_figure c = new Chess_figure();
            c.name = "King";
            c.value = 100;
            return c;
        }
        public void Read()
        {

            int vibor;
            Console.WriteLine("Название фигуры");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i + 1}  {NAMES[i]}");

            }


            vibor = Convert.ToInt32(Console.ReadLine());

            name = NAMES[vibor - 1];
            switch (vibor)
            {
                case 1: { value = 1; pawn = true; } break;
                case 2: { value = 3; } break;
                case 3: { value = 3; } break;
                case 4: { value = 5; } break;
                case 5: { value = 9; } break;
            }


        }

        //Использование this
        public void Init(int value, String name)
        {
            this.value = value;
            this.name = name;
            if (this.name == NAMES[0])
                pawn = true;
            else
                pawn = false;
        }


        public void Display()
        {
            Console.WriteLine($"{name} Ценность {value}");
        }




        public void getNameref(ref String name)
        {
            name = this.name;
        }
        public void getNameout(out String name)
        {
            name = this.name;
        }
    }
}

