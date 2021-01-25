using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        public struct Test
        {
            public int integer;
            public String str;
            public void structInit(String str, int integer)
            {
                this.integer = integer;
                this.str = str;
            }
            public void structDisplay()
            {
                Console.WriteLine($"{this.str} {this.integer}\n");
            }
        }
        public static void Main(string[] args)
        {

            // В c# при присваивании структуры присваивается значение полей,
            //если далее изменится один объект, то на второй это не повлияет
            Test a = new Test();
            Test b = new Test();
            a.structInit("First struct", 1);
            a.structDisplay();
            b = a;
            a.structDisplay();
            b.structDisplay();

            b.structInit("Second struct", 2);

            a.structDisplay();
            b.structDisplay();

            Console.WriteLine("\n\n\nClasses\n\n");
            //В c# объекты - ссылки, при присваивании объекту присваивается ссылка,
            //если далее изменится один объект изменится и второй
            Chess_figure a1 = new Chess_figure();
            Chess_figure b1 = new Chess_figure();
            a1.Init(1, "Firest class");
            b1 = a1;

            b1.value++;

            a1.Display();
            b1.Display();
        }
    }
}
