using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Chess_Player :Sportsman,Done 
       
    {
        public void win()
        {
            Console.WriteLine("Шахматист поставил мат");
        }
        public override void training()
        {
            Console.WriteLine("\nШахматист учит теорию дебютов\n");
        }

         

        private int numbers;
        public int GetNumbers()
        {
            return numbers;
        }

        private String PlayerName;
        public String GetName()
        {
            return PlayerName;
        }

        public int rank;




        public Chess_figure figures;
        public bool color = true;

        public void test()
        {
            Console.WriteLine("SuperClass\n");
        }




        public  Chess_Player()
        {
            PlayerName = "Andrey";
            numbers = 5;
            figures = new Chess_figure();
            rank = 1;
            color = false;
        }

        public String ToString()
        {
            
            return "\nName - " + this.GetName() + "\nNumbers of figures is " + this.GetNumbers() + "\nRank - " + rank + "\n" + "Фигура " + figures.ToString();
        }




        public void playerCompare(Chess_Player player)
        {
            Console.WriteLine("{0} VS {1}\n", PlayerName, player.PlayerName);


            if (player.rank < rank)
            {
                Console.WriteLine(" Победил {0} ", player.PlayerName);
            }
            if (player.rank > rank)
            {
                Console.WriteLine(" Победил {0} ", PlayerName);
            }
            if (player.rank == rank)
            {
                Console.WriteLine(" Ничья \n");
            }

        }
    }
}
