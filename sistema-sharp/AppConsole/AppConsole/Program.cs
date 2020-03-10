using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tipos de variáveis
            int i = 1;
            //i = "s";

            var x = 2;
            //x = "3333";

            char t = 'B';
            string t2 = "B";


            string n = "Jose";
            var n2 = "Jose Thome";

            // Variável float
            var f = 1.5f;
            float f2 = 1.5f;

            // Variável double
            var d = 2.5;
            double d2 = 2.5;

            // Tipagem dinâmica
            var bo = true;
            var bo2 = true;

            // Tipagem estática
            bool bol = true;
            bool bol2 = false;

            // Conversão do tipo cast
            bool boolean = bool.Parse("false");
            bool boolean2 = Convert.ToBoolean(d);
            
            Console.WriteLine(i);
            Console.WriteLine(x);
            Console.WriteLine(n);
            Console.WriteLine(n2);

            Console.WriteLine(f);
            Console.WriteLine(f2);

            Console.WriteLine(d);
            Console.WriteLine(d2);

            Animal a = new Animal();
            Leao l = new Leao();

            l = (Leao) a;
            a = l;

            Console.WriteLine(t);
            Console.WriteLine(t2);

        }

        public class Animal
        {

        }

        public class Leao : Animal
        {

        }
    }
}
