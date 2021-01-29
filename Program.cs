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
            Chess_Player cp = new Chess_Player();
            Man man = new Man(100);


            Console.WriteLine(man.ToString());
            man.test();
            cp.test();





            //Три наследника абстрактного класса спротсмен: шахматист, футболист и боксер
            //В каждом по разному реализуется чисто виртуальная функция "Тренеровка"

            Football_Player fp = new Football_Player();
            BOX_Player bp = new BOX_Player();
            cp.training();
            fp.training();
            bp.training();



           Console.WriteLine("\n\n realisation of interfece Done, method (Win) \n\n");
            cp.win();
            fp.win();
            bp.win();

            
            Console.WriteLine("\n\n\n\nКлонирование\n\n\n\n");
            //Глубокое копирование (Конструктор класса в качестве параметра приниемает ссылку на объект)
            Man Boris = new Man (100);
            Man Piter = new Man (50);

            
            Boris = (Man)Piter.Clone();
            Piter.figures.name = "Queen";
            Piter.numOfParties = 20;

            Console.WriteLine(Boris.ToString());

            //Мелкое копирование (Конструктор класса в качестве параметра приниемает все поля класса)




        }
    }
}
