using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Football_Player : Sportsman, Done

    {
        public void win()
        {
            Console.WriteLine("Футболист забил гол");
        }
        public override void training()
        {
            Console.WriteLine("\nФутболист бьет пенальти\n");
        }
    }
}
