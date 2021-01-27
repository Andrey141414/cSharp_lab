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
            Chess_figure.quantity = 16;
            
            do
            {
                int ch;
                Console.ReadKey(true);
                Chess_figure.cut();
                Chess_figure.quantityDisplay();
                //Chess_figure.pause();
            } while (Chess_figure.quantity >= 0);
        }
    }
}
