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
        public int value;
        public bool pawn;

        public Chess_figure(String name, int value)
        {
            if (value <= 0)
            {
                Exception ex;
                throw ex = new Exception("Значение < 0");
            }
            this.name = name;
            this.value = value;
        }

        public Chess_figure(String name)
        {
            this.name = name;
            value = 3;
        }

        public Chess_figure()
        {
            this.name = "King";
            this.value = 10;
        }

        public void Display()
        {
            Console.WriteLine($"{name} Ценность {value}");
        }

    }
}

