using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program 
{
    class BOX_Player : Sportsman,Done
    {
        public void win()
        {
            Console.WriteLine("Боксер нокаутировал соперника");
        }
        public override void training()
        {
            Console.WriteLine("\nБоксёр бьёт по груше\n");
        }
    }
}
