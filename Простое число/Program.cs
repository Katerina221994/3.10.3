using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Простое_число
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            int number = int.Parse(Console.ReadLine());


            bool u = true;
            int n = 1;
            while (n >= number - 1)
            {


                if (number % n == 0)
                {
                    u = false;
                    break;

                }
                n++;
            

            }
            if (u)
            {
                Console.WriteLine("Число простое");

            }
            else {
                Console.WriteLine("Число непростое");
            }

            Console.ReadKey();


}

    }
}





