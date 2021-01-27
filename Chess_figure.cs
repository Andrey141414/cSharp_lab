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
        public static int quantity;
        public int value;
        public bool pawn;

        static public void  pause()
        {
            Console.WriteLine("\n");
            Console.ReadKey();
            Console.Clear();
        }
        static public void cut()
        {
           
                --quantity;
           
        }
        static public void quantityDisplay()
        {
            if (quantity > 0)
            {
                Console.WriteLine($"{ "You have"}    { quantity} { "figures\n"}");
            }
            else
            {
               Console.WriteLine( "You lose!!!\n");
            }
        }


      
    }
}

