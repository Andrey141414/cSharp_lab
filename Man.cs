using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Man : Chess_Player,ICloneable
    {
        public int numOfParties;


        public Object Clone()
        { 
        return new Man(this.numOfParties);
        }

        //Peregruzka metoda
        public void test()
        {
            Console.WriteLine("SubClass\n");
        }
        public Man(String name) : base()
        {
            this.figures.name = name;
        }

        public String ToString()
        {
            
            return "\nName - " + this.GetName() + "\nNumbers of figures is " + this.GetNumbers() + "\nRank - "+ rank + "\nФигура " + figures.ToString() + "\nParties -" + numOfParties;
        }


        //Вызов конструктора  базового класса в конструкторе производного
        public Man(int num) : base()
        {
            numOfParties = num;
        }
    }
}
